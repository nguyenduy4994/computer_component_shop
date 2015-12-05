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

            // Event mua ban
            barBtnLapHoaDon.ItemClick += barBtnLapHoaDon_ItemClick;
            barBtnLapPhieuBaoGia.ItemClick += barBtnLapPhieuBaoGia_ItemClick;
            barBtnHoaDon.ItemClick += barBtnHoaDon_ItemClick;
            barBtnPhieuBaoGia.ItemClick += barBtnPhieuBaoGia_ItemClick;

            barBtnThemKhachHang.ItemClick += barBtnThemKhachHang_ItemClick;
            barBtnDanhSachKhachHang.ItemClick += barBtnDanhSachKhachHang_ItemClick;

            // Event nut kho hang
            barBtnThemHangHoa.ItemClick += barBtnThemHangHoa_ItemClick;
            barBtnDanhMucHangHoa.ItemClick += barBtnDanhMucHangHoa_ItemClick;

            barBtnNhapHang.ItemClick += barBtnNhapHang_ItemClick;
            barBtnPhieuNhapHang.ItemClick += barBtnPhieuNhapHang_ItemClick;

            barBtnThemNhaCungCap.ItemClick += barBtnThemNhaCungCap_ItemClick;
            barBtnDanhSachNhaCungCap.ItemClick += barBtnDanhSachNhaCungCap_ItemClick;

            barBtnPhieuNhapHang.ItemClick += barBtnPhieuNhapHang_ItemClick;
            barBtnNhapHang.ItemClick +=barBtnNhapHang_ItemClick;

            // Event bao hanh
            barBtnLapPhieuNhapBaoHanh.ItemClick += barBtnLapPhieuNhapBaoHanh_ItemClick;
            barBtnCacPhieuBaoHanh.ItemClick += barBtnCacPhieuBaoHanh_ItemClick;

            barBtnKiemTraPhieuBaoHanh.ItemClick += barBtnKiemTraPhieuBaoHanh_ItemClick;
            barBtnTraSanPhamBaoHanh.ItemClick += barBtnTraSanPhamBaoHanh_ItemClick;

            // Event nhan vien
            barBtnThemNhanVien.ItemClick += barBtnThemNhanVien_ItemClick;
            barBtnDanhSachNhanVien.ItemClick += barBtnDanhSachNhanVien_ItemClick;
            barBtnDanhSachQuyen.ItemClick += barBtnDanhSachQuyen_ItemClick;
            barBtnPhanQuyen.ItemClick += barBtnPhanQuyen_ItemClick;

            // Event he thong
            barBtnCaiDatChung.ItemClick += barBtnCaiDatChung_ItemClick;
            barBtnCaiDatCSDL.ItemClick += barBtnCaiDatCSDL_ItemClick;
            barBtnGioiThieu.ItemClick += barBtnGioiThieu_ItemClick;
            barBtnTroGiup.ItemClick += barBtnTroGiup_ItemClick;

            //Load
            this.Load += FrmMain_Load;
        }

        void FrmMain_Load(object sender, EventArgs e)
        {
            ImgSlide.Images.Add(GUI.Properties.Resources.slide1);
            ImgSlide.Images.Add(GUI.Properties.Resources.slide2);
            ImgSlide.Images.Add(GUI.Properties.Resources.slide3);
            ImgSlide.Images.Add(GUI.Properties.Resources.slide4);
            ImgSlide.Images.Add(GUI.Properties.Resources.slide5);
            ImgSlide.Images.Add(GUI.Properties.Resources.slide6);
            ImgSlide.Images.Add(GUI.Properties.Resources.slide7);
            ImgSlide.Images.Add(GUI.Properties.Resources.slide8);
            ImgSlide.Images.Add(GUI.Properties.Resources.slide9);
            ImgSlide.Images.Add(GUI.Properties.Resources.slide10);

            
        }

        void barBtnTroGiup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        void barBtnGioiThieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        void barBtnCaiDatCSDL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        void barBtnCaiDatChung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        void barBtnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        void barBtnThemNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        void barBtnTraSanPhamBaoHanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        void barBtnKiemTraPhieuBaoHanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        void barBtnCacPhieuBaoHanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        void barBtnLapPhieuNhapBaoHanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        void barBtnDanhSachNhaCungCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HangHoa.NhaCungCap.FrmDanhMuc frm = new HangHoa.NhaCungCap.FrmDanhMuc();
            OpenTab(frm);
        }

        void barBtnThemNhaCungCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        void barBtnPhieuNhapHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HangHoa.NhapHang.FrmDanhMuc frm = new HangHoa.NhapHang.FrmDanhMuc();
            OpenTab(frm);
        }

        void barBtnNhapHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        void barBtnThemHangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        void barBtnDanhSachKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MuaBan.KhachHang.FrmDanhMucKhachHang frm = new MuaBan.KhachHang.FrmDanhMucKhachHang();
            OpenTab(frm);
        }

        void barBtnThemKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        void barBtnPhieuBaoGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        void barBtnHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        void barBtnLapPhieuBaoGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        void barBtnLapHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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
