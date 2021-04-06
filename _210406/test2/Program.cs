using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("알람설정");
            Console.WriteLine("시간 을 설정하시오");
            int hour = int.Parse(Console.ReadLine());
            Console.WriteLine("분 을 설정하시오");
            int min = int.Parse(Console.ReadLine());

            if (min < 45)
            {


                if (hour < 1)
                {
                    hour += 24;
                    hour--;
                    min += 60;
                    min -= 45;
                }
                else
                {
                    hour--;
                    min += 60;
                    min -= 45;
                }
            }
            else
            {
                min -= 45;
            
            }
            if (hour > 12)
                Console.WriteLine("알람시간 오후:" + hour + "시" + min + "분");
            if (hour < 12)
                Console.WriteLine("알람시간 오전:" + hour + "시" + min + "분");
        }
    }
}
