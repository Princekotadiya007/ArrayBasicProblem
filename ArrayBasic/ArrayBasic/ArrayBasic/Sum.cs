﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasic
{
    public class Sum
    {
        public void SumValue()
        {
            int[] numbers = new int[] { 10, 20, 30, 40, 50 };

            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }

            Console.WriteLine("The sum of all elements in the array is: " + sum);

            Console.ReadLine();
        }
    }
}
