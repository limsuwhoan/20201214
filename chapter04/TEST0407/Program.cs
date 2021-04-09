using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST0407
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int min = 0;
            int[] num = new int[5];

            for (int i = 0; i < 5; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                if (num[i] > max)
                {
                    max = num[i];
                }
            }

            min = num[0];

            for (int i = 0; i < 5; i++)
            {
                if (num[i] < min)
                {
                    min = num[i];
                }
            }
            Console.WriteLine("최대값은 :" + max + "입니다");
            Console.WriteLine("최소값은 :" + min + "입니다");
        }
    }
}
