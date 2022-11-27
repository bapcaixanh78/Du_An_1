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
    public partial class F_SignIn : MetroForm
    {
        public F_SignIn()
        {
            InitializeComponent();
        }

        private void btn_Signin_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else return;
        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {

        }

        private void btn_Signup_Click_1(object sender, EventArgs e)
        {
            F_SignUp fsup = new F_SignUp();
            this.Hide();
            fsup.Show();

        }

        private void cb_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showpass.Checked) txt_pass.UseSystemPasswordChar = false;
            else txt_pass.UseSystemPasswordChar = true;
        }

        private void btn_changepass_Click(object sender, EventArgs e)
        {
            F_ChangePassword fchange = new F_ChangePassword();
            this.Hide();
            fchange.ShowDialog();
        }
    }
}
