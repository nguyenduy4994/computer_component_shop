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
        public FrmDanhMuc()
        {
            InitializeComponent();
        }

        private void gvPhieuNhapHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvPhieuNhapHang.SelectedRowsCount != 1)
                return;
            receipt r = (receipt)gvPhieuNhapHang.GetFocusedRow();
            dpNgayLap.EditValue = r.created;
            txtMaPhieuNhap.Text = r.id;
            lkNhaCungCap.EditValue = r.provider;
            lkNhanVien.EditValue = r.staff.id;
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
        }

        private void btnDanhMucLamMoi_Click(object sender, EventArgs e)
        {
            dgvPhieuNhapHang.Refresh();
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

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnThemTrai_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaTrai_Click(object sender, EventArgs e)
        {

        }
    }
}