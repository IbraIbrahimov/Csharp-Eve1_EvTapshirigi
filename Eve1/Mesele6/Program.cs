using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesele6
{/*4 reqemli eded verilib. Bu ededin evvel 20%-ni ,  sonra ise cavabin 10% tap.
    Alinan  cavabin kvadratini tap.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 reqemli eded daxil edin");
            int num = int.Parse(Console.ReadLine());
            double result = num * 0.20;
            result = result * 0.1;
            result =Math.Round( Math.Pow(result, 2),1);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
