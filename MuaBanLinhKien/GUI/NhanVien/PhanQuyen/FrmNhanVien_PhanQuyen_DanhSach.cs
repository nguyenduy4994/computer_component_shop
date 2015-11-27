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

namespace GUI.NhanVien.PhanQuyen
{
    public partial class FrmNhanVien_PhanQuyen_DanhSach : Form
    {
        BusPhanQuyen busPhanQuyen = BusPhanQuyen.GetInstance();
        public FrmNhanVien_PhanQuyen_DanhSach()
        {
            InitializeComponent();

            // Form event
            this.Load += FrmNhanVien_PhanQuyen_DanhSach_Load;
        }

        void FrmNhanVien_PhanQuyen_DanhSach_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = busPhanQuyen.GetAll();
        }
    }
}
