using CarManager0323.DB;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace CarManager0323.UI
{
    partial class CustInsForm : MaterialForm
    {
        private DaoOracle oracle;
        public CustInsForm()
        {
            InitializeComponent();
        }
        public CustInsForm(DaoOracle oracle)
        {
            InitializeComponent();
            this.oracle = oracle;
        }

        private void CustInsForm_Load(object sender, EventArgs e)
        {

        }

        private void custOK_Click(object sender, EventArgs e)
        {
            if (custName.Text == "" || custAddress.Text == "" ||
                 custTel.Text == "" || custEmail.Text == "")
            {
                MessageBox.Show("누락된 정보가 있습니다.\n" + "올바르게 입력하세요.");
                return;
            }
            try
            {
                Customer customer = new Customer(
                    custName.Text,
                    custTel.Text,
                    custAddress.Text,
                    custEmail.Text);
                oracle.insertCustomer(customer);
                Close();
            }
            catch(FormatException ex)
            {
                Console.WriteLine("똑바로 입력하세요");
            }
        }

        private void custCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
