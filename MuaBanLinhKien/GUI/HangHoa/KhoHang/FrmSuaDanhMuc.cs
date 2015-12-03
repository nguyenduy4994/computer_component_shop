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
    public partial class FrmSuaDanhMuc : DevExpress.XtraEditors.XtraForm
    {
        BusDanhMuc busDanhMuc;
        BusHangHoa busHangHoa;
        public category Cat;

        public FrmSuaDanhMuc()
        {
            InitializeComponent();

            // Init
            busDanhMuc = BusDanhMuc.GetInstance();
            busHangHoa = BusHangHoa.GetInstance();

            // Form event
            this.Load += FrmSuaDanhMuc_Load;

            // Button event
            btnLuu.Click += btnLuu_Click;

        }

        void FrmSuaDanhMuc_Load(object sender, EventArgs e)
        {
            if (Cat == null) return;
            txtMaDanhMuc.Text = Cat.cat_id;
            txtTenDanhMuc.Text = Cat.name;
            txtMoTa.Text = Cat.describe;
            lkDanhMucCha.EditValue = Cat.category1;//chỗ này
        }

        void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenDanhMuc.Text == string.Empty)
            {
                XtraMessageBox.Show("Tên danh mục không được để trống", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtTenDanhMuc.Focus();
                return;
            }

            Cat.name = txtTenDanhMuc.Text;
            Cat.describe = txtTenDanhMuc.Text;
            Cat.category1 = (category)lkDanhMucCha.EditValue;

            if (busDanhMuc.Update(Cat))
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Có lỗi trong quá trình cập nhật", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void btnNull_Click(object sender, EventArgs e)
        {
            lkDanhMucCha.EditValue = null;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}