using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class F_ChangePassword : MetroForm
    {
        public F_ChangePassword()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            F_SignIn f_SignIn = new F_SignIn();
            f_SignIn.Show();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_cr_pass.Text = null;
            txt_enter_newpass.Text = null;
            txt_newpass.Text = null;
            txt_username.Text = null;
        }

        private void cb_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Showpass.Checked)
            {
                txt_cr_pass.UseSystemPasswordChar = false;
                txt_enter_newpass.UseSystemPasswordChar = false;
                txt_newpass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_cr_pass.UseSystemPasswordChar = true;
                txt_enter_newpass.UseSystemPasswordChar = true;
                txt_newpass.UseSystemPasswordChar = true;
            }
        }
    }
}
