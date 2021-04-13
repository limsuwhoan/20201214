using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3test
{
    enum scissors_Rock_Paper
    {
        Gawi, Bawi, Bo
    }
    enum Fruit
    {
        Banana,Kiwi,Apple=3,ddalgi
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] product = {"바나나","키위","고구마","감자","사과","딸기" };
            MessageBox.Show(product[0]);
            MessageBox.Show(product[(int)Fruit.Banana]);
            MessageBox.Show(Fruit.Banana.ToString());
            if((Fruit)0==Fruit.Banana)
                    MessageBox.Show("숫자 0은banana,Banana는 0");
            button1.Text = "가위";
            button2.Text = "바위";
            button3.Text = "보";
        }

        private void label6_Click(object sender, EventArgs e)
        {
        
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            int myChoice = 0;//가위=0 바위=1 보=2 라고 약속
            int pcChoice = new Random().Next(3);
            myResult.Text = "가위";
            if (pcChoice == 0)
            {
                pcResult.Text = "가위";
                result.Text = "비김";
            }
            else if (pcChoice == 1)
            {
                pcResult.Text = "바위";
                result.Text = "짐";
            }
            else
            {
                pcResult.Text = "보";
                result.Text = "이김";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            scissors_Rock_Paper myChoice = scissors_Rock_Paper.Bawi;
            scissors_Rock_Paper pcChoice =
            (scissors_Rock_Paper)new Random().Next(3);

            myResult.Text = myChoice.ToString();
            pcResult.Text = pcChoice.ToString();

            if (myChoice==pcChoice)//바위
            {
                result.Text = "비김";
                }
            else if (pcChoice == scissors_Rock_Paper.Bo)
            {
                result.Text = "짐";
            }
            else
            {
                result.Text = "이김";
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] GBB = { "가위", "바위", "보" };
            scissors_Rock_Paper myChoice = scissors_Rock_Paper.Bo;
            scissors_Rock_Paper pcChoice = (scissors_Rock_Paper)new Random().Next(3);

            myResult.Text = GBB[(int)myChoice];
            pcResult.Text = GBB[(int)pcChoice];
            
            if(myChoice == pcChoice)
            
                {
                    result.Text = "비김";
                }
               else if (pcChoice == scissors_Rock_Paper.Gawi)//가위
                {
                    result.Text = "짐";
                }
               else
                {
                    result.Text = "이김";
                }
            }

            private void result_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
