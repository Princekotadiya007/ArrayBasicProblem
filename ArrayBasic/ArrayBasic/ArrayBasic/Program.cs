using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasic
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 ArrayLength, \n2 ArrayLength, \n3 Sum, \n4 NagativeNumber");
            Console.WriteLine("choose the option");
            int opiton = Convert.ToInt32(Console.ReadLine());

            switch (opiton)
            {
                case 1:
                    MaxMinNumber minMaxNUmber = new MaxMinNumber();
                    minMaxNUmber.MinMax();
                    break;
                case 2:
                    ArrayLength arrayLength = new ArrayLength();
                    arrayLength.Length();
                    break;
                case 3:
                    Sum sum = new Sum();
                    sum.SumValue();
                    break;
                case 4:
                    Nagative nagative = new Nagative();
                    nagative.NagativeValue();
                    break;
            }
        }
    }
}
