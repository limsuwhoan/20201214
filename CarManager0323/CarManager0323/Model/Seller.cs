using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.Model
{
    class Seller
    {
        string name;
        string tel;
        string email;
        string spot;
        string business;

        public Seller(string name, string tel, string email, string spot, string business)
        {
            this.Name = name;
            this.Tel = tel;
            this.Email = email;
            this.Spot = spot;
            this.Business = business;
        }

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Email { get => email; set => email = value; }
        public string Spot { get => spot; set => spot = value; }
        public string Business { get => business; set => business = value; }
    }
}
