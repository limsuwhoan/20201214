using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test3
{
   
    public partial class Form1 : Form
    { Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (true)
            {
               string str = textBox1;
            }
            String str = textBox1.Text;
            if (str.Trim().Length > 0)
            {
                MessageBox.Show(str + "정답입니다");
            }
        }
        
    }
}
