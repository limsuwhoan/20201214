using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carApp0208
{
    class Car
    {
        // 클래스 상수 변수
        public const string DAERI = "동대구영업소";
        // 인스턴스 변수
        private string company;
        private string color;
        private string price;
        private string model;

        public Car()
        {
        }

        public Car(string company, string color, 
            string price, string model)
        {
            this.company = company;
            this.color = color;
            this.price = price;
            this.model = model;
        }

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public string Color { get => color; set => color = value; }
        public string Price { get => price; set => price = value; }
        public string Model { get => model; set => model = value; }

        public void showCarInfo()
        {
            Console.WriteLine("제조사: " + company);
            Console.WriteLine("색상: " + color);
            Console.WriteLine("모델: " + model);
            Console.WriteLine("가격: " + price);
            Console.WriteLine("영업소: " + DAERI);
            Console.WriteLine("-----------------");
        }
    }
}
