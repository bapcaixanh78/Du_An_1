using _1.DAL.Models;
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
        private IMaterialService _material;
        private IMaterialDetailService _materialDetail;
        private Bill _hdCho;
        private Guid _id;
        public FrmBanHang()
        {
            InitializeComponent();
            _billDetail = new BillDetailService();
            _staff = new StaffService();
            _bill = new BillService();
            _material = new MaterialService();
            _materialDetail = new MaterialDetailService();
            _lstOrder = new List<OrderView>();
            _hdCho = new Bill();
            LoadGioHang();
            LoadSanPham();
            LoadHdCho();
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
        void LoadSanPham()
        {
            int stt = 1;
            dgrid_SP.ColumnCount = 6;
            dgrid_SP.Columns[0].Name = "STT";
            dgrid_SP.Columns[1].Name = "Code";
            dgrid_SP.Columns[2].Name = "Name";
            dgrid_SP.Columns[3].Name = "Producer";
            dgrid_SP.Columns[4].Name = "Quanlity";
            dgrid_SP.Columns[5].Name = "Price";
            dgrid_SP.Rows.Clear();
            var list = _materialDetail.GetAll();
            list = list.OrderBy(c => c.Code).ToList();
            foreach (var x in list)
            {
                dgrid_SP.Rows.Add(stt++,x.Code, x.Name, x.Producer, x.Quanlity, x.Price);
            }
        }
        void LoadHdCho()
        {
            int stt = 1;
            dgrid_BillWait.Rows.Clear();
            dgrid_BillWait.ColumnCount = 3;
            dgrid_BillWait.Columns[0].Name = "STT";
            dgrid_BillWait.Columns[1].Name = "Mã";
            dgrid_BillWait.Columns[2].Name = "Tình trạng";
            var lsthdc = _bill.GetAll().Where(c => c.Status == 1);
            foreach (var x in lsthdc)
            {
                dgrid_BillWait.Rows.Add(stt++, x.Code, x.Status);
            }
        }
        public void AddCart(Guid id)
        {
            var cart = _materialDetail.GetAll().FirstOrDefault(c => c.IdMaterial == _id);
            var data = _lstOrder.FirstOrDefault(c => c.IdSP == cart.IdMaterial);
            if (data == null)
            {
                OrderView order = new OrderView()
                {
                    IdSP = cart.IdMaterial,
                    ProductName = cart.Name,
                    MaSp = cart.Code,
                    Quanlity = cart.Quanlity,
                    Price = cart.Price
                };
                _lstOrder.Add(order);
            }
            else
            {
                if(data.Quanlity == cart.Quanlity)
                {
                    MessageBox.Show("Sản phẩm vượt quá số lượng tồn");
                }
                else
                {
                    data.Quanlity++;
                }
            }
            LoadGioHang();
        }


        private void dgrid_Order_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgrid_SP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow dg = dgrid_SP.Rows[e.RowIndex];
                _id = _materialDetail.GetAll().FirstOrDefault(c => c.IdMaterial == Guid.Parse(dg.Cells[0].Value.ToString())).IdMaterial;
                AddCart(_id);
            }
        }

        private void btn_NewBill_Click(object sender, EventArgs e)
        {
            if (_lstOrder.Any())
            {
                var hoadon = new Bill()
                {
                    IdBill = Guid.NewGuid(),
                    Code = (_billDetail.GetAll().Count + 1).ToString(),
                    Status = 1
                };
                _bill.Add(hoadon);
                foreach (var x in _lstOrder)
                {
                    var hdct = new BillDetail() 
                    { 
                        IdBill = hoadon.IdBill,
                        IdMaterial = x.IdMDetail,
                        Amount = x.Quanlity,
                        Price = x.Price,
                        
                    };
                    _billDetail.Add(hdct);
                }
                MessageBox.Show("Succesfully");
                _lstOrder = new List<OrderView>();
                LoadGioHang();
                LoadHdCho();
                LoadSanPham();
            }
            else
            {
                MessageBox.Show("Unsuccessfully");
            }
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            _lstOrder = new List<OrderView>();
            LoadGioHang();
        }

        private void btn_XoaSP_Click(object sender, EventArgs e)
        {
            var sp = _lstOrder.FirstOrDefault(c => c.IdMDetail == _id);
            _lstOrder.Remove(sp);
            LoadGioHang();
        }

        private void dgrid_BillWait_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow dg = dgrid_BillWait.Rows[e.RowIndex];
                _hdCho = _bill.GetFromData().FirstOrDefault(c => c.IdBill == Guid.Parse(dg.Cells[0].Value.ToString()));
                lb_Mahd.Text = dg.Cells[1].Value.ToString();
                lb_TongTien.Text = _billDetail.GetAll().Where(c => c.IdBill == _hdCho.IdBill).Sum(x => x.Price * x.Amount).ToString();
            }
        }

        private void txt_Tienkhachdua_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txt_Tienkhachdua.Text, out int x))
            {
                lb_TienThua.Text = (decimal.Parse(txt_Tienkhachdua.Text) - decimal.Parse(lb_TongTien.Text)).ToString();
            }
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (int.Parse(lb_TienThua.Text) < 0)
            {
                MessageBox.Show("Thiếu tiền");
            }
            else if (!int.TryParse(txt_Tienkhachdua.Text, out int x))
            {
                MessageBox.Show("Không hợp lệ");
            }
            else
            {
                _hdCho.Status = 2;
                _bill.Update(_hdCho);
                LoadHdCho();
                MessageBox.Show("Thành công");
            }
        }
    }
}
