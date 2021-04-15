using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After2
{
    class Circle
    {
        private int r;
        public int R
        {
            get { return this.r; }
            set { this.r = value; }
        }
        public int radius { get; set; }
        //참고로 {get,set;} 없어도됨
        //그리드뷰 때는 필요
        //public 변수 만들땐 쓰기
        public int radi
        {
            get { return this.r; }
            set
            {
                if (value < 0)
                    this.r = 0;
                else
                {
                    this.r = value;
                }
            }
        }

    }
}
