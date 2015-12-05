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
using DAL;
using DevExpress.XtraEditors;

namespace GUI.HangHoa.KhoHang
{
    public partial class FrmHangHoaDanhMuc : Form
    {
        BusDanhMuc busDanhMuc;
        BusHangHoa busHangHoa;
        public FrmHangHoaDanhMuc()
        {
            InitializeComponent();

            // Initial
            busDanhMuc = BusDanhMuc.GetInstance();
            busHangHoa = BusHangHoa.GetInstance();

            // Form event
            this.Load += FrmHangHoaDanhMuc_Load;
        }

        void FrmHangHoaDanhMuc_Load(object sender, EventArgs e)
        {
            tlDanhMuc.DataSource = busDanhMuc.GetAll();
            if (tlDanhMuc.AllNodesCount > 0)
            {
                category cat = (category)tlDanhMuc.GetDataRecordByNode(tlDanhMuc.Nodes[0]);
                dgvHangHoa.DataSource = busHangHoa.GetByCat(cat);
            }
        }

        private void btnDanhMucLamMoi_Click(object sender, EventArgs e)
        {
            tlDanhMuc.DataSource = busDanhMuc.GetAll();
        }

        private void btnDanhMucThem_Click(object sender, EventArgs e)
        {
            DialogResult r = (new HangHoa.KhoHang.FrmThemDanhMuc()).ShowDialog();
            if (r == DialogResult.OK)
            {
                btnDanhMucLamMoi.PerformClick();
            }
        }

        private void tlDanhMuc_Click(object sender, EventArgs e)
        {
            if (tlDanhMuc.FocusedNode == null) return;

            category cat = (category)tlDanhMuc.GetDataRecordByNode(tlDanhMuc.FocusedNode);
            dgvHangHoa.DataSource = busHangHoa.GetByCat(cat);
        }

        private void btnDanhMucSua_Click(object sender, EventArgs e)
        {
            if (tlDanhMuc.FocusedNode == null) return;

            category cat = (category)tlDanhMuc.GetDataRecordByNode(tlDanhMuc.FocusedNode);
            FrmSuaDanhMuc frm = new FrmSuaDanhMuc();
            frm.Cat = cat;
            DialogResult r = frm.ShowDialog();
            if (r == DialogResult.OK)
            {
                XtraMessageBox.Show("Sửa danh mục thành công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                btnDanhMucLamMoi.PerformClick();
            }
        }

        private void btnDanhMucXoa_Click(object sender, EventArgs e)
        {
            if (tlDanhMuc.FocusedNode == null) return;
            category cat = (category)tlDanhMuc.GetDataRecordByNode(tlDanhMuc.FocusedNode);
            
            if(busDanhMuc.Delete(cat))
            {
                XtraMessageBox.Show("Xóa danh mục thành công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                btnDanhMucLamMoi.PerformClick();
            }
            else
            {
                XtraMessageBox.Show("Thông tin danh mục đang được sử dụng!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                
            }
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            DialogResult r = (new HangHoa.KhoHang.FrmThemSanPham()).ShowDialog();
            if (r == DialogResult.OK)
            {
                btnLamMoiSanPham.PerformClick();
                XtraMessageBox.Show("Thêm sản phẩm thành công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnSuaSanPham_Click(object sender, EventArgs e)
        {
            if (gvHangHoa.GetFocusedRow() == null) return;
            product pro = (product)gvHangHoa.GetFocusedRow();
            FrmSuaSanPham frm = new FrmSuaSanPham();
            frm.p = pro;
            frm.ShowDialog();
            DialogResult d = frm.DialogResult;
            if(d == DialogResult.OK)
            {
                btnDanhMucLamMoi.PerformClick();
                XtraMessageBox.Show("Sửa sản phẩm thành công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            if (gvHangHoa.GetFocusedRow() == null) return;
            product pro = (product)gvHangHoa.GetFocusedRow();
            if (busHangHoa.Delete(pro))
            {
                btnDanhMucLamMoi.PerformClick();
                XtraMessageBox.Show("Xóa sản phẩm thành công", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnLamMoiSanPham_Click(object sender, EventArgs e)
        {
            dgvHangHoa.Refresh();
        }
    }
}
