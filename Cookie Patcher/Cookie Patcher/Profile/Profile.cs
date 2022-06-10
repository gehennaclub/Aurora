using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Patcher.Profile
{
    [Serializable]
    public class Profile
    {
        public string path { get; set; }
        public List<Pointers.Offset> offsets { get; set; }

        public void load(string ipath, List<Pointers.Offset> ioffsets)
        {
            path = ipath;
            offsets = ioffsets;
        }
    }
}
