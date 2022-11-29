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
            dgrid_material.ColumnCount = 4;
            dgrid_material.Columns[0].Name = "ID";
            dgrid_material.Columns[0].Visible = false;
            dgrid_material.Columns[1].Name = "Code";
            dgrid_material.Columns[2].Name = "Name";
            dgrid_material.Columns[3].Name = "Status";
            dgrid_material.Rows.Clear();
            foreach (var x in _IMaterialService.GetAll())
            {
                dgrid_material.Rows.Add(x.IdMaterial, x.Code, x.Name, x.Status == 1 ? "Còn hàng" : "Hết hàng");
            }
        }

        public MaterialView GetDataFromGui()
        {
            MaterialView vmtrl = new MaterialView()
            {
                IdMaterial = Guid.Empty,
                Code = txt_code.Text,
                Name = txt_name.Text,
                Status = rbtn_ch.Checked ? 1 : 0,
            };
            return vmtrl;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thêm vật liệu này không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                MessageBox.Show(_IMaterialService.Add(GetDataFromGui()));
            }
            else return;
            LoadData();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn sửa vật liệu này không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                var temp = GetDataFromGui();
                temp.IdMaterial = _id;
                MessageBox.Show(_IMaterialService.Update(temp));
            }
            else return;
            LoadData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn xóa vật liệu này không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                var temp = GetDataFromGui();
                temp.IdMaterial = _id;
                MessageBox.Show(_IMaterialService.Delete(temp));
            }
            else return;
            LoadData();
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
            _id = _IMaterialService.GetAll().FirstOrDefault(c => c.IdMaterial == Guid.Parse(dgrid_material.Rows[rowIndex].Cells[0].Value.ToString())).IdMaterial;
            var temp = _IMaterialService.GetAll().FirstOrDefault(c => c.IdMaterial == _id);
            txt_code.Text = temp.Code;
            txt_name.Text = temp.Name;
            if (Convert.ToString(dgrid_material.Rows[rowIndex].Cells[3].Value) == "Hết hàng")
            {
                rbtn_ch.Checked = false;
                rbtn_hh.Checked = true;
            }
            if (Convert.ToString(dgrid_material.Rows[rowIndex].Cells[3].Value) == "Còn hàng")
            {
                rbtn_ch.Checked = true;
                rbtn_hh.Checked = false;
            }
        }
    }
}
