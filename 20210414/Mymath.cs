using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210414
{
    class Mymath
    {
        public int end;
        public int power(int input)
        {
            return input * input;
        }

        public static int power(int input,int count)
        {
            int result = input;
            for (int i = 0; i < count; i++)
            {
                result *= input;
            }
            return result;
        }
        public static int SumAll(int end)
        {
            int sum = 0;
            for (int i = 0; i < end; i++)
            {
                sum += i;
            }
            return sum;
        }
        public static int SumAll(int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i;
            }
            return sum;
        }
        public int sumAll()
        {
            int sum = 0;
            for (int i = 0; i <= this.end; i++)
            {
                sum += i;
            }
            return sum;
        }
        private int abc;
        public int getAbc()
        {
            return abc;
        }
        public void setAbc(int abc)
        {
            this.abc = abc;
        }

    }
}
