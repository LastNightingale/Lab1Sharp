using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Sharp
{
    internal class State
    {
        public int StateID { get; set; }
        public string StateName { get; set; }

        public override string ToString()
        {
            string res = $"StateID:{StateID}, StateName:{StateName}" + "\n";
            return res;
        }
    }
}
