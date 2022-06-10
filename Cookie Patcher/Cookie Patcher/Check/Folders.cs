using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Patcher.Check
{
    public class Folders
    {
        public static bool run(List<string> folders)
        {
            foreach (string folder in folders)
            {
                if (System.IO.Directory.Exists(folder) == false)
                    return (false);
            }

            return (true);
        }
    }
}
