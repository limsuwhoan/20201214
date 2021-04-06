using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testmode
{
    class Program
    {
        static void Main(string[] args)
        {
           /* 1inch = 2.54cm*/
            Console.Write("inch단위를 입력받아 cm단위를 구하는 코드를 작성하시오" + "\t" + "입력값:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a + "cm = " + a * 2.54 + "cm");
            Console.Write("킬로그램 단위를 입력받아 파운드를 구하는 코드를 작성하시오" + "\t" + "입력값:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(b + "kg" + " = " + b * 2.20462262 + "pound");
            Console.Write("원의 반지름을 입력받아 원의 둘레와 넓이를 구하는 코드를 작성하시오" + "\t" + "입력값:");
            double pi = 3.14;
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("둘레" + "=" + 2 * pi * c);
            Console.WriteLine("넓이" + "=" + pi * c * c);

            Console.WriteLine("2번 문제");

            int ab = int.Parse(Console.ReadLine());
            int cd = int.Parse(Console.ReadLine());
            int aa = ab * (cd % 10);
            int aaa = ab * ((cd%100 )/10);
            int aaaa = ab * (cd /100);
            Console.Write(ab + " ······  (1)"+"\n");
            Console.Write("x"+cd + " ······(2)" + "\n");
            Console.WriteLine("------------------" + "\n");
            Console.WriteLine(aa + " ······(3)" + "\n");
            Console.WriteLine(aaa + " ······(4)" + "\n");
            Console.WriteLine(aaaa + " ······(5)" + "\n");
            Console.WriteLine("------------------" + "\n");
            Console.WriteLine(ab*cd + " ······(6)" + "\n");
        }
    }
}
