using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Sharp
{
    internal class Mark
    {
        public int MarkID { get; set; }
        public string MarkName { get; set; }

        public override string ToString()
        {
            string res = $"MarkID:{MarkID}, MarkName:{MarkName}" + "\n";
            return res;
        }
    }
}
