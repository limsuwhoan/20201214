using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carmanager0323.model
{
    class car
    {
        string model;
        int price;
        string color;
        string year;

        public car(string model, int price, string color, string year)
        {
            this.model = model;
            this.price = price;
            this.color = color;
            this.year = year;
        }

        public string Model { get => model; set => model = value; }
        public int Price { get => price; set => price = value; }
        public string Color { get => color; set => color = value; }
        public string Year { get => year; set => year = value; }
    }
}
