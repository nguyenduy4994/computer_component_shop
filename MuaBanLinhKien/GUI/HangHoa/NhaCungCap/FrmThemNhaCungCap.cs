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

namespace GUI.HangHoa.NhaCungCap
{
    public partial class FrmThemNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        BusNhaCungCap busNhaCungCap = BusNhaCungCap.GetInstance();

        public FrmThemNhaCungCap()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            provider p = new provider();
            p.id = txtMa.Text;
            p.name = txtTen.Text;
            p.phone = txtSdt.Text;
            p.email = txtEmail.Text;
            p.address = txtDiaChi.Text;

            if (busNhaCungCap.Insert(p))
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                DialogResult = DialogResult.Cancel;
                XtraMessageBox.Show("Có lỗi trong quá trình thêm, vui lòng kiểm tra lại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmThemNhaCungCap_Load(object sender, EventArgs e)
        {
            txtMa.Text = busNhaCungCap.getMa();
        }
    }
}