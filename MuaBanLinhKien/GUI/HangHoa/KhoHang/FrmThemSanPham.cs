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

namespace GUI.HangHoa.KhoHang
{
    public partial class FrmThemSanPham : DevExpress.XtraEditors.XtraForm
    {
        BusDanhMuc busDanhMuc;
        BusHangHoa busHangHoa;
        public FrmThemSanPham()
        {
            InitializeComponent();
            // Initialize
            busHangHoa = BusHangHoa.GetInstance();
            busDanhMuc = BusDanhMuc.GetInstance();

            // Form event
            this.Load += FrmThemSanPham_Load;
        }

        private void FrmThemSanPham_Load(object sender, EventArgs e)
        {
            lkDanhMucSP.Properties.DataSource = busDanhMuc.GetAll();
        }
        public void CheckLoi(String pTen)
        {
            XtraMessageBox.Show("Thông tin " + pTen + " không được để trống", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            return;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenSanPham.Text == string.Empty)
            {
                CheckLoi(lbTenSanPham.Text);
                txtTenSanPham.Focus();
            }
            if (txtDonViTinh.Text == string.Empty)
            {
                CheckLoi(lbDonViTinh.Text);
                txtDonViTinh.Focus();
            }
            if(txtBaoHanh.Text == string.Empty)
            {
                CheckLoi(lbBaoHanh.Text);
                txtBaoHanh.Focus();
            }
            if(txtDonGia.Text == string.Empty)
            {
                CheckLoi(lbDonGia.Text);
                txtDonGia.Focus();
            }
            if (lkDanhMucSP.EditValue == string.Empty)
            {
                CheckLoi(lbDanhMucSP.Text);
                return;
            }

            product p = new product();
            p.id = txtMaSanPham.Text;
            p.name = txtTenSanPham.Text;
            p.describe = txtMoTa.Text;
            p.created = DateTime.Now;
            p.warranty = int.Parse(txtBaoHanh.Text);
            p.quantity = int.Parse(numSoLuong.Value.ToString());
            p.unit = txtDonViTinh.Text;
            p.price = int.Parse(txtDonGia.Text);
            category cat = (category)lkDanhMucSP.GetSelectedDataRow();
            cat.products.Add(p);

            if (busHangHoa.Save())
            {
                this.Close();
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                XtraMessageBox.Show("Thêm sản phẩm bị lỗi", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnNull_Click(object sender, EventArgs e)
        {
            lkDanhMucSP.EditValue = null;
        }
    }
}