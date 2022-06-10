using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aurora
{
    public partial class Aurora : Form
    {
        private byte[] patch = File.ReadAllBytes("patch.config");
        private BackgroundWorker worker = new BackgroundWorker();
        private List<byte> ender = new List<byte>()
        {
            0x0000000D,
            0x0000000A,
            0x00000000
        };

        class Offset
        {
            public int address { get; set; }
            public int limit { get; set; }

            public Offset(int iaddress, int ilimit)
            {
                address = iaddress;
                limit = ilimit;
            }
        }

        public Aurora()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            Region = Region.FromHrgn(Manager.Ui.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            worker.DoWork += new DoWorkEventHandler(build);
        }

        private List<byte> get_bytes(string data)
        {
            List<byte> bytes = new List<byte>();

            foreach (char c in data)
            {
                bytes.Add((byte)c);
            }

            return (bytes);
        }

        private bool validate_byte(byte[] bytes, List<byte> key, int index)
        {
            for (int i = 0; i < key.Count; i++)
            {
                if (bytes[i + index] != key[i])
                {
                    return (false);
                }
            }
            return (true);
        }

        private List<Offset> offset_finder(string content)
        {
            List<Offset> offsets = new List<Offset>();
            int index = 0;
            byte[] bytes = File.ReadAllBytes(open_packchunk.FileName);
            List<byte> key = get_bytes(content);

            Manager.Threads.add_richtext(logs, "seaching offsets");
            for (; index < bytes.Length; index++)
            {
                if ((key.Count + index) <= bytes.Length)
                {
                    if (validate_byte(bytes, key, index) == true)
                    {
                        offsets.Add(
                            new Offset(
                                index,
                                find_limit(index, bytes)
                            )
                        );
                    }
                }
            }
            if (offsets.Count == 0)
            {
                Manager.Threads.add_richtext(logs, "no offset found");
            }
            else
            {
                foreach (Offset offset in offsets)
                {
                    Manager.Threads.add_richtext(logs, $"{offset.address.ToString("X")}::{find_limit(offset.address, bytes).ToString("X")}");
                }
            }

            return (offsets);
        }

        private string cleanner(string raw)
        {
            string[] cleanned = raw.Split('\\');

            return (cleanned[cleanned.Length - 1]);
        }

        private string output_builder(string id)
        {
            List<string> folders = new List<string>()
            {
                "data",
                $"{id}"
            };
            string output = $"{cleanner(open_packchunk.FileName)}";
            string full = "";

            for (int i = 0; i < folders.Count; i++)
            {
                full += $"{folders[i]}";
                if (Directory.Exists(full) == false)
                {
                    Directory.CreateDirectory(full);
                }
                if (i <= (folders.Count))
                {
                    full += "\\";
                }
            }
            full += $"{output}";
            if (File.Exists(full) == true)
            {
                File.Delete(full);
            }
            File.Copy(open_packchunk.FileName, full);

            return (full);
        }

        private void inject(Offset offset, string id, string output)
        {
            BinaryWriter br = new BinaryWriter(File.OpenWrite(output));

            Manager.Threads.add_richtext(logs, $"injecting bypass {id}");
            br.BaseStream.Position = offset.limit;
            for (int i = 0; i < patch.Length; i++)
            {
                br.Write(patch[i]);
            }
            br.Close();

            Manager.Threads.add_richtext(logs, $"{offset.limit - offset.address} bytes injected {id}");
        }

        private void build(List<Offset> offsets)
        {
            string output = null;
            string id = null;

            foreach (Offset offset in offsets)
            {
                id = $"{offset.address.ToString("X")}";
                output = $"{output_builder(id)}";
                Manager.Threads.add_richtext(logs, $"starting build {id}");
                inject(offset, id, output);
                Manager.Threads.add_richtext(logs, $"build completed {id}");
            }
        }

        private byte[] create_payload(int count, byte b)
        {
            List<byte> payload = new List<byte>();

            for (int i = 0; i < count; i++)
            {
                payload.Add(b);
            }

            return (payload.ToArray());
        }

        private void replacement(Offset offset, string id, string output)
        {
            BinaryWriter br = new BinaryWriter(File.OpenWrite(output));
            byte[] payload = create_payload(offset.limit - offset.address, 0);

            Manager.Threads.add_richtext(logs, $"replacing bytes {id}");
            br.BaseStream.Position = offset.address;
            for (int i = offset.address; i < offset.limit; i++)
            {
                br.Write(payload, 0, payload.Length);
            }
            br.Close();

            Manager.Threads.add_richtext(logs, $"{offset.limit - offset.address} bytes replaced {id}");
        }

        private void replace(List<Offset> offsets)
        {
            string output = null;
            string id = null;

            foreach (Offset offset in offsets)
            {
                id = $"{offset.address.ToString("X")}";
                output = $"{output_builder(id)}";
                Manager.Threads.add_richtext(logs, $"starting replace {id}");
                replacement(offset, id, output);
                Manager.Threads.add_richtext(logs, $"replace completed {id}");
            }
        }

        private bool validate_ender(byte[] bytes, int index)
        {
            for (int b = 0; b < ender.Count; b++)
            {
                if ((index + b) < bytes.Length)
                {
                    if (bytes[index + b] != ender[b])
                    {
                        return (false);
                    }
                }
            }

            return (true);
        }

        private int find_limit(int begin, byte[] bytes)
        {
            for (int i = begin; i < bytes.Length; i++)
            {
                if (validate_ender(bytes, i) == true)
                {
                    return (i + (ender.Count - 1));
                }
            }

            return (0);
        }

        private void build(object sender, EventArgs e)
        {
            List<Offset> offsets = offset_finder("[/Script/");

            if (offsets.Count > 0)
            {
                build(offsets);
            } else
            {
                Manager.Threads.add_richtext(logs, $"nothing to build");
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            logs.Clear();
            Manager.Threads.worker(worker);
            Cursor = Cursors.Default;
        }

        private void button_folder_Click(object sender, EventArgs e)
        {
            open_packchunk.ShowDialog();

            if (open_packchunk.FileName != String.Empty)
            {
                pakchunk.Text = open_packchunk.FileName;
            }
        }

        private void button_remove_ppk_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
