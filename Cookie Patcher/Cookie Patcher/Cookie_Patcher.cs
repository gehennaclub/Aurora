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

namespace Cookie_Patcher
{
    public partial class Cookie_Patcher : Form
    {
        private BackgroundWorker worker = new BackgroundWorker();
        private BackgroundWorker reverter = new BackgroundWorker();
        private string output = "bin\\patch.bin";
        private Profile.Profile profile = new Profile.Profile();
        private Profile.Manager manager = new Profile.Manager();
        private List<byte> ender = new List<byte>()
        {
            0x0000000D,
            0x0000000A,
            0x00000000
        };

        public Cookie_Patcher()
        {
            InitializeComponent();
            Initialize();
        }

        private bool check_requirements()
        {
            List<string> folders = new List<string>()
            {
                "bin"
            };
            List<string> files = new List<string>();

            if (Check.Folders.run(folders) == true)
            {
                return (Check.Files.run(files));
            }
            return (false);
        }

        private void Initialize()
        {
            Region = Region.FromHrgn(Manager.Ui.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            worker.DoWork += new DoWorkEventHandler(build);
            reverter.DoWork += new DoWorkEventHandler(revert);
            label_version.Text = Manager.Ui.version;
        }

        private void button_select_pakchunk_Click(object sender, EventArgs e)
        {
            open_file.ShowDialog();

            if (open_file.FileName != String.Empty)
            {
                pakchunk.Text = open_file.FileName;
            }
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

        private byte[] get_content(int index, int limit)
        {
            FileStream fs = new FileStream(open_file.FileName, FileMode.Open);
            BinaryReader br = new BinaryReader(fs, Encoding.Default);
            byte[] content = null;

            br.BaseStream.Position = index;
            content = br.ReadBytes(limit - index);
            br.Close();

            return (content);
        }

        private List<Pointers.Offset> offset_finder(string content)
        {
            List<Pointers.Offset> offsets = new List<Pointers.Offset>();
            byte[] bytes = File.ReadAllBytes(open_file.FileName);
            List<byte> key = get_bytes(content);
            int index = 0;
            int limit = 0;

            for (; index < bytes.Length; index++)
            {
                if ((key.Count + index) <= bytes.Length)
                {
                    if (validate_byte(bytes, key, index) == true)
                    {
                        limit = find_limit(index, bytes);
                        offsets.Add(
                            new Pointers.Offset(
                                index,
                                limit,
                                get_content(index, limit)
                            )
                        );
                    }
                }
            }

            return (offsets);
        }

        private string output_builder()
        {
            string full = $"{open_file.FileName}.bak";

            if (File.Exists(full) == false)
                File.Copy(open_file.FileName, full);

            return (full);
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

        private void replacement(Pointers.Offset offset)
        {
            BinaryWriter br = new BinaryWriter(File.OpenWrite(open_file.FileName));
            byte[] payload = create_payload(offset.limit - offset.address, 0);

            br.BaseStream.Position = offset.address;
            br.Write(payload, 0, payload.Length);
            br.Close();
        }

        private void revertement(Profile.Profile profile)
        {
            BinaryWriter br = new BinaryWriter(File.OpenWrite(profile.path));
            byte[] payload = null;

            foreach (Pointers.Offset offset in profile.offsets)
            {
                payload = offset.content;
                br.BaseStream.Position = offset.address;
                br.Write(payload, 0, payload.Length);
            }

            br.Close();
        }

        private void replace(List<Pointers.Offset> offsets)
        {
            output_builder();
            foreach (Pointers.Offset offset in offsets)
            {
                replacement(offset);
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
            List<Pointers.Offset> offsets = null;

            if (open_file.FileName != String.Empty)
            {
                offsets = offset_finder("[==SSL]");
            } else
            {
                MessageBox.Show("No pakchunk selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (offsets.Count > 0)
            {
                replace(offsets);
                profile.load(open_file.FileName, offsets);
                manager.save<Profile.Profile>(output, profile);
                MessageBox.Show("Cookie bypass built", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nothing to patch, your version looks already patched", "Nothing to patch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Manager.Threads.worker(worker);
            Cursor = Cursors.Default;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void revert(object sender, EventArgs e)
        {
            if (File.Exists(output) == true)
            {
                if (profile.offsets == null)
                {
                    profile = manager.load<Profile.Profile>(output);
                }
                if (File.Exists(profile.path) == true)
                {
                    revertement(profile);
                    MessageBox.Show("Cookie bypass removed", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("The file patched cannot be found", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("The patch currently applied to your game has been patched using an older version, you cannot perform this action", "Older version", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void pakchunk_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(pakchunk.Text) == true)
            {
                if (pakchunk.Text.EndsWith(".pak") == true)
                {
                    pakchunk.ForeColor = Color.LimeGreen;
                    button_apply.Enabled = true;
                }
                else
                {
                    pakchunk.ForeColor = Color.DarkRed;
                    button_apply.Enabled = false;
                }
            }
            else
            {
                pakchunk.ForeColor = Color.DarkRed;
                button_apply.Enabled = false;
            }
        }

        private void button_revert_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Manager.Threads.worker(reverter);
            button_revert.Enabled = false;
            Cursor = Cursors.Default;
        }

        private void Cookie_Patcher_Shown(object sender, EventArgs e)
        {
            if (check_requirements() == false)
            {
                MessageBox.Show("Requirement missing, make sure you extracted Cookie Patcher", "Requirement missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
