using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Patcher.Check
{
    public class Files
    {
        public static bool run(List<string> files)
        {
            foreach (string file in files)
            {
                if (System.IO.File.Exists(file) == false)
                    return (false);
            }

            return (true);
        }
    }
}
