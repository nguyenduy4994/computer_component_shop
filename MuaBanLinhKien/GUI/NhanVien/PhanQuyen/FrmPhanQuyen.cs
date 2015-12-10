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

namespace GUI.NhanVien.PhanQuyen
{
    public partial class FrmPhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        BusNhanVien busNhanVien = BusNhanVien.GetInstance();
        BusPhanQuyen busPhanQuyen = BusPhanQuyen.GetInstance();
        public FrmPhanQuyen()
        {
            InitializeComponent();
        }

        private void FrmPhanQuyen_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = busNhanVien.GetAll();
        }

        private void gvNhanVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(gvNhanVien.SelectedRowsCount != 1) return;
            staff nv = (staff)gvNhanVien.GetFocusedRow();
            dgvQuyen.DataSource = busPhanQuyen.GetAllPermission(nv);
        }
    }
}