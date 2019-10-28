using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesele4
{/*3 reqemli eded verilib. Bu ededin axirina 7 artir. Sonra cavabin 7% tap;*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 reqemli eded daxil edin");
            int num = int.Parse(Console.ReadLine());
            
            num = (num * 10) + 7;
            double result = num * 0.07;

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
