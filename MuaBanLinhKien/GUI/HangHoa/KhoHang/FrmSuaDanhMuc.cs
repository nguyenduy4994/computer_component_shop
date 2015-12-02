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
            lkDanhMucCha.EditValue = Cat.category1;
        }

        void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenDanhMuc.Text == string.Empty)
            {
                XtraMessageBox.Show("Tên danh mục không được để trống", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtTenDanhMuc.Focus();
                return;
            }

            
        }
    }
}