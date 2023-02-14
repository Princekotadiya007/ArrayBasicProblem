using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasic
{
    public class ArrayLength
    {
        public void Length()
        {
            int[] numbers = new int[] { 10, 20, 30, 40, 50 };

            int length = numbers.Length;

            Console.WriteLine("The length of the array is: " + length);

            Console.ReadLine();
        }
    }
}
