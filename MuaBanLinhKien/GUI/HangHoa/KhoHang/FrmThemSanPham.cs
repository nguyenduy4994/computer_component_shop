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
        BusHangHoa busHangHoa;
        public FrmThemSanPham()
        {
            InitializeComponent();
            // Initialize
            busHangHoa = BusHangHoa.GetInstance();

            // Form event
            this.Load += FrmThemSanPham_Load;
        }

        private void FrmThemSanPham_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}