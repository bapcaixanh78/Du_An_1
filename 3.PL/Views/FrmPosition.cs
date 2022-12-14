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
    public partial class FrmPosition : Form
    {
        Guid _id;
        IPositionService _ipositionService;
        public FrmPosition()
        {
            InitializeComponent();
            _ipositionService = new PositionService();
            LoadData();
            rbtn_active.Checked = true;
        }
        private void LoadData()
        {
            int stt = 1;
            dgrid_position.ColumnCount = 5;
            dgrid_position.Columns[0].Name = "STT";
            dgrid_position.Columns[1].Name = "ID";
            dgrid_position.Columns[1].Visible = false;
            dgrid_position.Columns[2].Name = "Code";
            dgrid_position.Columns[3].Name = "Name";
            dgrid_position.Columns[4].Name = "Status";
            dgrid_position.Rows.Clear();
            foreach(var x in _ipositionService.GetAll())
            {
                dgrid_position.Rows.Add(stt++, x.IdPosition, x.Code, x.Name, x.Status == 1 ? "Active":"Inactive");
            }
        }
        private void LoadSearch(List<PositionView> lst)
        {
            int stt = 1;
            dgrid_position.ColumnCount = 5;
            dgrid_position.Columns[0].Name = "STT";
            dgrid_position.Columns[1].Name = "ID";
            dgrid_position.Columns[1].Visible = false;
            dgrid_position.Columns[2].Name = "Code";
            dgrid_position.Columns[3].Name = "Name";
            dgrid_position.Columns[4].Name = "Status";
            dgrid_position.Rows.Clear();
            foreach (var x in lst)
            {
                dgrid_position.Rows.Add(stt++, x.IdPosition, x.Code, x.Name, x.Status == 1 ? "Active" : "Inactive");
            }
        }
        private PositionView GetDataFrom()
        {
            PositionView pstview = new PositionView();
            {
                pstview.IdPosition = _id;
                pstview.Code = txt_code.Text;
                pstview.Name = txt_name.Text;
                pstview.Status = rbtn_active.Checked ? 1:0;
            };
            return pstview;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var rerand = MessageBox.Show("Do you want more?", "Notify !", MessageBoxButtons.YesNo);
            if (txt_code.Text == "")
            {
                MessageBox.Show("Please enter the code");
            }else if(_ipositionService.GetAll().Any(x => x.Code == txt_code.Text))
            {
                MessageBox.Show("Code already exists");
            }
            else if(rerand == DialogResult.Yes)
            {
                MessageBox.Show(_ipositionService.Add(GetDataFrom()));
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
                MessageBox.Show(_ipositionService.Update(GetDataFrom()));
                LoadData();
            }
            else
            {
                return;
            }
        }

        private void dgrid_position_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _ipositionService.GetAll().Count || rowIndex == -1) return;
            _id = Guid.Parse(dgrid_position.Rows[rowIndex].Cells[1].Value.ToString());
            var obj = _ipositionService.GetAll().FirstOrDefault(c => c.IdPosition == _id);
            txt_code.Text = obj.Code;
            txt_name.Text = obj.Name;
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
                MessageBox.Show(_ipositionService.Delete(GetDataFrom()));
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
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            LoadSearch(_ipositionService.Search(txt_search.Text));
        }
    }
}
