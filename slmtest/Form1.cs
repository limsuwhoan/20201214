using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slmtest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Student> Students = new List<Student>();
            Students.Add(new Student()
            {
                name = " 이동준",
                grade = 1
            });
            Students.Add(new Student()
            {
                name = " 준동이",
                grade = 2
            });
            Students.Add(new Student()
            {
                name = " 동준이",
                grade = 3
            });


            Students.Add(new Student()
            {
                name = " 김동준",
                grade = 4
            });

            Students.Add(new Student()
            {
                name = " 최동준",
                grade = 1
            });

            Students.Add(new Student()
            {
                name = " 박동준",
                grade = 2
            });

            string names = "";
            for (int i = 0;  i<Students.Count; i++)
            {
                /*                names += Students[i].name + " " + Students[i].grade + "\n";*/
                Label label = new Label();
                label.Text = $"{Students[i].grade}학년{Students[i].name}학생"; 
                    label.AutoSize = true;
                    label.Location = new Point(33, 13 + (26 * i));
                Controls.Add(label);
            }
            /*    MessageBox.show(names)*/
            //for (int i = 0; i <student .Count; i++)//일반적 for문
            for (int i = Students.Count-1 ; i >=0; i--)//역 for 문
            {
                if (Students[i].grade > 1)
                    Students.RemoveAt(i);
            }
            for (int i = 0; i < Students.Count; i++)
            {
                /*                names += Students[i].name + " " + Students[i].grade + "\n";*/
                Label label = new Label();
                label.Text = $"{Students[i].grade}학년{Students[i].name}학생";
                label.AutoSize = true;
                label.Location = new Point(130, 13 + (26 * i));
                Controls.Add(label);
            }

        }
    }
}
