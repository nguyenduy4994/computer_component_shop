using BUS;
using DAL;
namespace GUI.HangHoa.NhaCungCap
{
    public partial class FrmDanhMuc : DevExpress.XtraEditors.XtraForm
    {
        BusNhaCungCap busNhaCungCap = BusNhaCungCap.GetInstance();
        BusHangHoa busHangHoa = BusHangHoa.GetInstance();
        BusDanhMuc busDanhMuc = BusDanhMuc.GetInstance();

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

            provider ncc = (provider)gvNhaCungCap.GetFocusedRow();
            lblTenNhaCungCap.Text = ncc.name;
            lblDiaChi.Text = ncc.address;
            lblSoDienThoai.Text = ncc.phone;
            lblEmail.Text = ncc.email;
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
            dgvNhaCungCap.Refresh();
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


        }
        private void lkDanhMuc_EditValueChanged(object sender, System.EventArgs e)
        {
            if (lkDanhMuc.EditValue == null) return;
            category cat = (category)lkDanhMuc.GetSelectedDataRow();
            dgvSanPham.DataSource = busHangHoa.GetByCat(cat);
        }

        private void btnThemTrai_Click(object sender, System.EventArgs e)
        {
            product sp = (product)gvSanPham.GetFocusedRow();
            provider ncc = (provider)gvNhaCungCap.GetFocusedRow();
            
        }
    }
}