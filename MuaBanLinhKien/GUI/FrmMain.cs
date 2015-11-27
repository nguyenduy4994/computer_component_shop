using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace GUI
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();

            // Event cho tab
            tabMain.CloseButtonClick += tabMain_CloseButtonClick;

            // Event cac nut lenh
            barBtnDanhSachNhanVien.ItemClick += barBtnDanhSachNhanVien_ItemClick;
            barBtnDanhSachQuyen.ItemClick += barBtnDanhSachQuyen_ItemClick;

            // Event nut kho hang
            barBtnDanhMucHangHoa.ItemClick += barBtnDanhMucHangHoa_ItemClick;
        }

        void barBtnDanhMucHangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HangHoa.KhoHang.FrmHangHoaDanhMuc frm = new HangHoa.KhoHang.FrmHangHoaDanhMuc();
            OpenTab(frm);
        }

        void barBtnDanhSachQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NhanVien.PhanQuyen.FrmNhanVien_PhanQuyen_DanhSach frm = new NhanVien.PhanQuyen.FrmNhanVien_PhanQuyen_DanhSach();
            OpenTab(frm);
        }

        void tabMain_CloseButtonClick(object sender, EventArgs e)
        {
            XtraTabPage tabPage = tabMain.SelectedTabPage;
            tabMain.TabPages.Remove(tabPage);
        }

        void barBtnDanhSachNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NhanVien.FrmNhanVien_DanhSach frm = new NhanVien.FrmNhanVien_DanhSach();
            OpenTab(frm);
        }

        public void OpenTab(Form pForm)
        {
            if (CheckTabOpened(pForm.Text) == true) return;

            // Khoi tao
            DevExpress.XtraTab.XtraTabPage tab = new DevExpress.XtraTab.XtraTabPage();

            // Cai dat form
            pForm.Dock = DockStyle.Fill;
            pForm.TopLevel = false;
            pForm.Parent = this;
            pForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            // Cai dat tab
            tab.Text = pForm.Text;
            //tab.Size = new System.Drawing.Size(878, 350);
            tab.Controls.Add(pForm);

            // Hien nguyen hien
            pForm.Show();
            tabMain.TabPages.Add(tab);
            tabMain.SelectedTabPage = tab;
        }

        private bool CheckTabOpened(string pTabText, bool pActive = true)
        {
            foreach (XtraTabPage tab in tabMain.TabPages)
            {
                if (tab.Text == pTabText)
                {
                    if (pActive)
                        tabMain.SelectedTabPage = tab;

                    return true;
                }
            }

            return false;
        }
    }
}
