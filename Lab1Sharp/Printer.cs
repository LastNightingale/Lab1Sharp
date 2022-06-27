using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Sharp
{
    internal class Printer
    {        
        public void Prints<TValue>(IEnumerable<TValue> toPrint)
        {
            foreach (TValue el in toPrint)
            {
                Console.WriteLine(el);
            }
        }
        public void Prints<TValue>(TValue toPrint)
        {
            Console.WriteLine(toPrint);
        }
        public void Prints<TKey, TValue>(IEnumerable<IGrouping<TKey, TValue>> toPrint)
        {
            foreach (IGrouping<TKey, TValue> grouping in toPrint)
            {
                Console.WriteLine(grouping.Key);
                foreach (TValue el in grouping)
                {
                    Console.WriteLine(el);
                }
            }
        }

        public void Prints<T,Q>(Dictionary <T, List<Q>> dictionary)
        {
            foreach (var groupQuere in dictionary)
            {
                Console.WriteLine(groupQuere.Key);
                foreach (var el in groupQuere.Value)
                {
                    Console.WriteLine(el.ToString());
                }
            }
        }
    }
}
