using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesele8
{/*2 dene eded verilib. I eded 4 reqemli II eded 7 reqemlidir.
   I ededin 4%-ni tap. 
   Sonra II ededin 9% ni tap. 
   Sonra Cavalari toplayib 10 %ni tap.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 reqemli ededi daxil edin");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("7 reqemli ededi daxil edin");
            int num2 = int.Parse(Console.ReadLine());

            double result1 = num1 * 0.04;
            double result2 = num2 * 0.09;

            double ResultEnd = (result1 + result2) * 0.10;

            Console.WriteLine(ResultEnd);
            Console.ReadKey();
        }
    }
}
