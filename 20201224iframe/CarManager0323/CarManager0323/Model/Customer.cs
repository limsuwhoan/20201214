using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323
{
    class Customer
    {
        string name;
        string addr;
        string tel;
        string email;

        public Customer(string name, string addr, string tel, string email)
        {
            this.Name = name;
            this.Addr = addr;
            this.Tel = tel;
            this.Email = email;
        }

        public string Name { get => name; set => name = value; }
        public string Addr { get => addr; set => addr = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Email { get => email; set => email = value; }
    }
}
