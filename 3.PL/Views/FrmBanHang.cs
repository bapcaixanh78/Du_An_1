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
    public partial class FrmBanHang : Form
    {
        private IBillService _bill;
        private IBillDetailService _billDetail;
        private IStaffService _staff;
        private List<OrderView> _lstOrder;
        private Guid _id;
        public FrmBanHang()
        {
            InitializeComponent();
            _billDetail = new BillDetailService();
            _staff = new StaffService();
            _bill = new BillService();
        }
        void LoadGioHang()
        {
            int stt = 1;
            dgrid_Order.ColumnCount = 5;
            dgrid_Order.Columns[0].Name = "STT";
            dgrid_Order.Columns[1].Name = "MCode";
            dgrid_Order.Columns[2].Name = "MName";
            dgrid_Order.Columns[3].Name = "Quanlity";
            dgrid_Order.Columns[4].Name = "Price";
            dgrid_Order.Columns.Clear();
            foreach (var x in _lstOrder)
            {
                dgrid_Order.Rows.Add(stt++, x.MaSp, x.ProductName, x.Quanlity, x.Price);
            }

        }
        public void AddCart()
        {
            //var cart = 
        }
    }
}
