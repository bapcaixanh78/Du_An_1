using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    
    public partial class ViewBill : Form
    {
        List<BillView> view;
        IBillServieve _ibillserviece;
        ICustomerService _icustomerserviece;
        IStaffService _istaffserviece;
        Guid _id;
       

       
        public ViewBill()
        {

            InitializeComponent();
            _ibillserviece= new BillServiece();
            _istaffserviece= new StaffService();
            _icustomerserviece= new CustomerService();
            loaddata();
            rd_paid.Checked = true;
            GetDataFrom();
        }
        private  void loaddata()
        {
            int stt = 1;
            dtg_bill.ColumnCount = 10;
            dtg_bill.Columns[0].Name = "STT";
            dtg_bill.Columns[1].Name = "ID";
            dtg_bill.Columns[1].Visible = false;
            dtg_bill.Columns[2].Name = "Code";
            dtg_bill.Columns[3].Name = "CreatedDate";
            dtg_bill.Columns[4].Name = "PaymentedDate";
            dtg_bill.Columns[5].Name = "ShipDate";
            dtg_bill.Columns[6].Name = "ReceivedDate";
            dtg_bill.Columns[7].Name = "Status";
            dtg_bill.Columns[8].Name = "PointsUsed";
            dtg_bill.Columns[9].Name = "Note";
            dtg_bill.Rows.Clear();
            foreach (var x in _ibillserviece.GetAll())
            {
                dtg_bill.Rows.Add("FA2B0FFA-FCE5-4F73-9139-99760F4E3798", "B01", "2022/10/01", "2022/11/01", "2022/11/10", "2020/11/20", 0, 5, "1AFA5AA2-6F45-4D3F-A371-1694E4C90955", "3B4DBE81-596B-469B-9FA9-08388AF7F71E");
                dtg_bill.Rows.Add(stt++, x.IdBill, x.Code, x.CreatedDate, x.PaymentedDate, x.ShipDate, x.ReceivedDate, x.Status, x.PointsUsed,x.Note);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtg_bill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _ibillserviece.GetAll().Count || rowIndex == -1) return;
            _id = Guid.Parse(dtg_bill.Rows[rowIndex].Cells[1].Value.ToString());
            var obj = _ibillserviece.GetAll().FirstOrDefault(c => c.IdStaff == _id);
            if (obj.Status == 1)
            {
                rd_paid.Checked = true;
            }
            else
            {
                rd_unpaid.Checked = true;
            }
        }
        private BillView GetDataFrom()
        {
            BillView billView = new BillView();
            {
               
                billView.Status = rd_paid.Checked ? 1 : 0;
                
            };
            return billView;
        }

        private void bt_upđate_Click(object sender, EventArgs e)
        {
            var rerand = MessageBox.Show("Do you want to update it?", "Notify !", MessageBoxButtons.YesNo);
            if (rerand == DialogResult.Yes)
            {
                MessageBox.Show(_ibillserviece.Update(GetDataFrom()));
                loaddata();
            }
            else
            {
                return;
            }
        }
        private void LoadSearch(List<BillView> lst)
        {
            int stt = 1;
            dtg_bill.ColumnCount = 10;
            dtg_bill.Columns[0].Name = "STT";
            dtg_bill.Columns[1].Name = "ID";
            dtg_bill.Columns[1].Visible = false;
            dtg_bill.Columns[2].Name = "Code";
            dtg_bill.Columns[3].Name = "CreatedDate";
            dtg_bill.Columns[4].Name = "PaymentedDate";
            dtg_bill.Columns[5].Name = "ShipDate";
            dtg_bill.Columns[6].Name = "ReceivedDate";
            dtg_bill.Columns[7].Name = "Status";
            dtg_bill.Columns[8].Name = "PointsUsed";
            dtg_bill.Columns[9].Name = "Note";
                dtg_bill.Rows.Clear();
            foreach (var x in lst)
            {
                dtg_bill.Rows.Add(stt++, x.IdBill, x.Code, x.CreatedDate, x.PaymentedDate, x.ShipDate, x.ReceivedDate, x.Status, x.PointsUsed, x.Note);
            }
        }

        private void dtp_seach_ValueChanged(object sender, EventArgs e)
        {
            //LoadSearch(_ibillserviece.Search(dtp_seach.Value));
        }
    }
}
