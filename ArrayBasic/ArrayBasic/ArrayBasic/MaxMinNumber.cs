using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasic
{
    public class MaxMinNumber
    {
        public void MinMax()
        {

            int[] numbers = new int[] { 10, 20, 30, 40, 50 };

            int max = numbers[0];
            int min = numbers[0];

            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }

                if (num < min)
                {
                    min = num;
                }
            }

            Console.WriteLine("The maximum element in the array is: " + max);
            Console.WriteLine("The minimum element in the array is: " + min);

            Console.ReadLine();
        }
    }
}
