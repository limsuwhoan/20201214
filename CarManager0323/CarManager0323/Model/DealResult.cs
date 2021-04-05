using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.Model
{
    class DealResult
    {
        int count;
        string custName;
        string model;
        string price;
        string seller;
        string day;

        public DealResult(int count, string custName, string model, string price, string seller, string day)
        {
            this.count = count;
            this.custName = custName;
            this.model = model;
            this.price = price;
            this.seller = seller;
            this.day = day;
        }

        public int Count { get => count; set => count = value; }
        public string CustName { get => custName; set => custName = value; }
        public string Model { get => model; set => model = value; }
        public string Price { get => price; set => price = value; }
        public string Seller { get => seller; set => seller = value; }
        public string Day { get => day; set => day = value; }
    }
}
