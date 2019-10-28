using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesele11
{
    class Program
    {/*4 dene 5 reqemli eded verilib. Her I ededin ustune III ededi gel . II ededin usutune IV eeddi gel. 
    Sonra cavablari vur birbirine. Alinan neticeden III ededin 3%-ni cix.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci 5 reqemli ededi daxil edin");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci 5 reqemli ededi daxil edin");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Uchuncu 5 reqemli ededi daxil edin");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dorduncu 5 reqemli ededi daxil edin");
            int num4 = int.Parse(Console.ReadLine());

            num1 = num1 + num3;
            num2 = num2 + num4;
            double result = num1 * num2;
            result = result - (num3 * 0.03);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
