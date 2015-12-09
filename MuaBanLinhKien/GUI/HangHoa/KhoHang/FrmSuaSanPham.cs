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

namespace GUI.HangHoa.KhoHang
{
    public partial class FrmSuaSanPham : DevExpress.XtraEditors.XtraForm
    {
        BusDanhMuc busDanhMuc;
        BusHangHoa busHangHoa;
        public product p;
        public FrmSuaSanPham()
        {
            InitializeComponent();

            // Initial
            busDanhMuc = BusDanhMuc.GetInstance();
            busHangHoa = BusHangHoa.GetInstance();


        }
        private void FrmSuaSanPham_Load(object sender, EventArgs e)
        {
            if (p == null) return;
            lkDanhMucSP.Properties.DataSource = busDanhMuc.GetAll();
            txtMaSanPham.Text = p.id;
            txtTenSanPham.Text = p.name;
            txtDonViTinh.Text = p.unit;
            txtDonGia.Text = p.price.ToString();
            txtBaoHanh.Text = p.warranty.ToString();
            txtMoTa.Text = p.describe;
            numSoLuong.Value = p.quantity;
            lkDanhMucSP.EditValue = p.cat_id;
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
            if (txtBaoHanh.Text == string.Empty)
            {
                CheckLoi(lbBaoHanh.Text);
                txtBaoHanh.Focus();
            }
            if (txtDonGia.Text == string.Empty)
            {
                CheckLoi(lbDonGia.Text);
                txtDonGia.Focus();
            }
            
            p.name = txtTenSanPham.Text;
            p.describe = txtMoTa.Text;
            p.created = DateTime.Now;
            p.warranty = int.Parse(txtBaoHanh.Text);
            p.quantity = int.Parse(numSoLuong.Value.ToString());
            p.unit = txtDonViTinh.Text;
            p.price = int.Parse(txtDonGia.Text);

            p.category.products.Remove(p);

            category cat = (category)lkDanhMucSP.GetSelectedDataRow();
            if (cat == null)
            {
                CheckLoi(lbDanhMucSP.Text);
                return;
            }
            cat.products.Add(p);

            if(busHangHoa.Update(p))
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Có lỗi trong quá trình cập nhật!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
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