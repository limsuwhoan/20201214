using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  String name = Console.ReadLine();
              if (false) (name == "손우혁")
             {

                      int a = 100;
                      Console.WriteLine("마마무짱");


              else

                      Console.WriteLine("9-1=0.지금은 소녀시대");

              }*/

            /*

                        int b = 100;
                        if (b < 50)
                        {

                            Console.WriteLine("b는 50.보다 작습니다.");
                        }
                        else if (b < 70)
                        {
                            Console.WriteLine("b는 70.보다 작습니다.");
                        }
                        else if (b < 90)
                        {
                            Console.WriteLine("b는 90.보다 작습니다.");
                        }
                        else
                        {
                            Console.WriteLine("b 값은 " + b + "입니다.");
                        }*/
            /*  int dice = 3;
              switch (dice)
              {
                  case 1:s
                      Console.WriteLine("주사위:1");
                      break;
                  case 2:
                      Console.WriteLine("주사위:2");
                      break;
                  case 3:

                  case 4:

                  case 5:

                  case 6:
                      Console.WriteLine("주사위:3,4,5,6");
                      break;

                  default:
                      Console.WriteLine("1.2.3.4.5.6 중 하나가 아닙니다");
                      break;
              }*/
            /* int dice = 3;
             if (dice == 1)
             {

                 Console.WriteLine("주사위:1"); 
             }

             else if (dice == 2)
             {
                 Console.WriteLine("주사위:2");
             }

             else if (dice == 3)
             {

             }


             else if  (dice == 4 ||dice == 5|| dice == 6)
             {
                 Console.WriteLine("주사위:4,5,6");
             }
            else
             {
                 Console.WriteLine("1.2.3.4.5.6 중 하나가 아닙니다");
             }

             int keyCm = 173;
             if (keyCm < 180)
             {
                 Console.WriteLine("루저인데 에매함");
             }
             if (keyCm >= 170 && keyCm<100)//논리곱.하나라도 false면 다 false
                 Console.WriteLine("루저인데 에매함");
             if (keyCm<100 || keyCm>200)//논리합.하나라도 true면 다 true
                 Console.WriteLine("너무 작거나 크다");
             if (keyCm >= 100 ^ keyCm >= 200)//형태만 봐두기!!
                 Console.WriteLine("");
 */
            int a;
            a = 2;
            int c = a % 2 == 0 ? -1 : 0;

            if (a % 2 == 0)
                c = -1;
            else
                c = 0;

            string dj = " 이동준";
            if (dj.Contains("동"))
                Console.WriteLine("동태"); 

            if (dj.Contains("이동"))
                Console.WriteLine("Move준");


            int aa = int.Parse(Console.ReadLine());
            if (aa%12==0)
            {
                Console.WriteLine("");
            }
            int year = int.Parse(Console.ReadLine());
            switch (year % 12)
            {
                case 0:
                    Console.WriteLine("원숭이띠");
                    break;
                case 1:
                    Console.WriteLine("닭띠");
                    break;
                case 2:
                    Console.WriteLine("개띠");
                    break;

                case 3:
                    Console.WriteLine("돼지띠");
                    break;

                case 4:
                    Console.WriteLine("쥐띠");
                    break;

                case 5:
                    Console.WriteLine("소띠");
                    break;

                case 6:
                    Console.WriteLine("호랑이띠");
                    break;

                case 7:
                    Console.WriteLine("토끼띠");
                    break;

                case 8:
                    Console.WriteLine("용띠");
                    break;
                case 9:
                    Console.WriteLine("뱀띠");
                    break;
                case 10:
                    Console.WriteLine("말띠");
                    break;
                case 11:
                    Console.WriteLine("양띠");
                    break;

                default:
                    break;
            }

            Console.WriteLine("달을 입력받아 계절을 출력하는 프로그램을 작성하시오");
            int fore = int.Parse(Console.ReadLine());

             
            switch (fore)
            {
                case 12:
                  
                case 1:
                  
                case 2:
                    Console.WriteLine("겨울입니다");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄 입니다");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름 입니다");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을 입니다");
                    break;
            }
        }
    }
}
