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
    public partial class F_SignUp : MetroForm
    {
        public F_SignUp()
        {
            InitializeComponent();
            txt_newpass.UseSystemPasswordChar = true;
            txt_enternewpass.UseSystemPasswordChar = true;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            F_SignIn f_SignIn = new F_SignIn();
            f_SignIn.ShowDialog();
            return;

        }
    }
}
