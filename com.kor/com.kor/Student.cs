using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.kor
{
    class Student
    {
        private string name;
        private int age;
        private char gender;
        private string adr;

        public Student(string name,int age, char gender , string adr) 
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.adr = adr;
        }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public char Gender { get => gender; set => gender = value; }
        public string Adr { get => adr; set => adr = value; }

        public void showStudentinfo()
        {
            Console.WriteLine("이름:" + name);
            Console.WriteLine("나이:" + age);
            Console.WriteLine("성별:" + gender);
            Console.WriteLine("주소:" + adr);

        }
    }
    

    
}
