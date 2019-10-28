using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesele13
{/*5 dene eded verilib. Bunlardan 3 denesi 5 reqemli. 2 denesi ise 3 reqemlidir.
    5 reqemli ededlerin 5% tap ,neticeleri vur bir birine. 
    Sonra 3 reqemli ededlerin 3% tap ,neticeleri topla.
    Sonra yekunda alinan iki cavalarin her birinin 10%-ni tapib topla.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci 5 reqemli ededi daxil edin");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci 5 reqemli ededi daxil edin");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Uchuncu 5 reqemli ededi daxil edin");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Birinci 3 reqemli ededi daxil edin");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci 3 reqemli ededi daxil edin");
            int num5 = int.Parse(Console.ReadLine());

            double result1 = num1 * 0.05;
            double result2 = num2 * 0.05;
            double result3 = num3 * 0.05;

            double Multy5DigitsNum = result1 * result2 * result3;

            double resultFirst3DigitsNum = num4 * 0.03;
            double resultSecond3DigitsNum = num5 * 0.03;

            double SumResult3DigitsNum = resultFirst3DigitsNum + resultSecond3DigitsNum;

            double ResultEnd =Math.Round( (Multy5DigitsNum * 0.10) + (SumResult3DigitsNum * 0.10),1);
            Console.WriteLine(ResultEnd);
            Console.ReadKey();
        }
    }
}
