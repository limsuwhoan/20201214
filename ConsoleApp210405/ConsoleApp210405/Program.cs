using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp210405
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1 / 2);
            Console.WriteLine(1 / 2.0);
            Console.WriteLine(1.0 / 2);

            //덧셈 뺄셈 곱셉 나눗셈 나머지
            Console.WriteLine(5 + 3);
            Console.WriteLine(5 - 3);
            Console.WriteLine(5 * 3);
            Console.WriteLine(5 / 3);
            Console.WriteLine(5 % 3);

            //연산의 우선순위를 신경쓰기싫으면 괄호를 넣어줄것
            Console.WriteLine((5 + 3) * (5 - 2));

            //문자 선택자
            Console.WriteLine("안녕하세요"[0]);//1번째문자
            Console.WriteLine("안녕하세요"[4]);//5번째문자
            //Console.WriteLine("안녕하세요"[5]);//에러

            Console.WriteLine((int)"안녕하세요"[0]);
            Console.WriteLine(Convert.ToString((int)"안녕하세요"[0], 16));


            Console.WriteLine(1 == 1);
            Console.WriteLine(1 != 1);
            bool result = true;
            bool result2 = false;

            Console.WriteLine(!result);//논리 부정 연산자
            Console.WriteLine(!result2);//논리 부정 연산자

            Console.WriteLine(long.MaxValue);
            Console.WriteLine(int.MaxValue);

            int a = int.MaxValue; // 2147483647
            int b = int.MaxValue; // 2147483647
            Console.WriteLine(a + b); //overflow
            Console.WriteLine((long)a + b); //정상값 출력

            uint c = uint.MaxValue;
            Console.WriteLine(c);

            int example = 100;

            Console.WriteLine(example++); //출력하고 난뒤에 더함
            Console.WriteLine(++example); //출력하기전에 더하고 출력

            int ex = 100;
            Console.WriteLine(ex);
            ex = ex + 1;

            ex = ex + 1;
            Console.WriteLine(ex);

            int coin = 100;
            //++을 무조건 뒤에 붙이고 그냥 두줄로 쓰기
            coin++;
            Console.WriteLine(coin);
            coin++;
            Console.WriteLine(coin);

            Console.WriteLine();

            string input = Console.ReadLine();

            Console.WriteLine("안녕 나는 " + input + "이야");

            // 숫자 입력 받기
            int number = int.Parse(Console.ReadLine()); //정수
            double num = double.Parse(Console.ReadLine());//실수
            Console.WriteLine(number / num);
        }
    }
}