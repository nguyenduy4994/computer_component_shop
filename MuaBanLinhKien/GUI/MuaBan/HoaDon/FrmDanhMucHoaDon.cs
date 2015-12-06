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
    public partial class FrmDanhMucHoaDon : DevExpress.XtraEditors.XtraForm
    {
        BusDanhMuc busDanhMuc = BusDanhMuc.GetInstance();
        BusHangHoa busHangHoa = BusHangHoa.GetInstance();
        BusKhachHang busKhachHang = BusKhachHang.GetInstance();
        BusNhanVien busNhanVien = BusNhanVien.GetInstance();
        BusHoaDon busHoaDon = BusHoaDon.GetInstance();
        public FrmDanhMucHoaDon()
        {
            InitializeComponent();
        }
        private void FrmDanhMucHoaDon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = busHoaDon.GetAll();
            lkDanhMucSP.Properties.DataSource = busDanhMuc.GetAll();
            dgvSanPham.DataSource = busHangHoa.GetAll();
            panelControl4.Enabled = false;
        }

        private void gvHoaDon_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvHoaDon.SelectedRowsCount != 1)
                return;
            bill b = (bill)gvHoaDon.GetFocusedRow();
            txtMaHoaDon.Text = b.id;
            dpNgayLap.EditValue = b.created;
            lkKhachHang.EditValue = b.customer_id;
            lkNhanVien.EditValue = b.staff_id;
            btnLuu.Enabled = btnHuy.Enabled = btnThemKhachHang.Enabled = false;
        }

        private void gvHoaDon_DoubleClick(object sender, EventArgs e)
        {
            btnDanhMucSua.PerformClick();
        }

        private void btnDanhMucThem_Click(object sender, EventArgs e)
        {
            panelControl4.Enabled = true;
            dpNgayLap.Focus();
            btnDanhMucThem.Enabled = false;
        }

        private void btnDanhMucLamMoi_Click(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = busHoaDon.GetAll();
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
            if(r == DialogResult.OK)
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