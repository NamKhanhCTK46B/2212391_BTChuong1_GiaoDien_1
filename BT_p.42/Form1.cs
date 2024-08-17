using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_p._42
{
    public partial class frmSubmit : Form
    {
        public frmSubmit()
        {
            InitializeComponent();
        }

        private void lblDecription_Click(object sender, EventArgs e)
        {

        }



        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text))
                MessageBox.Show("Vui long nhap ten nguoi dung.");
        }

        

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length < 8)
                MessageBox.Show("Mat khau phai co it nhat 8 ky tu");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chao mung ban");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUser.Text))
            {
                txtPassword.Focus();
                txtPassword.Select();
            }         
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_PasswordChars(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
