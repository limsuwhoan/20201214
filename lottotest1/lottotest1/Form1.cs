using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lottotest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int random_num = r.Next(1, 46);

            string lottoNum = random_num.ToString();
            if (random_num < 10)
            {
                lottoNum = "0" + random_num.ToString();
            }
            for (int i = 0; i < 6; i++)
            {


                random_num = r.Next(1, 46);
                string temp = random_num.ToString();
                if (random_num < 10)
                {
                    temp = "0" + temp;
                }

                if (lottoNum.Contains(temp))
                {
                    i--;
                    continue;
                }


                lottoNum += "_" + temp;
            }
            Console.WriteLine(lottoNum);



            string[] lotto = lottoNum.Split('_');
            Label[] lotto_display = { label_1, label_2, label_3, label_4, label_5, label_6, label7 };
            

            int[] lottonum2 = new int[lotto.Length];

            int temp2;
            for (int i = 0; i < lotto.Length; i++)
            {
                lottonum2[i] = int.Parse(lotto[i]);
            }
            for (int i = 0; i < lottonum2.Length; i++)
            {
                for (int j = 0; j < lottonum2.Length; j++)
                {
                    if (lottonum2[i] < lottonum2[j])
                    {
                        temp2 = lottonum2[i];
                        lottonum2[i] = lottonum2[j];
                        lottonum2[j] = temp2;
                        temp2 = 0;
                    }
                }
            }
            for (int i = 0; i < lottonum2.Length; i++)
            {
                Console.WriteLine(lottonum2[i]);
            }
            for (int i = 0; i < lotto.Length; i++)
            {
                lotto_display[i].Text = Convert.ToString(lottonum2[i]);
            }
        }

       
    }
}


