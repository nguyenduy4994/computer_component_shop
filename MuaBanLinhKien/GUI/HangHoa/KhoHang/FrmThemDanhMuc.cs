﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DAL;

namespace GUI.HangHoa.KhoHang
{
    public partial class FrmThemDanhMuc : DevExpress.XtraEditors.XtraForm
    {
        BusDanhMuc busDanhMuc;
        public FrmThemDanhMuc()
        {
            InitializeComponent();

            // Initialize
            busDanhMuc = BusDanhMuc.GetInstance();

            // Form event
            this.Load += FrmThemDanhMuc_Load;
        }

        void FrmThemDanhMuc_Load(object sender, EventArgs e)
        {
            lkDanhMucCha.Properties.DataSource = busDanhMuc.GetAll();
            txtMaDanhMuc.Text = busDanhMuc.getMa();
        }

        void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenDanhMuc.Text == string.Empty)
            {
                XtraMessageBox.Show(lbTenDanhMuc.Text + "không được để trống", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtTenDanhMuc.Focus();
                return;
            }

            category cat = new category();
            cat.cat_id = txtMaDanhMuc.Text;
            cat.name = txtTenDanhMuc.Text;
            cat.describe = txtMoTa.Text;
            cat.created = DateTime.Now;

            if(lkDanhMucCha.GetSelectedDataRow() != null)
            {
                category parent_cat = (category)lkDanhMucCha.GetSelectedDataRow();
                parent_cat.categories.Add(cat);
            }
            else
            {
                busDanhMuc.Insert(cat);
            }

            // Save
            if (busDanhMuc.Save())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                XtraMessageBox.Show("Thêm danh mục thất bại, vui lòng thử lại", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnNull_Click(object sender, EventArgs e)
        {
            lkDanhMucCha.EditValue = null;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
