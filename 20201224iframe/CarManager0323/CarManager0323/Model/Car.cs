using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.Model
{
    class Car
    {
        string model;
        int price;
        string color;
        string year;
        string manufacturer;

        public Car(string model, int price, string color, string year, string manufacturer)
        {
            this.Model = model;
            this.Price = price;
            this.Color = color;
            this.Year = year;
            this.Manufacturer = manufacturer;
        }

        public string Model { get => model; set => model = value; }
        public int Price { get => price; set => price = value; }
        public string Color { get => color; set => color = value; }
        public string Year { get => year; set => year = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
    }

}
