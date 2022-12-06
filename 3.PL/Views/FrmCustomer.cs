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
    public partial class FrmCustomer : Form
    {
        private ICustomerService _iCustomerService;
        Guid _id;
        
        public FrmCustomer()
        {
            InitializeComponent();
            _iCustomerService = new CustomerService();
            LoadData();
            LoadGender();
        }

        private void LoadData()
        {
            int stt = 1;
            dgrid_customer.ColumnCount = 9;
            dgrid_customer.Columns[0].Name = "STT";
            dgrid_customer.Columns[1].Name = "ID";
            dgrid_customer.Columns[1].Visible = false;
            dgrid_customer.Columns[2].Name = "Code";
            dgrid_customer.Columns[3].Name = "Name";
            dgrid_customer.Columns[4].Name = "PhoneNumber";
            dgrid_customer.Columns[5].Name = "Adress";
            dgrid_customer.Columns[6].Name = "Gender";
            dgrid_customer.Columns[7].Name = "BirthOfDate";
            dgrid_customer.Columns[8].Name = "Status";
            dgrid_customer.Rows.Clear();
            var lstcustomer = _iCustomerService.GetAll();
            lstcustomer = lstcustomer.Where(x => x.Code.ToLower().Contains(txt_sreach.Text.ToLower()) || x.Name.ToLower().Contains(txt_sreach.Text.ToLower())).ToList();
            foreach (var x in lstcustomer)
            {
                dgrid_customer.Rows.Add(stt++,x.IdCustomer, x.Code, x.Name, x.PhoneNumber, x.Address,x.Gender, x.BirthOfDate, x.Status == 1 ? "Activate" : "Inactive");
            }
        }

        private void LoadGender()
        {
            foreach (var x in _iCustomerService.GetGender())
            {
                cmb_gender.Items.Add(x);
            }
            cmb_gender.SelectedIndex = 0;
        }
        public CustomerView GetDataFromGui()
        {
            CustomerView vctm = new CustomerView()
            {
                IdCustomer = _id,
                Code = txt_code.Text,
                Name = txt_name.Text,
                PhoneNumber = txt_sdt.Text,
                Address = txt_adress.Text,
                Gender = cmb_gender.Text,
                BirthOfDate = dateTimePicker1.Value,
                Status = rbtn_activate.Checked ? 1 : 0,
            };
            return vctm;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Do you want to add to this board?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (txt_code.Text == "")
            {
                MessageBox.Show("Please enter the code ");
            }
            else if (_iCustomerService.GetAll().Any(x => x.Code == txt_code.Text))
            {
                MessageBox.Show("Code already exists");
            }
            else if (hoi == DialogResult.Yes)
            {
                MessageBox.Show(_iCustomerService.Add(GetDataFromGui()));
            }
            else return;
            LoadData();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Do you want to edit this table?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                MessageBox.Show(_iCustomerService.Update(GetDataFromGui()));
                LoadData();
            }
            else return;
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Do you want to delete this table?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                MessageBox.Show(_iCustomerService.Delete(GetDataFromGui()));
                LoadData();
            }
            else return;
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_code.Text = null;
            txt_name.Text = null;
            txt_sdt.Text = null;
            dateTimePicker1.Value = new DateTime(1990, 01, 01);
            txt_adress.Text = null;
            cmb_gender.SelectedIndex = 0;
            rbtn_activate.Checked = true;
        }

        private void dgrid_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == -1 || _iCustomerService.GetAll().Count == 0) return;
            if (rowIndex == _iCustomerService.GetAll().Count || rowIndex == -1) return;
            _id = Guid.Parse(dgrid_customer.Rows[rowIndex].Cells[1].Value.ToString());
            var temp = _iCustomerService.GetAll().FirstOrDefault(c => c.IdCustomer == _id);
            txt_code.Text = temp.Code;
            txt_name.Text = temp.Name;
            txt_sdt.Text = temp.PhoneNumber;
            txt_adress.Text = temp.Address;
            cmb_gender.Text = temp.Gender;
            dateTimePicker1.Value = (DateTime)temp.BirthOfDate;
            if (Convert.ToString(dgrid_customer.Rows[rowIndex].Cells[8].Value) == "Inactive")
            {
                rbtn_activate.Checked = false;
                rbtn_inactive.Checked = true;
            }
            if (Convert.ToString(dgrid_customer.Rows[rowIndex].Cells[8].Value) == "Activate")
            {
                rbtn_activate.Checked = true;
                rbtn_inactive.Checked = false;
            }
         }

        private void txt_sreach_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
