using BUS;
using DAL;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace GUI.HangHoa.NhaCungCap
{
    public partial class FrmDanhMuc : DevExpress.XtraEditors.XtraForm
    {
        BusNhaCungCap busNhaCungCap = BusNhaCungCap.GetInstance();
        BusHangHoa busHangHoa = BusHangHoa.GetInstance();
        BusDanhMuc busDanhMuc = BusDanhMuc.GetInstance();
        provider ncc = null;

        public FrmDanhMuc()
        {
            InitializeComponent();

            // Form load
            this.Load += FrmDanhMuc_Load;

            gvNhaCungCap.FocusedRowChanged += gvNhaCungCap_FocusedRowChanged;
            gvNhaCungCap.DoubleClick += gvNhaCungCap_DoubleClick;
        }

        void gvNhaCungCap_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvNhaCungCap.SelectedRowsCount != 1)
                return;

            ncc = (provider)gvNhaCungCap.GetFocusedRow();
            lblTenNhaCungCap.Text = ncc.name;
            lblDiaChi.Text = ncc.address;
            lblSoDienThoai.Text = ncc.phone;
            lblEmail.Text = ncc.email;

            dgvSanPhamCungCap.DataSource = busNhaCungCap.GetProduct(ncc);
        }

        void gvNhaCungCap_DoubleClick(object sender, System.EventArgs e)
        {
            btnDanhMucSua.PerformClick();
        }

        void FrmDanhMuc_Load(object sender, System.EventArgs e)
        {
            dgvNhaCungCap.DataSource = busNhaCungCap.GetAll();
            lkDanhMuc.Properties.DataSource = busDanhMuc.GetAll();
            dgvSanPham.DataSource = busHangHoa.GetAll();
            btnLuu.Enabled = false;
        }

        private void btnDanhMucThem_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.DialogResult r = (new FrmThemNhaCungCap()).ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                btnDanhMucLamMoi.PerformClick();
            }
        }

        private void btnDanhMucLamMoi_Click(object sender, System.EventArgs e)
        {
            dgvNhaCungCap.DataSource = null;
            dgvNhaCungCap.DataSource = busNhaCungCap.GetAll();
        }

        private void btnDanhMucSua_Click(object sender, System.EventArgs e)
        {
            if (gvNhaCungCap.SelectedRowsCount != 1) return;

            FrmSuaNhaCungCap frm = new FrmSuaNhaCungCap();
            frm.NhaCungCap = (provider)gvNhaCungCap.GetFocusedRow();
            System.Windows.Forms.DialogResult r = frm.ShowDialog();

            if (r == System.Windows.Forms.DialogResult.OK)
            {
                btnDanhMucLamMoi.PerformClick();
            }
        }

        private void btnDanhMucXoa_Click(object sender, System.EventArgs e)
        {
            if (gvNhaCungCap.SelectedRowsCount != 1) return;
            provider pro = (provider)gvNhaCungCap.GetFocusedRow();
            if (busNhaCungCap.Delete(pro))
            {
                XtraMessageBox.Show("Xóa thành công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                btnDanhMucLamMoi.PerformClick();
            }
            

        }
        private void lkDanhMuc_EditValueChanged(object sender, System.EventArgs e)
        {
            if (lkDanhMuc.EditValue == null) return;
            category cat = (category)lkDanhMuc.GetSelectedDataRow();
            dgvSanPham.DataSource = busHangHoa.GetByCat(cat);
        }

        private void btnThemTrai_Click(object sender, System.EventArgs e)
        {
            btnLuu.Enabled = true;
            if (gvSanPham.GetFocusedRow() == null) return;
            product sp = (product)gvSanPham.GetFocusedRow();
            if (busNhaCungCap.KiemTraTonTai(ncc, sp))
            {
                XtraMessageBox.Show("Sản phẩm đã tồn tại!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            provider_product pp = new provider_product();
            pp.created = DateTime.Now;
            pp.product = sp;
            pp.provider = ncc;

            dgvSanPhamCungCap.DataSource = busNhaCungCap.GetProduct(ncc);
        }

        private void btnLuu_Click(object sender, System.EventArgs e)
        {
            if (busNhaCungCap.Save())
            {
                XtraMessageBox.Show("Lưu thành công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                btnDanhMucLamMoi.PerformClick();
            }
            btnLuu.Enabled = false;
        }
        
        private void btnXoaTrai_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            if (gvSanPhamCungCap.GetFocusedRow() == null) return;
            provider_product pp = (provider_product)gvSanPhamCungCap.GetFocusedRow();
            if (MessageBox.Show("Delete row?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            //gvSanPhamCungCap.DeleteSelectedRows();
            if (busNhaCungCap.DeleteProduct(pp))
            {
                MessageBox.Show("Thành công");

            }
        }
    }
}