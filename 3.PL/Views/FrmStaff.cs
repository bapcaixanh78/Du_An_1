using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
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
    public partial class FrmStaff : Form
    {
        Guid _id;
        IStaffService _istaffService;
        public FrmStaff()
        {
            InitializeComponent();
            _istaffService = new StaffService();
            LoadData();
        }
        private void LoadData()
        {
            int stt = 1;
            dgrid_staff.ColumnCount = 9;
            dgrid_staff.Columns[0].Name = "STT";
            dgrid_staff.Columns[1].Name = "ID";
            dgrid_staff.Columns[1].Visible = false;
            dgrid_staff.Columns[2].Name = "Code";
            dgrid_staff.Columns[3].Name = "Name";
            dgrid_staff.Columns[4].Name = "Phone Number";
            dgrid_staff.Columns[5].Name = "Adress";
            dgrid_staff.Columns[6].Name = "Date Of Birth";
            dgrid_staff.Columns[7].Name = "Ware";
            dgrid_staff.Columns[8].Name = "Status";
            dgrid_staff.Rows.Clear();
            foreach (var x in _istaffService.GetAll())
            {
                dgrid_staff.Rows.Add(stt++, x.IdStaff, x.Code, x.Name, x.PhoneNumber, x.Adress, x.DateOfBirth, x.Wage, x.Status);
            }
        }
        private StaffView GetDataFrom()
        {
            StaffView staffView = new StaffView();
            {
                staffView.IdStaff = _id;
                staffView.Code = txt_code.Text;
                staffView.Name = txt_name.Text;
                staffView.PhoneNumber = txt_phone.Text;
                staffView.Adress = txt_adress.Text;
                staffView.DateOfBirth = Convert.ToDateTime(dtpk_date.Text);
                staffView.Wage = Convert.ToDecimal(txt_wage.Text);
                staffView.Status = Convert.ToInt32(txt_status.Text);
            };
            return staffView;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_code.Text == "")
            {
                MessageBox.Show("Please enter the code");
            }
            else if (_istaffService.GetAll().Any(x => x.Code == txt_code.Text))
            {
                MessageBox.Show("Code already exists");
            }
            else
            {
                MessageBox.Show(_istaffService.Add(GetDataFrom()));
                LoadData();
            }
        }

        private void dgrid_staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _istaffService.GetAll().Count || rowIndex == -1) return;
            _id = Guid.Parse(dgrid_staff.Rows[rowIndex].Cells[1].Value.ToString());
            var obj = _istaffService.GetAll().FirstOrDefault(c => c.IdStaff == _id);
            txt_code.Text = obj.Code;
            txt_name.Text = obj.Name;
            txt_phone.Text = obj.PhoneNumber;
            txt_adress.Text = obj.Adress;
            dtpk_date.Text = Convert.ToString(obj.DateOfBirth);
            txt_wage.Text = Convert.ToString(obj.Wage);
            txt_status.Text = Convert.ToString(obj.Status);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var rerand = MessageBox.Show("Do you want to update it?", "Notify !", MessageBoxButtons.YesNo);
            if (rerand == DialogResult.Yes)
            {
                MessageBox.Show(_istaffService.Update(GetDataFrom()));
                LoadData();
            }
            else
            {
                return;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var rerand = MessageBox.Show("You may want to delete?", "Notify !", MessageBoxButtons.YesNo);
            if (rerand == DialogResult.Yes)
            {
                MessageBox.Show(_istaffService.Delete(GetDataFrom()));
                LoadData();
            }
            else
            {
                return;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_adress.Text = null;
            txt_code.Text = null;
            txt_name.Text = null;
            txt_phone.Text = null;
            txt_wage.Text = null;
            txt_status.Text = null;
            dtpk_date.Text = null;
        }
    }
}
