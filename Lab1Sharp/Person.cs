using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Sharp
{
    internal class Person
    {
        public int LicsenseNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string BirthDate { get; set; }   
        public string RegisterAdress { get; set; }
        public int Experience { get; set; }
        
        public override string ToString()
        {
            return $"LicenseNumber:{LicsenseNumber}, Name:{Name}, Surname:{Surname}, Patronymic:" +
                $"{Patronymic}, BirthDate:{BirthDate}, RegisterAdress:{RegisterAdress}, Experience:" +
                $"{Experience}";
        }
    }
}
