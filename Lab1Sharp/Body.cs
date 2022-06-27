using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Sharp
{
    internal class Body
    {
        public int BodyID { get; set; }
        public string BodyName { get; set; }

        public override string ToString()
        {
            string res = $"BodyID:{BodyID}, BodyName:{BodyName}" + "\n";
            return res;
        }
    }
}
