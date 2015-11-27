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
namespace GUI.NhanVien
{
    public partial class FrmNhanVien_DanhSach : Form
    {
        BusNhanVien busNhanVien = BusNhanVien.GetInstance();

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
    }
}
