using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace silp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1번 부터 100까지의 3의 배수의합을 구하시오.");
            int hap = 0;
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0)
              
                        {
                    hap =+hap +i;
                }
               
            }
            Console.WriteLine($"{hap}");
            
        }
         
    }

}




