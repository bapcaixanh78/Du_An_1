﻿using _2.BUS.IServices;
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
    public partial class FrmMaterialDetail : Form
    {
        IMaterialDetailService _iMTRLDetailService;
        IMaterialService _iMTRLService;
        IProducerService _iProducerService;
        Guid _id;
        public FrmMaterialDetail()
        {
            InitializeComponent();
            _iMTRLDetailService = new MaterialDetailService();
            _iMTRLService = new MaterialService();
            _iProducerService = new ProducerService();
            LoadData();
            LoadMaterial();
            LoadProducer();
        }
        private void LoadData()
        {
            int stt = 1;
            dgrid_materialdetail.ColumnCount = 8;
            dgrid_materialdetail.Columns[0].Name = "STT";
            dgrid_materialdetail.Columns[1].Name = "ID";
            dgrid_materialdetail.Columns[1].Visible = false;
            dgrid_materialdetail.Columns[2].Name = "NameMaterial";
            dgrid_materialdetail.Columns[3].Name = "NameProducer";
            dgrid_materialdetail.Columns[4].Name = "Price";
            dgrid_materialdetail.Columns[5].Name = "ImportPrice";
            dgrid_materialdetail.Columns[6].Name = "Amount";
            dgrid_materialdetail.Columns[7].Name = "Unit";
            dgrid_materialdetail.Rows.Clear();
            var lstmtrldetail = _iMTRLDetailService.GetAll();
            lstmtrldetail = lstmtrldetail.Where(x => x.NameMaterial.ToLower().Contains(txt_sreach.Text.ToLower()) || x.NameProducer.ToLower().Contains(txt_sreach.Text.ToLower())).ToList();
            foreach (var x in lstmtrldetail)
            {
                dgrid_materialdetail.Rows.Add(stt++, x.IdMDetail, x.NameMaterial, x.NameProducer, x.Price, x.ImportPrice, x.Amount, x.Unit);
            }
        }
        private void LoadMaterial()
        {
            foreach (var x in _iMTRLService.GetAll().Select(c => c.Name))
            {
                cmb_material.Items.Add(x);
            }
            cmb_material.SelectedIndex = 0;
        }
        private void LoadProducer()
        {
            foreach (var x in _iProducerService.GetAll().Select(c => c.Name))
            {
                cmb_producer.Items.Add(x);
            }
            cmb_producer.SelectedIndex = 0;
        }
        private MaterialDetailView GetDataFromGui()
        {
            MaterialDetailView view = new MaterialDetailView();
            {
                view.IdMDetail = _id;
                view.IdMaterial = _iMTRLService.GetAll()[cmb_material.SelectedIndex].IdMaterial;
                view.IdProducer = _iProducerService.GetAll()[cmb_producer.SelectedIndex].IdProducer;
                view.Price = Convert.ToDecimal(txt_price.Text);
                view.ImportPrice = Convert.ToDecimal(txt_importprice.Text);
                view.Amount = Convert.ToInt32(txt_amount.Text);
                view.Unit = txt_unit.Text;
            };
            return view;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Do you want to add to this board?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                MessageBox.Show(_iMTRLDetailService.Add(GetDataFromGui()));
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
                MessageBox.Show(_iMTRLDetailService.Update(GetDataFromGui()));
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
                MessageBox.Show(_iMTRLDetailService.Delete(GetDataFromGui()));
                LoadData();
            }
            else
            {
                return;
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_price.Text = null;
            txt_importprice.Text = null;
            txt_amount.Text = null;
            txt_unit.Text = null;
            cmb_material.SelectedIndex = 0;
            cmb_producer.SelectedIndex = 0;
        }

        private void dgrid_materialdetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            //if (rowIndex == -1 || _iMTRLDetailService.GetAll().Count == 0) return;
            //_id = _iMTRLDetailService.GetAll().FirstOrDefault(c => c.IdMDetail == Guid.Parse(dgrid_materialdetail.Rows[rowIndex].Cells[0].Value.ToString())).IdMDetail;
            if (rowIndex == _iMTRLDetailService.GetAll().Count || rowIndex == -1) return;
            _id = Guid.Parse(dgrid_materialdetail.Rows[rowIndex].Cells[1].Value.ToString());
            //if (rowIndex == _iMTRLDetailService.GetAll().Count) return;
            //_id = Guid.Parse(dgrid_materialdetail.Rows[rowIndex].Cells[1].Value.ToString());
            var temp = _iMTRLDetailService.GetAll().FirstOrDefault(c => c.IdMDetail == _id);
            cmb_material.SelectedItem = temp.NameMaterial;
            cmb_producer.SelectedItem = temp.NameProducer;
            txt_price.Text = Convert.ToString(temp.Price);
            txt_importprice.Text = Convert.ToString(temp.ImportPrice);
            txt_amount.Text = Convert.ToString(temp.Amount);
            txt_unit.Text = temp.Unit;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMaterial frm = new FrmMaterial();
            frm.ShowDialog();

        }
        private void txt_sreach_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}