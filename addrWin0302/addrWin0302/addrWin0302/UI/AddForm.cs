using adressTest0218.control;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addrWin0302.UI
{
    //public partial class AddForm : MaterialForm
        public  class AddForm : MaterialForm
    {
        StudentHandler sc;
        public AddForm(StudentHandler sc)
        {
            InitializeComponent();
            this.sc = sc;
        }

        public AddForm(StudentHandler sc)
        {
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void uiTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void addcansle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }






        private void addok_Click(object sender, EventArgs e)
        {
            if (addname.Text == "")
            {
                MessageBox.Show("이름을 입력하시요.");
            }
            if (addname.Text == "")
            {
                MessageBox.Show("전화번호를 입력하시요.");
            }
            if (addname.Text=="")
            {
                MessageBox.Show("이름을  력하시요.");
            }
            if (addname.Text == "")
            {
                MessageBox.Show("Email을 입력하시요.");
            }
            sc.getList.Add(
                new Student(sc.getId(),
               addName.Text, addtel.Text, addadress.Text, addemail.Text));
        }
    }
}
