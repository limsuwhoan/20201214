using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slip2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2.번 문제 숫자를 입력받아 다음과같은 출력값을 받으시오.");

            
            int aa = int.Parse(Console.ReadLine());
            int a = aa / 60;
            int b = aa % 60;
            Console.WriteLine(a + "분" + b + "초");








        }
    }
}
