using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace over
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //오버라이딩 ★
        }

        private void button1_Click(object sender, EventArgs e)
        {
            black_suhwan();
        }
        private void black_suhwan()
        {
            MessageBox.Show("임수환");
        }
        private void black_suhwan(string name)
        {
            MessageBox.Show(name);
        }
        private void black_suhwan(string name, string name2)
        {
            MessageBox.Show(name+name2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            black_suhwan(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            black_suhwan(button2.Text, button1.Text);
        }
    }
    }
