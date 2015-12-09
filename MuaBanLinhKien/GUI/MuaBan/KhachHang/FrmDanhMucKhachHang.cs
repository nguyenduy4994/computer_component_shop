using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DAL;

namespace GUI.MuaBan.KhachHang
{
    public partial class FrmDanhMucKhachHang : DevExpress.XtraEditors.XtraForm
    {
        BusKhachHang busKhachHang = BusKhachHang.GetInstance();
        string s;
        public FrmDanhMucKhachHang()
        {
            InitializeComponent();
        }
        public void Enable(bool pTinhTrang)
        {
            txtMaKhachHang.Enabled = txtTenKhachHang.Enabled = txtDiaChi.Enabled = txtSoDienThoai.Enabled = 
            btnLuu.Enabled = btnHuy.Enabled = pTinhTrang;
        }
        private void FrmDanhMucKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = busKhachHang.GetAll();
            Enable(false);

        }
        private void gvKhachHang_DoubleClick(object sender, EventArgs e)
        {
            btnDanhMucSua.PerformClick();
        }

        private void gvKhachHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvKhachHang.SelectedRowsCount != 1)
                return;
            customer Cus = (customer)gvKhachHang.GetFocusedRow();
            txtMaKhachHang.Text = Cus.id;
            txtTenKhachHang.Text = Cus.name;
            txtDiaChi.Text = Cus.address;
            txtSoDienThoai.Text = Cus.phone;
        }

        private void btnDanhMucThem_Click(object sender, EventArgs e)
        {
            Enable(true);
            txtMaKhachHang.Text = txtTenKhachHang.Text = txtSoDienThoai.Text = txtDiaChi.Text = null;
            txtTenKhachHang.Focus();
            s = "Them";
        }

        private void btnDanhMucLamMoi_Click(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = busKhachHang.GetAll();
        }
        public void CheckLoi(String pTen)
        {
            XtraMessageBox.Show("Thông tin " + pTen + " không được để trống", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            return;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtTenKhachHang.Text == string.Empty)
            {
                CheckLoi(lbTenKhachHang.Text);
                txtTenKhachHang.Focus();
            }
            if(txtSoDienThoai.Text == string.Empty)
            {
                CheckLoi(lbSoDienThoai.Text);
                    txtSoDienThoai.Focus();
            }
            if(txtDiaChi.Text == string.Empty)
            {
                CheckLoi(lbDiaChi.Text);
                    txtDiaChi.Focus();
            }

            if(s == "Them")
            {
                customer Cus = new customer();
                Cus.id = txtMaKhachHang.Text;
                Cus.name = txtTenKhachHang.Text;
                Cus.phone = txtSoDienThoai.Text;
                Cus.address = txtDiaChi.Text;
                Cus.created = DateTime.Now;
                if (busKhachHang.Insert(Cus))
                {
                    XtraMessageBox.Show("Thêm khách hàng thành công!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    XtraMessageBox.Show("Thêm khách hàng bị lỗi!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                customer Cus = (customer)gvKhachHang.GetFocusedRow();
                Cus.name = txtTenKhachHang.Text;
                Cus.phone = txtSoDienThoai.Text;
                Cus.address = txtDiaChi.Text;
                if (busKhachHang.Update(Cus))
                {
                    XtraMessageBox.Show("Sửa thông tin thành công!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    XtraMessageBox.Show("Sửa thông tin bị lỗi!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            
            btnDanhMucLamMoi.PerformClick();
            Enable(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Enable(false);
            txtMaKhachHang.Text = txtTenKhachHang.Text = txtSoDienThoai.Text = txtDiaChi.Text = null;
        }

        private void btnDanhMucSua_Click(object sender, EventArgs e)
        {
            if (gvKhachHang.SelectedRowsCount != 1) return;
            Enable(true);
            s = "Sua";
        }

        private void btnDanhMucXoa_Click(object sender, EventArgs e)
        {
            if (gvKhachHang.SelectedRowsCount != 1) return;
            customer Cus = (customer)gvKhachHang.GetFocusedRow();
            if (busKhachHang.Delete(Cus))
            {
                XtraMessageBox.Show("Xóa thông tin thành công!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                XtraMessageBox.Show("Xóa thông tin bị lỗi!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            btnDanhMucLamMoi.PerformClick();
        }
    }
}