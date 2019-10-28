using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesele2
{/*3 reqemli eded verilib. Bu ededin axirina hemin ededdin ozunu yapishdir. example: 333= 333333;*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 reqemli eded daxil edin");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int count = 0;

            while (temp != 0)
            {
                count++;
                temp /= 10;
            }

            num = num*(int)Math.Pow(10,count)+num;
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
