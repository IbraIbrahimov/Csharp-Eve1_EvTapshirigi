using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesele7
{/*2 dene 5 reqemli eded verilib. Bu ededleri toplayib. Alinan cavabin evveline ve axirina 5 artir.
    Neticenin 5 % tap*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci 5 reqemli ededi daxil edin");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci 5 reqemli ededi daxil edin");
            int num2 = int.Parse(Console.ReadLine());

            int SumAll = num1 + num2;
            int temp = SumAll;
            int count = 0;

            while (temp!=0)
            {
                count++;
                temp /= 10;
            }

            SumAll = ((5 * (int)Math.Pow(10, count) + SumAll) * 10) + 5;

            double result =Math.Round( SumAll * 0.05,1)
                ;

            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
