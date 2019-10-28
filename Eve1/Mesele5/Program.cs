using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesele5
{/*4 reqemli eded verilib. Bu ededin evvelin 4 reqemi , axirina ise 44 ededini artir.
    Alinan cavabin 44 % tap.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 reqemli eded daxil edin");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int count = 0;

            while (temp != 0)
            {
                count++;
                temp /= 10;
            }

            num =(( 4*(int)Math.Pow(10,count)+num)*100)+44;
            double result = num * 0.44;
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
