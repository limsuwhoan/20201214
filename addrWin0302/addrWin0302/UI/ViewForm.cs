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
    public partial class ViewForm : MaterialForm
    {
        public ViewForm()
        {
            InitializeComponent();
        }

        private void initListView()
        {
            string[] data = {"1", "홍길동",
                "010-1234-1234", "조선 한양 홍대감댁",
                "hong@naver.com"};
            listView.Items.Add(new ListViewItem(data));

            for (int i=0; i<50; i++)
            {
                listView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (i+2).ToString(), "홍길동",
                        "010-1234-1234", "조선 한양 홍대감댁",
                        "hong@naver.com"
                    }
                ));
            }

            setRowColor(listView, Color.White, Color.LightGray);
            int index = listView.Items.Count - 1;
            //listView.Items[index].Selected = true;
            listView.Items[index].Focused = true;
            listView.EnsureVisible(index);
        }

        private void setRowColor(ListView list, 
            Color color1, Color color2)
        {
            foreach(ListViewItem item in list.Items)
            {
                if ((item.Index % 2)==0)
                {
                    item.BackColor = color1;
                }
                else
                {
                    item.BackColor = color2;
                }
            }
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            initListView();
            initGridView();
        }

        private void initGridView()
        {
            string[] data = {"1", "홍길동",
                "010-1234-1234", "조선 한양 홍대감댁",
                "hong@naver.com"};
            gridView.Rows.Add(data);
        }
    }
}
