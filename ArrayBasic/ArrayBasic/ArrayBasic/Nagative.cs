using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasic
{
    public class Nagative
    {
        public void NagativeValue()
        {
            int[] array = { 10, -20, 30, 40 ,-50 };
            Console.WriteLine("Negative Numbers are:");
            foreach (int number in array)
            {
                if (number < 0)
                {
                    Console.WriteLine("Negative Numbers are" + number);
                }
            }
            Console.ReadLine();
        }
    }
}
