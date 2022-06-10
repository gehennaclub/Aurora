using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Patcher
{
    public class Pointers
    {
        [Serializable]
        public class Offset
        {
            public int address { get; set; }
            public int limit { get; set; }
            public byte[] content { get; set; }

            public Offset(int iaddress, int ilimit, byte[] icontent)
            {
                address = iaddress;
                limit = ilimit;
                content = icontent;
            }
        }
    }
}
