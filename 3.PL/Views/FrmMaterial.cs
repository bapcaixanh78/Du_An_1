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
    public partial class FrmMaterial : Form
    {
        private IMaterialService _IMaterialService;
        Guid _id;
        public FrmMaterial()
        {
            InitializeComponent();
            _IMaterialService = new MaterialService();
            LoadData();
        }
        private void LoadData()
        {
            int stt = 1;
            dgrid_material.ColumnCount = 5;
            dgrid_material.Columns[0].Name = "STT";
            dgrid_material.Columns[1].Name = "ID";
            dgrid_material.Columns[1].Visible = false;
            dgrid_material.Columns[2].Name = "Code";
            dgrid_material.Columns[3].Name = "Name";
            dgrid_material.Columns[4].Name = "Status";
            dgrid_material.Rows.Clear();
            var lstmaterial = _IMaterialService.GetAll();
            lstmaterial = lstmaterial.Where(x => x.Code.ToLower().Contains(txt_search.Text.ToLower()) || x.Name.ToLower().Contains(txt_search.Text.ToLower())).ToList();
            foreach (var x in lstmaterial)
            {
                dgrid_material.Rows.Add(stt++,x.IdMaterial, x.Code, x.Name, x.Status == 1 ? "Activate" : "Inactive");
            }
        }

        public MaterialView GetDataFromGui()
        {
            MaterialView vmtrl = new MaterialView()
            {
                IdMaterial = _id,
                Code = txt_code.Text,
                Name = txt_name.Text,
                Status = rbtn_ch.Checked ? 1 : 0,
            };
            return vmtrl;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Do you want to add to this board?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (txt_code.Text == "")
            {
                MessageBox.Show("Please enter the code");
            }
            else if (_IMaterialService.GetAll().Any(x => x.Code == txt_code.Text))
            {
                MessageBox.Show("Code already exists");
            }
            else if (hoi == DialogResult.Yes)
            {
                MessageBox.Show(_IMaterialService.Add(GetDataFromGui()));
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
                MessageBox.Show(_IMaterialService.Update(GetDataFromGui()));
                LoadData();
            }
            else 
            {
                return;
            }
            
          
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Do you want to delete this table?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
              
                MessageBox.Show(_IMaterialService.Delete(GetDataFromGui()));
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
            txt_name.Text = null;
            rbtn_ch.Checked = true;
        }

        private void dgrid_material_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == -1 || _IMaterialService.GetAll().Count == 0) return;
            if (rowIndex == _IMaterialService.GetAll().Count || rowIndex == -1) return;
            _id = Guid.Parse(dgrid_material.Rows[rowIndex].Cells[1].Value.ToString());
            var temp = _IMaterialService.GetAll().FirstOrDefault(c => c.IdMaterial == _id);
            txt_code.Text = temp.Code;
            txt_name.Text = temp.Name;
            if (Convert.ToString(dgrid_material.Rows[rowIndex].Cells[3].Value) == "Activate")
            {
                rbtn_ch.Checked = false;
                rbtn_hh.Checked = true;
            }
            if (Convert.ToString(dgrid_material.Rows[rowIndex].Cells[3].Value) == "Inactive")
            {
                rbtn_ch.Checked = true;
                rbtn_hh.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMaterialDetail frm = new FrmMaterialDetail();
            this.Hide();
            frm.Show();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
