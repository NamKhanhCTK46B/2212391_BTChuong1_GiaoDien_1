using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_p._52
{
    public partial class frmDemoListBox : Form
    {
        public frmDemoListBox()
        {
            InitializeComponent();
        }

        //private void frmDemoListBox_Load(object sender, EventArgs e)
        //{
        //    string[] datas = {"Pham Vu Ngoc Ha",
        //                      "Hoang Van Hung",
        //                      "Le Thi Van",
        //                      "Nguyen Thi Thu",
        //                      "Le Van Quoc",
        //                      "Le Van Phuoc",
        //                      "Truong Van Dung"
        //                      };
        //    this.lbClassList.DataSource = datas;
        //}

        private void btmAdd_Click(object sender, EventArgs e)
        {
            int itemselect = lbClassList.SelectedItems.Count - 1;
            for (int i = itemselect; i >= 0; i--)
            {
                lbJoinFootballList.Items.Add(lbClassList.SelectedItems[i]);
                lbClassList.Items.Remove(lbClassList.SelectedItems[i]);
                //lbClassList.Items.RemoveAt(lbClassList.SelectedIndices[i]);
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int i = lbJoinFootballList.SelectedItems.Count - 1;
            while (i >= 0)
            {
                lbJoinFootballList.Items.RemoveAt(lbJoinFootballList.SelectedIndices[i]);
                i--;
            }
        }
    }
}
