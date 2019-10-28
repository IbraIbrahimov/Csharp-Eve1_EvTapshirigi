using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eve1
{/*4 reqemli eded verilib. Bu ededin eveline 7 reqemini , axirinada 8 reqemini artir. Example1: 333= 73338*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 reqemli eded daxil edin");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int count = 0;

            while (temp!=0)
            {
                count++;
                temp /= 10;
            }

            num = ((7 * (int)Math.Pow(10, count) + num) * 10) + 8;
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
