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
using ComponentFactory.Krypton.Toolkit;
using BUS;
using DAL;
namespace GUI.HeThong.CauHinh
{
    public partial class FrmDangNhap : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        BusPhanQuyen busPhanQuyen = BusPhanQuyen.GetInstance();
        public GUI.HeThong.CauHinh.FrmDangNhap frm;
        public String conn;
        public string name;
        GUI.FrmMain frmHome = new GUI.FrmMain();
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void frm_dangNhap_Load(object sender, EventArgs e)
        {
            com_login.frm = this;
            com_login.conn = myRegistry.RegRead("MyConnectionString", "");

            GUI.HeThong.CauHinh.FrmCauHinh frmCauHinh = new GUI.HeThong.CauHinh.FrmCauHinh();
            com_login.frmCauHinh = frmCauHinh;

           
            com_login.frmHome = frmHome;
        }
    }
}