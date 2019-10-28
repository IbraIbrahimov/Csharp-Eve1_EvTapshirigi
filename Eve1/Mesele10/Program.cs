using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesele10
{/*3 dene 4 reqemli eded verilib.  I ededin 1%-ni, II ededin 2% , III ededin 3 % tap. 
    Neticeleri bir birinden cix. Alinan cavabin ustune III ededin 7% faizini gel*/
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Birinci 4 reqemli ededi daxil edin");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci 4 reqemli ededi daxil edin");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Uchuncu 4 reqemli ededi daxil edin");
            int num3 = int.Parse(Console.ReadLine());

            double result1 = num1 * 0.01;
            double result2 = num2 * 0.02;
            double result3 = num3 * 0.03;

            double ResultEnd =Math.Round( (result1 - result2 - result3)+ (num3 * 0.07),1)
                ;

            Console.WriteLine(ResultEnd);
            Console.ReadKey();
        }
    }
}
