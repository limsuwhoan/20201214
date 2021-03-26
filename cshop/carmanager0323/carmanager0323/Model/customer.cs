using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carmanager0323
{
    class customer
    {

        string name;
        string tel;
        string addr;
        string email;

        public customer(string name, string tel, string addr, string email)
        {
            this.Name = name;
            this.Tel = tel;
            this.Addr = addr;
            this.Email = email;
        }

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Addr { get => addr; set => addr = value; }
        public string Email { get => email; set => email = value; }
    }
}
