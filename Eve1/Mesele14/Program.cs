using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesele14
{/*6 dene 6 reqemli eded verilib. Evvel hamisini topla .
    Sonra I ve III ededi bir birine yapishdir ve bir eded al.  
    I neticeden II neticeni cix. Alinan cavabin 10% tap.
    Neticenin uzerine V ve VI ededleri gel. Yekunda alinan cavabin 11% tap.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci 6 reqemli ededi daxil edin");
            int num1 = int.Parse(Console.ReadLine());
            int temp = num1;
            int count = 0;
            Console.WriteLine("Ikinci 6 reqemli ededi daxil edin");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Uchuncu 6 reqemli ededi daxil edin");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dorduncu 6 reqemli ededi daxil edin");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Beshinci 6 reqemli ededi daxil edin");
            int num5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Altinci 6 reqemli ededi daxil edin");
            int num6 = int.Parse(Console.ReadLine());

            int SumAll = num1 + num2 + num3 + num4 + num5 + num6;

            while (temp != 0)
            {
                count++;
                temp /= 10;

            }

            long NewNumber = num3 * (long)Math.Pow(10, count) + num1;

            double result =Math.Abs( (SumAll - NewNumber) * 0.10);
            result =Math.Round( (result + num5 + num6)*0.11,1);




            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
