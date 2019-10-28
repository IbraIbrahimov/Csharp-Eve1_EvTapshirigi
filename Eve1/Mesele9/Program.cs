using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesele9
{/*3 dene 6 reqemli eded verilib. Her birinin 10 faizini tapib neticeleri topla. 
    Alinan cavabin 10% tap.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci 6 reqemli ededi daxil edin");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci 6 reqemli ededi daxil edin");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Uchuncu reqemli ededi daxil edin");
            int num3 = int.Parse(Console.ReadLine());

            double result1 = num1 * 0.10;
            double result2 = num2 * 0.10;
            double result3 = num3 * 0.10;

            double ResultEnd =Math.Round( (result1 + result2+result3) * 0.10,1);

            Console.WriteLine(ResultEnd);
            Console.ReadKey();
        }
    }
}
