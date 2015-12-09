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
    public partial class FrmThemKhachHang : DevExpress.XtraEditors.XtraForm
    {
        BusKhachHang busKhachHang = BusKhachHang.GetInstance();
        public FrmThemKhachHang()
        {
            InitializeComponent();
        }

        public void CheckLoi(String pTen)
        {
            XtraMessageBox.Show("Thông tin " + pTen + " không được để trống", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            return;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtTen.Text == string.Empty)
            {
                CheckLoi(txtTen.Text);
                txtTen.Focus();
            }
            if (txtSdt.Text == string.Empty)
            {
                CheckLoi(lbSoDienThoai.Text);
                txtSdt.Focus();
            }
            if (txtDiaChi.Text == string.Empty)
            {
                CheckLoi(lbDiaChi.Text);
                txtDiaChi.Focus();
            }
            customer Cus = new customer();
            Cus.id = txtMa.Text;
            Cus.name = txtTen.Text;
            Cus.phone = txtSdt.Text;
            Cus.address = txtDiaChi.Text;
            Cus.created = DateTime.Now;
            if (busKhachHang.Insert(Cus))
            {
                XtraMessageBox.Show("Thêm khách hàng thành công!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                this.Close();
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                XtraMessageBox.Show("Thêm khách hàng bị lỗi!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}