using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesele3
{/*5 reqemli eded verilib. Bu ededin evvel  18 % sonra ise 3 % tap.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5 reqemli eded daxil edin");
            int num = int.Parse(Console.ReadLine());
            double result = num * 0.18;
            result = result * 0.03;

            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
