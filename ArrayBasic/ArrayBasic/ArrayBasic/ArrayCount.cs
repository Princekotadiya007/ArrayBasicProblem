using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasic
{
    public class ArrayCount
    {
        public void Count()
        {

            int[] array = new int[] { 9, 6, 5, 2, 1, 5, 8, 4 };
            var total = 0;
            total = array.Count();
            Console.WriteLine(total);

            Console.ReadLine();
        }
    }
}
