using CarManager0323.DB;
using CarManager0323.Model;
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

namespace CarManager0323.UI
{
    partial class CarInsForm : MaterialForm
    {
        private DaoOracle oracle;
        public CarInsForm()
        {
            InitializeComponent();
        }
        public CarInsForm(DaoOracle oracle)
        {
            InitializeComponent();
            this.oracle = oracle;
        }

        private void CarInsForm_Load(object sender, EventArgs e)
        {

        }

        private void uiSymbolLabel5_Click(object sender, EventArgs e)
        {

        }

        private void carOK_Click(object sender, EventArgs e)
        {
             if (carModel.Text == ""||carPrice.Text==""||
                 carColor.Text==""|| carCompany.Text==""||
                 carYear.Text == "")
             {
                 MessageBox.Show("누락된 정보가 있습니다.\n" + "올바르게 입력하세요.");
                 return;
             }
            try
            {
                Car car = new Car(
                  carModel.Text,
                  Int32.Parse(carPrice.Text),
                  carColor.Text,
                  carYear.Text,
                  carCompany.Text);
                oracle.insertCar(car);
                Close();
            }
            catch(FormatException ex)
            {
                Console.WriteLine("가격을 올바른 숫자로 입력하세요.");
            }
        }

        private void carCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
