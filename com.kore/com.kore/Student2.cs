using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.kore
{
    class Student2
    {
        private string name;
        private int age;
        private char gender;
        private string aderess;
        public Student2() {
            this.name = name;
            this.age =age;
            this.gender = gender;
            this.name = aderess;
        }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public char Gender { get => gender; set => gender = value; }
        public string Aderess { get => aderess; set => aderess = value; }
      public void showStudentinfo()
    {
            Console.WriteLine("이름:"+name);
            Console.WriteLine("나이:" +age);
            Console.WriteLine("성별:" +gender);
            Console.WriteLine("주소:" +aderess);

        }
    }
  
    
}
