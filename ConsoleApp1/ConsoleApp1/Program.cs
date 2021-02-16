using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carApp0208
{
    class Car
    {
        public const string DAERI = "동대구 영업소 ";

        private string company;
        private string color;
        private string price;
        private string model;

        public Car()
        {

        }
        public Car(string company, string color, string price, string model)
        {
            this.company = company;
            this.color = color;
            this.price = price;
            this.model = model;
        }

    }
}
