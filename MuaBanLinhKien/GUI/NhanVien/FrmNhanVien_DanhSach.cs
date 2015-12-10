using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
using DevExpress.XtraEditors;
namespace GUI.NhanVien
{
    public partial class FrmNhanVien_DanhSach : Form
    {
        BusNhanVien busNhanVien = BusNhanVien.GetInstance();
        string s;
        public FrmNhanVien_DanhSach()
        {
            InitializeComponent();

            // Form event
            this.Load += FrmNhanVien_DanhSach_Load;
        }

        void FrmNhanVien_DanhSach_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = busNhanVien.GetAll();
        }

        private void gvNhanVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            staff st = (staff)gvNhanVien.GetFocusedRow();
            txtMaNV.Text = st.id;
            txtTenNV.Text = st.name;
            txtDiaChi.Text = st.address;
            txtEmail.Text = st.email;
            txtUser.Text = st.username;
            txtPass.Text = st.password;
            dpNgaySinh.EditValue = st.birthday;
            if (st.gender == true)
            {
                chkNam.Checked = true;
            }
            else
                chkNu.Checked = true;
        }

        private void chkNu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNu.Checked == true)
                chkNam.Checked = false;
            else
                chkNam.Checked = true;
        }

        private void chkNam_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNam.Checked == true)
                chkNu.Checked = false;
            else
                chkNu.Checked = true;
        }

        public void CheckLoi(String pTen)
        {
            XtraMessageBox.Show("Thông tin " + pTen + " không được để trống", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            return;
        }

        public void XoaTrang()
        {
            foreach(Control ctr in panelControl1.Controls)
            {
                if(ctr is TextEdit)
                {
                    ((TextEdit)ctr).Text = "";
                }
            }
        }
        private void btnDanhMucThem_Click(object sender, EventArgs e)
        {
            XoaTrang();
            txtTenNV.Focus();
            s = "Them";
            txtMaNV.Text = busNhanVien.getMa();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (lbTenNV.Text == string.Empty)
            {
                CheckLoi(txtTenNV.Text);
                txtTenNV.Focus();
            }
            if (lbDiaChi.Text == string.Empty)
            {
                CheckLoi(txtDiaChi.Text);
                txtDiaChi.Focus();
            }
            if (dpNgaySinh.EditValue == null)
            {
                CheckLoi(lbNgaySinh.Text);
                dpNgaySinh.Focus();
            }
            if (chkNam.Checked == false && chkNu.Checked == false)
            {
                CheckLoi(lbGioiTinh.Text);
            }
            if(txtUser.Text == string.Empty)
            {
                CheckLoi(lbUserName.Text);
                txtUser.Focus();
            }
            if (txtPass.Text == string.Empty)
            {
                CheckLoi(lbPassword.Text);
                txtPass.Focus();
            }
            staff nv = new staff();
            nv.id = txtMaNV.Text;
            nv.name = txtTenNV.Text;
            nv.birthday = (DateTime)dpNgaySinh.EditValue;
            nv.address = txtDiaChi.Text;
            nv.email = txtEmail.Text;
            nv.username = txtUser.Text;
            nv.password = txtPass.Text;
            nv.created = DateTime.Now;
            if (chkNam.Checked)
                nv.gender = true;
            else
                nv.gender = false;
            if(s == "Them")
            {
                if (busNhanVien.Insert(nv))
                {
                    XtraMessageBox.Show("Thêm nhân viên thành công!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    btnDanhMucLamMoi.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show("Thêm nhân viên bị lỗi!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                staff n = (staff)gvNhanVien.GetFocusedRow();
                n.name = txtTenNV.Text;
                nv.birthday = (DateTime)dpNgaySinh.EditValue;
                nv.address = txtDiaChi.Text;
                nv.email = txtEmail.Text;
                nv.username = txtUser.Text;
                nv.password = txtPass.Text;
                if (chkNam.Checked)
                    nv.gender = true;
                else
                    nv.gender = false;
                if (busNhanVien.Update(nv))
                {
                    XtraMessageBox.Show("Cập nhật thành công!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    btnDanhMucLamMoi.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show("Cập nhật thất bại!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            
        }

        private void btnDanhMucLamMoi_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = busNhanVien.GetAll();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            XoaTrang();
        }

        private void btnDanhMucSua_Click(object sender, EventArgs e)
        {
            s = "Sua";
        }

        private void btnDanhMucXoa_Click(object sender, EventArgs e)
        {
            if (gvNhanVien.SelectedRowsCount != 1) return;
            staff nv = (staff)gvNhanVien.GetFocusedRow();
            if (busNhanVien.Delete(nv))
            {
                XtraMessageBox.Show("Xóa thành công!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                btnDanhMucLamMoi.PerformClick();
            }
            else
            {
                XtraMessageBox.Show("Xóa thất bại!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

    }
}
