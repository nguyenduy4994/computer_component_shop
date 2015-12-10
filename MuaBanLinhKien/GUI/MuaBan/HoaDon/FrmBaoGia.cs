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
using DAL;
using BUS;

namespace GUI.MuaBan.HoaDon
{
    public partial class FrmBaoGia : DevExpress.XtraEditors.XtraForm
    {
        BusDanhMuc busDanhMuc = BusDanhMuc.GetInstance();
        BusHangHoa busHangHoa = BusHangHoa.GetInstance();
        BusKhachHang busKhachHang = BusKhachHang.GetInstance();
        BusNhanVien busNhanVien = BusNhanVien.GetInstance();
        BusHoaDon busHoaDon = BusHoaDon.GetInstance();
        public FrmBaoGia()
        {
            InitializeComponent();
        }
        bill b = null;
        private void FrmBaoGia_Load(object sender, EventArgs e)
        {
            dgvPhieuBaoGia.DataSource = busHoaDon.GetAllPrice();
            lkDanhMucSP.Properties.DataSource = busDanhMuc.GetAll();
            dgvSanPham.DataSource = busHangHoa.GetAll();
            panelControl4.Enabled = false;
            lkKhachHang.Properties.DataSource = busKhachHang.GetAll();
            lkNhanVien.Properties.DataSource = busNhanVien.GetAll();
        }

        private void gvPhieuBaoGia_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvPhieuBaoGia.SelectedRowsCount != 1)
                return;
            b = (bill)gvPhieuBaoGia.GetFocusedRow();
            txtMaHoaDon.Text = b.id;
            dpNgayLap.EditValue = b.created;
            lkKhachHang.EditValue = b.customer_id;
            lkNhanVien.EditValue = b.staff_id;
            btnLuu.Enabled = btnHuy.Enabled = btnThemKhachHang.Enabled = false;
        }

        private void gvPhieuBaoGia_DoubleClick(object sender, EventArgs e)
        {
            btnDanhMucSua.PerformClick();
        }

        private void btnDanhMucLamMoi_Click(object sender, EventArgs e)
        {
            dgvPhieuBaoGia.DataSource = busHoaDon.GetAllPrice();
        }

        private void btnDanhMucThem_Click(object sender, EventArgs e)
        {
            panelControl4.Enabled = true;
            dpNgayLap.Focus();
            btnDanhMucThem.Enabled = false;
            txtMaHoaDon.Text = busHoaDon.getMaBG();
        }

        private void btnDanhMucSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = btnHuy.Enabled = btnThemKhachHang.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaHoaDon.Text = null;
            dpNgayLap.EditValue = null;
            lkKhachHang.EditValue = lkNhanVien.EditValue = null;
            panelControl4.Enabled = false;
            btnDanhMucThem.Enabled = true;
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            DialogResult r = (new MuaBan.KhachHang.FrmThemKhachHang()).ShowDialog();
            if (r == DialogResult.OK)
            {
                lkKhachHang.Properties.DataSource = busKhachHang.GetAll();
            }
        }

        private void lkDanhMucSP_EditValueChanged(object sender, EventArgs e)
        {
            if (lkDanhMucSP.EditValue == null) return;
            category cat = (category)lkDanhMucSP.GetSelectedDataRow();
            dgvSanPham.DataSource = busHangHoa.GetByCat(cat);
        }
        public void CheckLoi(String pTen)
        {
            XtraMessageBox.Show("Thông tin " + pTen + " không được để trống", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            return;
        }
        private void btnThemTrai_Click(object sender, EventArgs e)
        {
            btnLuuCT.Enabled = true;
            if (gvSanPham.SelectedRowsCount == 0) return;
            product p = (product)gvSanPham.GetFocusedRow();
            if (busHoaDon.KiemTraTonTai(b, p))
            {
                XtraMessageBox.Show("Sản phẩm đã tồn tại!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            bill_detail bd = new bill_detail();
            bd.id = b.id + p.id;
            bd.created = DateTime.Now;
            bd.quantity = (int)spSoLuong.Value;
            bd.monetized = (int)(spSoLuong.Value * p.price);
            bd.product = p;
            bd.bill = b;
            dgvCTPhieuBaoGia.DataSource = busHoaDon.GetProduct(b);
        }

        private void btnXoaTrai_Click(object sender, EventArgs e)
        {
            if (gvCTPhieuBaoGia.GetFocusedRow() == null) return;
            bill_detail db = (bill_detail)gvCTPhieuBaoGia.GetFocusedRow();
            if (busHoaDon.Save())
            {
                dgvCTPhieuBaoGia.DataSource = busHoaDon.GetProduct(b);
            }
        }

        private void btnLuuCT_Click(object sender, EventArgs e)
        {
            if (busHoaDon.Save())
            {
                XtraMessageBox.Show("Lưu thành công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                dgvCTPhieuBaoGia.DataSource = busHoaDon.GetProduct(b);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dpNgayLap.EditValue == null)
            {
                CheckLoi(lbNgayLap.Text);
                dpNgayLap.Focus();
            }
            if (lkNhanVien.EditValue == null)
            {
                CheckLoi(lkNhanVien.Text);
                lkNhanVien.Focus();
            }
            if (lkKhachHang.EditValue == null)
            {
                CheckLoi(lkKhachHang.Text);
                lkKhachHang.Focus();
            }
            bill bl = new bill();
            bl.created = (DateTime)dpNgayLap.EditValue;
            bl.id = txtMaHoaDon.Text;
            bl.type = "bg";
            customer c = (customer)lkKhachHang.GetSelectedDataRow();
            staff s = (staff)lkNhanVien.GetSelectedDataRow();
            bl.customer = c;
            bl.staff = s;

            if (busHoaDon.Save())
            {
                XtraMessageBox.Show("Lưu thành công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                btnDanhMucLamMoi.PerformClick();
                txtMaHoaDon.Text = txtTongTien.Text = txtThue.Text = txtThanhToan.Text = null;
                dpNgayLap.EditValue = DateTime.Now;
                lkKhachHang.EditValue = lkNhanVien.EditValue = null;
                panelControl4.Enabled = false;
            }
            else
            {
                XtraMessageBox.Show("Lưu thất bại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            double TongTien = 0;
            double ThanhTien = 0;
            for (int i = 0; i < gvCTPhieuBaoGia.RowCount; i++)
            {
                bill_detail pp = (bill_detail)gvCTPhieuBaoGia.GetRow(i);
                TongTien += pp.monetized;
            }
            ThanhTien = TongTien + TongTien * 0.1;
            txtTongTien.Text = TongTien.ToString();
            txtThanhToan.Text = ThanhTien.ToString();
        }

    }
}