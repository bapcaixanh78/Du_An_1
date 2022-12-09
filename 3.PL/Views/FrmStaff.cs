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
        IPositionService _ipositionService;
        IWareHouseService _iwareHouseService;
        public FrmStaff()
        {
            InitializeComponent();
            _istaffService = new StaffService();
            _ipositionService = new PositionService();
            _iwareHouseService = new WareHouseService();
            LoadData();
            LoadPosition();
            LoadWareHouse();
            rbtn_active.Checked = true;
        }
        private void LoadWareHouse()
        {
            cmb_warehouse.Items.Clear();
            foreach (var x in _iwareHouseService.GetAll())
            {
                cmb_warehouse.Items.Add(x.Name);
            }
            cmb_warehouse.SelectedIndex = 0;
        }
        private void LoadPosition()
        {
            cmb_position.Items.Clear();
            foreach (var x in _ipositionService.GetAll())
            {
                cmb_position.Items.Add(x.Name);
            }
            cmb_position.SelectedIndex = 0;
        }
        private void LoadData()
        {
            int stt = 1;
            dgrid_staff.ColumnCount = 12;
            dgrid_staff.Columns[0].Name = "STT";
            dgrid_staff.Columns[1].Name = "ID";
            dgrid_staff.Columns[1].Visible = false;
            dgrid_staff.Columns[2].Name = "Code";
            dgrid_staff.Columns[3].Name = "Name";
            dgrid_staff.Columns[4].Name = "Phone Number";
            dgrid_staff.Columns[5].Name = "Address";
            dgrid_staff.Columns[6].Name = "Birth of Date";
            dgrid_staff.Columns[7].Name = "Wage";
            dgrid_staff.Columns[8].Name = "Status";
            dgrid_staff.Columns[9].Name = "Name Position";
            dgrid_staff.Columns[10].Name = "Name Ware House";
            dgrid_staff.Columns[11].Name = "Gender";
            dgrid_staff.Rows.Clear();
            foreach (var x in _istaffService.GetAll())
            {
                dgrid_staff.Rows.Add(stt++, x.IdStaff, x.Code, x.Name, x.PhoneNumber, x.Address, x.BirthOfDate, x.Wage, x.Status, x.NamePosition, x.NameWareHouse, x.Gender);
            }
        }
        private void LoadSearch(List<StaffView> lst)
        {
            int stt = 1;
            dgrid_staff.ColumnCount = 12;
            dgrid_staff.Columns[0].Name = "STT";
            dgrid_staff.Columns[1].Name = "ID";
            dgrid_staff.Columns[1].Visible = false;
            dgrid_staff.Columns[2].Name = "Code";
            dgrid_staff.Columns[3].Name = "Name";
            dgrid_staff.Columns[4].Name = "Phone Number";
            dgrid_staff.Columns[5].Name = "Address";
            dgrid_staff.Columns[6].Name = "Birth of Date";
            dgrid_staff.Columns[7].Name = "Wage";
            dgrid_staff.Columns[8].Name = "Status";
            dgrid_staff.Columns[9].Name = "Name Position";
            dgrid_staff.Columns[10].Name = "Name Ware House";
            dgrid_staff.Columns[11].Name = "Gender";
            dgrid_staff.Rows.Clear();
            foreach (var x in lst)
            {
                dgrid_staff.Rows.Add(stt++, x.IdStaff, x.Code, x.Name, x.PhoneNumber, x.Address, x.BirthOfDate, x.Wage, x.Status, x.NamePosition, x.NameWareHouse,x.Gender);
            }
        }
        private StaffView GetDataFrom()
        {
            StaffView staffView = new StaffView();
            {
                staffView.IdStaff = _id;
                staffView.Code = txt_code.Text;
                staffView.Name = txt_name.Text;
                staffView.Gender = txt_gender.Text;
                staffView.PhoneNumber = txt_phone.Text;
                staffView.Address = txt_adress.Text;
                staffView.BirthOfDate = Convert.ToDateTime(dtpk_date.Text);
                staffView.Wage = Convert.ToDecimal(txt_wage.Text);
                staffView.Status = rbtn_active.Checked ? 1 : 0;
                staffView.IdPosition = _ipositionService.GetAll()[cmb_position.SelectedIndex].IdPosition;
                staffView.IdWareHouse = _iwareHouseService.GetAll()[cmb_warehouse.SelectedIndex].IdWarehouse;   
            };
            return staffView;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            var rerand = MessageBox.Show("Do you want more ?", "Notify !", MessageBoxButtons.YesNo);
            if (txt_code.Text == "")
            {
                MessageBox.Show("Please enter the code");
            }
            else if (_istaffService.GetAll().Any(x => x.Code == txt_code.Text))
            {
                MessageBox.Show("Code already exists");
            }
            else if (rerand == DialogResult.Yes)
            {
                MessageBox.Show(_istaffService.Add(GetDataFrom()));
                LoadData();
            }
            else
            {
                return;
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
            txt_gender.Text = obj.Gender;
            txt_phone.Text = obj.PhoneNumber;
            txt_adress.Text = obj.Address;
            dtpk_date.Text = Convert.ToString(obj.BirthOfDate);
            txt_wage.Text = Convert.ToString(obj.Wage);
            if(obj.Status == 1)
            {
                rbtn_active.Checked = true;
            }
            else
            {
                rbtn_inactive.Checked = true;
            }
            cmb_position.SelectedItem = obj.NamePosition;
            cmb_warehouse.SelectedItem = obj.NameWareHouse;
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
                MessageBox.Show(_istaffService.Status(GetDataFrom()));
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
            dtpk_date.Text = null;
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            LoadSearch(_istaffService.Search(txt_search.Text));
        }
    }
}
