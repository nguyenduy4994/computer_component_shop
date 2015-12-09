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
using System.IO;
using ComponentFactory.Krypton.Toolkit;
namespace GUI.HeThong.CauHinh
{
    public partial class FrmCauHinh : KryptonForm
    {
        public Form frm;
        public String connectionString;
        public FrmCauHinh()
        {
            InitializeComponent();
        }

        private void frm_cauHinh_Load(object sender, EventArgs e)
        {
            com_cauHinh.frm = this;
            com_cauHinh.connectionString = myRegistry.RegRead("MyConnectionString", "");
        }

        private void frm_cauHinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            myRegistry.RegWrite("MyConnectionString", com_cauHinh.connectionString);
        }

    }
}