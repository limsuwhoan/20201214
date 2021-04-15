using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210415chapter06
{
    class Account
    {
        public int myMoney;
        public string name;
            public Account(int money,string name)
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


