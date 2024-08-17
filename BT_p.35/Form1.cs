using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_p._35
{
    public partial class frmLinkLable : Form
    {
        public frmLinkLable()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strURL = "mailto:ctk46b@dlu.edu.vn ";
            this.lnkEmail.Links.Add(0, strURL.Length, strURL);
            strURL = "https://cntt.dlu.edu.vn/";
            this.lnkVisitWeb.Links.Add(0, strURL.Length, strURL);
        }

        private void lnkEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.LinkData);

            if (strURL.StartsWith ("mailto:"))
                Process.Start(strURL + "?subject=hello");
        }

        private void lnkVisitWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString (e.Link.LinkData);
            if (strURL.StartsWith("https://"))
                Process.Start(strURL);
        }
    }
}
