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

namespace GUI.HangHoa.NhapHang
{
    public partial class FrmDanhMuc : DevExpress.XtraEditors.XtraForm
    {
        BusDanhMuc busDanhMuc = BusDanhMuc.GetInstance();
        BusHangHoa busHangHoa = BusHangHoa.GetInstance();
        BusNhanVien busNhanVien = BusNhanVien.GetInstance();
        BusNhaCungCap busNhaCungCap = BusNhaCungCap.GetInstance();
        BusNhapHang busNhapHang = BusNhapHang.GetInstance();
        receipt r = null;
        public FrmDanhMuc()
        {
            InitializeComponent();
        }

        private void gvPhieuNhapHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvPhieuNhapHang.SelectedRowsCount != 1)
                return;
            r = (receipt)gvPhieuNhapHang.GetFocusedRow();
            dpNgayLap.EditValue = r.created;
            dpNgayLap.DateTime = r.created;
            txtMaPhieuNhap.Text = r.id;
            lkNhaCungCap.EditValue = r.provider.id;
            lkNhanVien.EditValue = r.staff.id;

            dgvChiTietNhapHang.DataSource = busNhapHang.GetProduct(r);
        }

        private void FrmDanhMuc_Load(object sender, EventArgs e)
        {
            dgvPhieuNhapHang.DataSource = busNhapHang.GetAll();
            lkDanhMucSP.Properties.DataSource = busDanhMuc.GetAll();
            lkNhaCungCap.Properties.DataSource = busNhaCungCap.GetAll();
            lkNhanVien.Properties.DataSource = busNhanVien.GetAll();
            dgvSanPham.DataSource = busHangHoa.GetAll();
            Enable(false);
        }
        
        private void gvPhieuNhapHang_DoubleClick(object sender, EventArgs e)
        {
            btnDanhMucSua.PerformClick();
        }
        public void Enable(bool pTinhTrang)
        {
            txtMaPhieuNhap.Enabled = dpNgayLap.Enabled = lkNhanVien.Enabled = lkNhaCungCap.Enabled = panelControl3.Enabled = pTinhTrang;
        }
        private void btnDanhMucThem_Click(object sender, EventArgs e)
        {
            Enable(true);
            dpNgayLap.Focus();
            txtMaPhieuNhap.Text = busNhapHang.getMa();
            dpNgayLap.EditValue = null;

        }

        private void btnDanhMucLamMoi_Click(object sender, EventArgs e)
        {
            dgvPhieuNhapHang.DataSource = busNhapHang.GetAll();
            dgvChiTietNhapHang.DataSource = busNhapHang.GetProduct(r);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaPhieuNhap.Text = null;
            dpNgayLap.EditValue = null;
            lkNhaCungCap.EditValue = lkNhanVien.EditValue = null;
            Enable(false);
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
            if (lkNhaCungCap.EditValue == null)
            {
                CheckLoi(lkNhaCungCap.Text);
                lkNhaCungCap.Focus();
            }
            r = new receipt();
            r.id = txtMaPhieuNhap.Text;
            r.created = (DateTime)dpNgayLap.EditValue;
            staff st = (staff)lkNhanVien.GetSelectedDataRow();
            provider pr = (provider)lkNhaCungCap.GetSelectedDataRow();
            r.staff = st;
            r.provider = pr;
            if (busNhapHang.Save())
            {
                XtraMessageBox.Show("Lưu thành công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                btnDanhMucLamMoi.PerformClick();
            }
            else
            {
                XtraMessageBox.Show("Lưu thất bại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            txtMaPhieuNhap.Text = null;
            dpNgayLap.EditValue = lkNhaCungCap.EditValue = lkNhanVien.EditValue = null;
            panelControl4.Enabled = false;
        }

        private void btnThemTrai_Click(object sender, EventArgs e)
        {
            if (gvSanPham.GetFocusedRow() == null || spSoLuong.Value == 0) return;
            product sp = (product)gvSanPham.GetFocusedRow();
            if (busNhapHang.KiemTraTonTai(r, sp))
            {
                XtraMessageBox.Show("Sản phẩm đã tồn tại!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            receipt_detail rd = new receipt_detail();
            rd.created = DateTime.Now;
            rd.quantity = (int)spSoLuong.Value;
            rd.monetized = (int)(spSoLuong.Value * sp.price);
            rd.receipt = r;
            rd.product = sp;
            dgvChiTietNhapHang.DataSource = busNhapHang.GetProduct(r);
        }
        private void btnXoaTrai_Click(object sender, EventArgs e)
        {
            if (gvChiTietNhapHang.GetFocusedRow() == null) return;
            receipt_detail rd = (receipt_detail)gvChiTietNhapHang.GetFocusedRow();
            r.receipt_details.Remove(rd);
            dgvChiTietNhapHang.DataSource = busNhapHang.GetProduct(r);
            //if(busNhapHang.DeleteProduct(rd))
            //{
            //    dgvChiTietNhapHang.DataSource = busNhapHang.GetProduct(r);
            //}
            //else
            //{
            //    XtraMessageBox.Show("Xóa lỗi!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            //}
        }

        private void btnDanhMucSua_Click(object sender, EventArgs e)
        {
            Enable(true);
        }

        private void btnLuuCT_Click(object sender, EventArgs e)
        {
            if (busNhapHang.Save())
            {
                XtraMessageBox.Show("Lưu thành công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                btnDanhMucLamMoi.PerformClick();
            }
        }
    }
}