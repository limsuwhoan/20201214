using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struck//스트럭스는 변수 값을 저장함 (클래스는 주소지 저장)
{
    class Account
    {
        public int myMoney;
        public string name;
        public Account(int money, string name)
        {
            myMoney = money;
            this.name = name;
        }
        public void doposit(int money)
        {
            myMoney += money;
        }

        public void withthraw(int money)
        {
            myMoney += money;
        }
    }
}
