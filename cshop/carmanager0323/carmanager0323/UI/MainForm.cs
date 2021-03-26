using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace carmanager0323
{
public partial class MainForm : MaterialForm
    {
        DaoOracle ora = new DaoOracle();
        public MainForm()
        {
            
            InitializeComponent();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {          
            //ora.dbConnect();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ora.dbClose();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            ora.createAllTB();
        }

        private void dropTB_Click(object sender, EventArgs e)
        {
            ora.dropAllTB();
        }
    }
}
