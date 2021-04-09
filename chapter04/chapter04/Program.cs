using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("안녕");
            Console.WriteLine("안녕");
            Console.WriteLine("안녕");
            Console.WriteLine("안녕");

            for (int i = 0; i < 4; i++)
                Console.WriteLine("안녕");

            Console.WriteLine("안녕" + 1);
            Console.WriteLine("안녕" + 2);
            Console.WriteLine("안녕" + 3);
            Console.WriteLine("안녕" + 4);


            for (int i = 0; i < 4; i++)
                Console.WriteLine("안녕" + (i + 1));
            Console.WriteLine("안녕하니"[0]);
            Console.WriteLine("안녕하니"[1]);
            Console.WriteLine("안녕하니"[2]);
            Console.WriteLine("안녕하니"[3]);

            for (int i = 0; i < 4; i++)
                Console.WriteLine("안녕하니"[i]);
            string name = "김동혁";
            string[] names = { "김동혁", "정연우", "임수환" };

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            string[] handsomeguy = new string[10];

            for (int i = (int)'A'; i < (int)'z'; i++)
                Console.Write((char)i);

            Console.WriteLine("..");


            for (int i = (int)'가'; i < (int)'힣'; i++)
            {

                break;
                Console.Write((char)i);
                //Thread.Sleep(5);
                Console.Write("..");
                if (i == (int)'힣')
                    i = (int)'가';
            }
            //무한대로 도는 반복문을 쓰기에 적합한 while
            while (false)
            {
                Console.WriteLine(new Random().Next(int.MaxValue));
            }
            //for
            //do while
            //while
            //cm에서는 foreach

            while (false)
            {
                Console.WriteLine("이동준 천재");
            }
            do
            {
                Console.WriteLine("이동준 천재");

            } while (false);

            int count = 100;
            while (count<100)
            {
                Console.WriteLine("카운트 값은"+ count+"입니다");
            }
            do
            {
                Console.WriteLine("do while count" + count );
            } while (count<100);

            int sum = 0;
            for (int i = 1; i <=100 ; i++)
            {
                /* if(i%2 == 0)
                 sum += i;*/
                if (i % 2 != 0)
                    continue;
                sum += i;

            }
            Console.WriteLine(sum);
/*
            foreach (var abcd in names)
            {
                Console.WriteLine(abcd+"is Good man");
            }*/

            int countIndex = 0;
            foreach (var abcd in names)
            {
                if (countIndex == 0)
                {
                    countIndex++;
                    continue;
                }
            }
            for (int i = 0; i < names.Length; i++)
            {
                if (i == 0)
                {

                    continue;
                }
                Console.WriteLine(names[i] + " !!is good man");
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
             for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                    Console.WriteLine();
          }
       
            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k<(2 * i) + 1;   k++)
                {
                    Console.Write("*"); 
                }
                Console.WriteLine();
            }
         
            Console.WriteLine("다이아 몬드 모양 별찍기");
            //피라미드 코드 삽입
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (2 * i) - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 4; i > 0; i--)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (2 * i) - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //goto문
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("외부 반복문");
                    for (int j = 0; j < 10; j++)
                    {
                        Console.WriteLine("내부 반복문");
                        goto Example;

                    }
                }
            Example:Console.WriteLine("goto");


                string teacher = Console.ReadLine();

                if (teacher == "이동준") ;
                goto Example;

                //toupq,tolowerer
                string example ="exAmple";
                Console.WriteLine(example.ToUpper());
                Console.WriteLine(example.ToLower());
                Console.WriteLine(example);
                example = example.ToUpper();
                string guys = "김동혁,장승민,정연우,임수환";
                string[] guys_array = guys.Split(',');
                foreach (var item in guys_array)
                {
                    Console.WriteLine(item + "님 하이");
                }
                String guys2 = String.Join(",", guys_array);
                Console.WriteLine(guys2);

                string trim = " 안녕 하니 워우";
                Console.WriteLine("!" + trim + "!");
                Console.WriteLine("!" + trim.Trim() + "!");


            }
        }
        }
     }
    

