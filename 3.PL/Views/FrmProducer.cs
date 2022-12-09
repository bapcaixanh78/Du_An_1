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
    public partial class FrmProducer : Form
    {
        Guid _id;
        IProducerService _iproducerService;
        public FrmProducer()
        {
            InitializeComponent();
            _iproducerService = new ProducerService();
            LoadData();
            rbtn_active.Checked = true;
        }
        private void LoadData()
        {
            int stt = 1;
            dgrid_producer.ColumnCount = 9;
            dgrid_producer.Columns[0].Name = "STT";
            dgrid_producer.Columns[1].Name = "ID";
            dgrid_producer.Columns[1].Visible = false;
            dgrid_producer.Columns[2].Name = "Code";
            dgrid_producer.Columns[3].Name = "Name";
            dgrid_producer.Columns[4].Name = "Phone Number";
            dgrid_producer.Columns[5].Name = "Adress";
            dgrid_producer.Columns[6].Name = "City";
            dgrid_producer.Columns[7].Name = "Nation";
            dgrid_producer.Columns[8].Name = "Status";
            dgrid_producer.Rows.Clear();
            foreach (var x in _iproducerService.GetAll())
            {
                dgrid_producer.Rows.Add(stt++, x.IdProducer, x.Code, x.Name,x.PhoneNumber,x.Address,x.City,x.Nation,x.Status == 1?"Active":"Inactive");
            }
        }
        private void LoadSearch(List<ProducerView> lst)
        {
            int stt = 1;
            dgrid_producer.ColumnCount = 9;
            dgrid_producer.Columns[0].Name = "STT";
            dgrid_producer.Columns[1].Name = "ID";
            dgrid_producer.Columns[1].Visible = false;
            dgrid_producer.Columns[2].Name = "Code";
            dgrid_producer.Columns[3].Name = "Name";
            dgrid_producer.Columns[4].Name = "Phone Number";
            dgrid_producer.Columns[5].Name = "Address";
            dgrid_producer.Columns[6].Name = "City";
            dgrid_producer.Columns[7].Name = "Nation";
            dgrid_producer.Columns[8].Name = "Status";
            dgrid_producer.Rows.Clear();
            foreach (var x in lst)
            {
                dgrid_producer.Rows.Add(stt++, x.IdProducer, x.Code, x.Name, x.PhoneNumber, x.Address, x.City, x.Nation, x.Status == 1 ? "Active" : "Inactive");
            }
        }
        private ProducerView GetDataFrom()
        {
            ProducerView prdview = new ProducerView();
            {
                prdview.IdProducer = _id;
                prdview.Code = txt_code.Text;
                prdview.Name = txt_name.Text;
                prdview.PhoneNumber = txt_phone.Text;
                prdview.Address = txt_adress.Text;
                prdview.City = txt_city.Text;
                prdview.Nation = txt_nation.Text;
                prdview.Status = rbtn_active.Checked ? 1 : 0;
            };
            return prdview;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var rerand = MessageBox.Show("Do you want more ?", "Notify !", MessageBoxButtons.YesNo);
            if (txt_code.Text == "")
            {
                MessageBox.Show("Please enter the code");
            }
            else if (_iproducerService.GetAll().Any(x => x.Code == txt_code.Text))
            {
                MessageBox.Show("Code already exists");
            }
            else if(rerand == DialogResult.Yes)
            {
                MessageBox.Show(_iproducerService.Add(GetDataFrom()));
                LoadData();
            }
            else
            {
                return;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var rerand = MessageBox.Show("Do you want to update it?", "Notify !", MessageBoxButtons.YesNo);
            if (rerand == DialogResult.Yes)
            {
                MessageBox.Show(_iproducerService.Update(GetDataFrom()));
                LoadData();
            }
            else
            {
                return;
            }
        }

        private void dgrid_producer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _iproducerService.GetAll().Count || rowIndex == -1) return;
            _id = Guid.Parse(dgrid_producer.Rows[rowIndex].Cells[1].Value.ToString());
            var obj = _iproducerService.GetAll().FirstOrDefault(c => c.IdProducer == _id);
            txt_code.Text = obj.Code;
            txt_name.Text = obj.Name;
            txt_phone.Text = obj.PhoneNumber;
            txt_adress.Text = obj.Address;
            txt_city.Text = obj.City;
            txt_nation.Text = obj.Nation;
            if(obj.Status == 1)
            {
                rbtn_active.Checked = true;
            }
            else
            {
                rbtn_inactive.Checked = true;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var rerand = MessageBox.Show("You may want to delete?", "Notify !", MessageBoxButtons.YesNo);
            if (rerand == DialogResult.Yes)
            {
                MessageBox.Show(_iproducerService.Delete(GetDataFrom()));
                LoadData(); 
            }
            else
            {
                return;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_code.Text = null;
            txt_adress.Text = null;
            txt_city.Text = null;
            txt_code.Text = null;
            txt_name.Text=null;
            txt_nation.Text = null;
            txt_phone.Text = null;    
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            LoadSearch(_iproducerService.Search(txt_search.Text));
        }
    }
}
