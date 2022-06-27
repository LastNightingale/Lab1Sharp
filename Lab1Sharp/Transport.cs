using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Lab1Sharp
{
    internal class Transport
    {
        public int CarID { get; set; }
        public int MarkID { get; set; }
        public int ProducerID { get; set; }
        public string Model { get; set; }
        public int BodyID { get; set; }
        public int ManufactureYear { get; set; }
        public int ChassisNumber { get; set; }
        public Color CarColor { get; set; }
        public string Sign { get; set; }
        public int StateID { get; set; }
        
        public override string ToString()
        {
            string res = $"CarID:{CarID}, Mark:{MarkID}, ProducerID:{ProducerID}, Model:" +
                $"{Model}, Body:{BodyID}, ChassisNumber:{ChassisNumber}, Color:" +
                $"{CarColor}, Sign:{Sign}, State:{StateID}" + "\n";            
            return res;
        }
    }
}
