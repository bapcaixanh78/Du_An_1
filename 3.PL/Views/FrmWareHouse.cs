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
    public partial class FrmWareHouse : Form
    {
        Guid _id;
        IWareHouseService _iwarehouseservice;
        public FrmWareHouse()
        {
            InitializeComponent();
            _iwarehouseservice = new WareHouseService();
            LoadData();
        }
        private void LoadData()
        {
            int stt = 1;
            dgrid_warehouse.ColumnCount = 9;
            dgrid_warehouse.Columns[0].Name = "STT";
            dgrid_warehouse.Columns[1].Name = "ID";
            dgrid_warehouse.Columns[1].Visible = false;
            dgrid_warehouse.Columns[2].Name = "Code";
            dgrid_warehouse.Columns[3].Name = "Name";
            dgrid_warehouse.Columns[4].Name = "Phone Number";
            dgrid_warehouse.Columns[5].Name = "Adress";
            dgrid_warehouse.Columns[6].Name = "City";
            dgrid_warehouse.Columns[7].Name = "Nation";
            dgrid_warehouse.Columns[8].Name = "Status";
            dgrid_warehouse.Rows.Clear();
            foreach (var x in _iwarehouseservice.GetAll())
            {
                dgrid_warehouse.Rows.Add(stt++, x.IdWarehouse, x.Code, x.Name, x.PhoneNumber, x.Adress, x.City, x.Nation, x.Status);
            }
        }
        private WareHouseView GetDataFrom()
        {
            WareHouseView wrhview = new WareHouseView();
            {
                wrhview.IdWarehouse = _id;
                wrhview.Code = txt_code.Text;
                wrhview.Name = txt_name.Text;
                wrhview.PhoneNumber = txt_phone.Text;
                wrhview.Adress = txt_adress.Text;
                wrhview.City = txt_city.Text;
                wrhview.Nation = txt_nation.Text;
                wrhview.Status = Convert.ToInt32(txt_status.Text);
            };
            return wrhview;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_code.Text == "")
            {
                MessageBox.Show("Please enter the code");
            }
            else if (_iwarehouseservice.GetAll().Any(x => x.Code == txt_code.Text))
            {
                MessageBox.Show("Code already exists");
            }
            else
            {
                MessageBox.Show(_iwarehouseservice.Add(GetDataFrom()));
                LoadData();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var rerand = MessageBox.Show("Do you want to update it?", "Notify !", MessageBoxButtons.YesNo);
            if (rerand == DialogResult.Yes)
            {
                MessageBox.Show(_iwarehouseservice.Update(GetDataFrom()));
                LoadData();
            }
            else
            {
                return;
            }
        }

        private void dgrid_warehouse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _iwarehouseservice.GetAll().Count || rowIndex == -1) return;
            _id = Guid.Parse(dgrid_warehouse.Rows[rowIndex].Cells[1].Value.ToString());
            var obj = _iwarehouseservice.GetAll().FirstOrDefault(c => c.IdWarehouse == _id);
            txt_code.Text = obj.Code;
            txt_name.Text = obj.Name;
            txt_phone.Text = obj.PhoneNumber;
            txt_adress.Text = obj.Adress;
            txt_city.Text = obj.City;
            txt_nation.Text = obj.Nation;
            txt_status.Text = Convert.ToString(obj.Status);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var rerand = MessageBox.Show("You may want to delete?", "Notify !", MessageBoxButtons.YesNo);
            if (rerand == DialogResult.Yes)
            {
                MessageBox.Show(_iwarehouseservice.Delete(GetDataFrom()));
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
            txt_city.Text = null;
            txt_code.Text =null;
            txt_name.Text = null;
            txt_nation.Text = null;
            txt_phone.Text = null;
            txt_status.Text = null;
        }
    }
}
