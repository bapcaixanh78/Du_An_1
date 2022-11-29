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
        }

        private void LoadData()
        {
            dgrid_customer.ColumnCount = 7;
            dgrid_customer.Columns[0].Name = "ID";
            dgrid_customer.Columns[0].Visible = false;
            dgrid_customer.Columns[1].Name = "Code";
            dgrid_customer.Columns[2].Name = "Name";
            dgrid_customer.Columns[3].Name = "PhoneNumber";
            dgrid_customer.Columns[4].Name = "Adress";
            dgrid_customer.Columns[5].Name = "BirthOfDate";
            dgrid_customer.Columns[6].Name = "Status";
            dgrid_customer.Rows.Clear();
            foreach (var x in _iCustomerService.GetAll())
            {
                dgrid_customer.Rows.Add(x.IdCustomer, x.Code, x.Name, x.PhoneNumber, x.Adress, x.BirthOfDate, x.Status == 1 ? "Activate" : "Inactive");
            }
        }
        public CustomerView GetDataFromGui()
        {
            CustomerView vctm = new CustomerView()
            {
                IdCustomer = Guid.Empty,
                Code = txt_code.Text,
                Name = txt_name.Text,
                PhoneNumber = txt_sdt.Text,
                Adress = txt_adress.Text,
                BirthOfDate = dateTimePicker1.Value,
                Status = rbtn_activate.Checked ? 1 : 0,
            };
            return vctm;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thêm khách hàng này không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                MessageBox.Show(_iCustomerService.Add(GetDataFromGui()));
            }
            else return;
            LoadData();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn sửa khách hàng này không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                var temp = GetDataFromGui();
                temp.IdCustomer = _id;
                MessageBox.Show(_iCustomerService.Update(temp));
            }
            else return;
            LoadData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn xóa khách hàng này không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                var temp = GetDataFromGui();
                temp.IdCustomer = _id;
                MessageBox.Show(_iCustomerService.Delete(temp));
            }
            else return;
            LoadData();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_code.Text = null;
            txt_name.Text = null;
            txt_sdt.Text = null;
            dateTimePicker1.Value = new DateTime(1990, 01, 01);
            txt_adress.Text = null;
            rbtn_activate.Checked = true;
        }

        private void dgrid_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == -1 || _iCustomerService.GetAll().Count == 0) return;
            _id = _iCustomerService.GetAll().FirstOrDefault(c => c.IdCustomer == Guid.Parse(dgrid_customer.Rows[rowIndex].Cells[0].Value.ToString())).IdCustomer;
            var temp = _iCustomerService.GetAll().FirstOrDefault(c => c.IdCustomer == _id);
            txt_code.Text = temp.Code;
            txt_name.Text = temp.Name;
            txt_sdt.Text = temp.PhoneNumber;
            txt_adress.Text = temp.Adress;
            dateTimePicker1.Value = (DateTime)temp.BirthOfDate;
            if (Convert.ToString(dgrid_customer.Rows[rowIndex].Cells[6].Value) == "Inactive")
            {
                rbtn_activate.Checked = false;
                rbtn_inactive.Checked = true;
            }
            if (Convert.ToString(dgrid_customer.Rows[rowIndex].Cells[6].Value) == "Activate")
            {
                rbtn_activate.Checked = true;
                rbtn_inactive.Checked = false;
            }
         }
    }
}
