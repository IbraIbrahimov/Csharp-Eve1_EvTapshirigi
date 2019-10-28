using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesele12
{/*4 dene 6 reqemli eded verilib. Ededlerin hamisinin 10 faizini tap ve topla.
    Sonra hamisinin 15 faizini tap ve topla. 
    Sonra yekunda alinanlar iki cavabi vur biri birine. 
    Alinan neticenin evvel 10% tap sonra ise hemin cavabin 11% tap.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci 6 reqemli ededi daxil edin");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci 6 reqemli ededi daxil edin");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Uchuncu 6 reqemli ededi daxil edin");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dorduncu 6 reqemli ededi daxil edin");
            int num4 = int.Parse(Console.ReadLine());

            double result1 =num1 * 0.10;
            double result2 =num2 * 0.10;
            double result3 =num3 * 0.10;
            double result4 =num4 * 0.10;

            double FirstSum = result1 + result2 + result3 + result4;

            double result12 = num1 * 0.15;
            double result22 = num2 * 0.15;
            double result32 = num3 * 0.15;
            double result42 = num4 * 0.15;

            double SecondSum = result12 + result22 + result32 + result42;

            double MultySum = FirstSum * SecondSum;
            double resultEnd = MultySum * 0.10;
            resultEnd =Math.Round( resultEnd * 0.11,1);

            Console.WriteLine(resultEnd);
            Console.ReadKey();



        }
    }
}
