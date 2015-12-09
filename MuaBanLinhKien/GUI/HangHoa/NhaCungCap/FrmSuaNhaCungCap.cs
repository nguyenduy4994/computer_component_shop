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

namespace GUI.HangHoa.NhaCungCap
{
    public partial class FrmSuaNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public provider NhaCungCap;
        
        public FrmSuaNhaCungCap()
        {
            InitializeComponent();
        }

        private void FrmSuaNhaCungCap_Load(object sender, EventArgs e)
        {
            txtMa.Text = NhaCungCap.id;
            txtTen.Text = NhaCungCap.name;
            txtSdt.Text = NhaCungCap.phone;
            txtEmail.Text = NhaCungCap.email;
            txtDiaChi.Text = NhaCungCap.address;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhaCungCap.name = txtTen.Text;
            NhaCungCap.phone = txtSdt.Text;
            NhaCungCap.email = txtEmail.Text;
            NhaCungCap.address = txtDiaChi.Text;

            if ((BusNhaCungCap.GetInstance()).Update(NhaCungCap))
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                DialogResult = DialogResult.Cancel;
                XtraMessageBox.Show("Có lỗi trong quá trình cập nhật", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}