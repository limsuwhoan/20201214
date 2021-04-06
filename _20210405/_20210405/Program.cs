using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210405
{
    class Program
    {
        static void Main(string[] args)
        {
            double inch = double.Parse(Console.ReadLine());
            Console.WriteLine(inch * 2.54 + "cm");
            Console.WriteLine(string.Format("{0}cm",inch*2.54));
            Console.WriteLine($"{inch * 2.54}cm");

            double pound = double.Parse(Console.ReadLine());
            Console.WriteLine(pound * 2.20462262 + "pound");

            double r = double.Parse(Console.ReadLine());
            const double PI = 3.14;
            Console.WriteLine("둘레:" + (r * PI * 2));
            Console.WriteLine("넓이:" + (r * PI * r));


            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());

            
            Console.WriteLine(one*(two%10));
            Console.WriteLine(one*((two%100)/10));
            Console.WriteLine(one*(two/100));
            Console.WriteLine(one*two);

            Console.WriteLine("문제재기");

            string sTwo = two.ToString();

            Console.WriteLine(one*int.Parse(sTwo[2].ToString()));
            Console.WriteLine(one*(sTwo[1]-'0'));
            Console.WriteLine(one * (sTwo[0] - '0'));


        }
    }
}
