namespace GUI.HangHoa.KhoHang
{
    partial class FrmSuaSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSuaSanPham));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnNull = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.lbDanhMucSP = new DevExpress.XtraEditors.LabelControl();
            this.lkDanhMucSP = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtMoTa = new DevExpress.XtraEditors.MemoEdit();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtBaoHanh = new DevExpress.XtraEditors.TextEdit();
            this.lbSoLuong = new DevExpress.XtraEditors.LabelControl();
            this.lbBaoHanh = new DevExpress.XtraEditors.LabelControl();
            this.txtTenSanPham = new DevExpress.XtraEditors.TextEdit();
            this.lbTenSanPham = new DevExpress.XtraEditors.LabelControl();
            this.txtMaSanPham = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            this.lbDonGia = new DevExpress.XtraEditors.LabelControl();
            this.txtDonViTinh = new DevExpress.XtraEditors.TextEdit();
            this.lbDonViTinh = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.lkDanhMucSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaoHanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonViTinh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl2.Appearance.Image")));
            this.labelControl2.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl2.Location = new System.Drawing.Point(0, 0);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Padding = new System.Windows.Forms.Padding(10);
            this.labelControl2.Size = new System.Drawing.Size(434, 50);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Sửa sản phẩm";
            // 
            // btnNull
            // 
            this.btnNull.Image = ((System.Drawing.Image)(resources.GetObject("btnNull.Image")));
            this.btnNull.Location = new System.Drawing.Point(395, 225);
            this.btnNull.Name = "btnNull";
            this.btnNull.Size = new System.Drawing.Size(24, 24);
            this.btnNull.TabIndex = 31;
            this.btnNull.Click += new System.EventHandler(this.btnNull_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(265, 253);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 29;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Location = new System.Drawing.Point(346, 253);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 30;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lbDanhMucSP
            // 
            this.lbDanhMucSP.Location = new System.Drawing.Point(13, 230);
            this.lbDanhMucSP.Name = "lbDanhMucSP";
            this.lbDanhMucSP.Size = new System.Drawing.Size(65, 13);
            this.lbDanhMucSP.TabIndex = 27;
            this.lbDanhMucSP.Text = "Danh mục sp:";
            // 
            // lkDanhMucSP
            // 
            this.lkDanhMucSP.EditValue = "Chọn danh mục sản phẩm";
            this.lkDanhMucSP.Location = new System.Drawing.Point(106, 227);
            this.lkDanhMucSP.Name = "lkDanhMucSP";
            this.lkDanhMucSP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkDanhMucSP.Properties.DisplayMember = "name";
            this.lkDanhMucSP.Properties.NullText = "Chọn danh mục sản phẩm";
            this.lkDanhMucSP.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this.lkDanhMucSP.Size = new System.Drawing.Size(283, 20);
            this.lkDanhMucSP.TabIndex = 28;
            // 
            // treeListLookUpEdit1TreeList
            // 
            this.treeListLookUpEdit1TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn2});
            this.treeListLookUpEdit1TreeList.KeyFieldName = "cat_id";
            this.treeListLookUpEdit1TreeList.Location = new System.Drawing.Point(114, 91);
            this.treeListLookUpEdit1TreeList.Name = "treeListLookUpEdit1TreeList";
            this.treeListLookUpEdit1TreeList.OptionsBehavior.EnableFiltering = true;
            this.treeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeListLookUpEdit1TreeList.ParentFieldName = "parent_id";
            this.treeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.treeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Tên danh mục";
            this.treeListColumn2.FieldName = "name";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 0;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(13, 164);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(31, 13);
            this.labelControl8.TabIndex = 25;
            this.labelControl8.Text = "Mô tả:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(106, 161);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(315, 60);
            this.txtMoTa.TabIndex = 26;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(326, 134);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(95, 21);
            this.numSoLuong.TabIndex = 24;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(177, 142);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(28, 13);
            this.labelControl6.TabIndex = 23;
            this.labelControl6.Text = "tháng";
            // 
            // txtBaoHanh
            // 
            this.txtBaoHanh.Location = new System.Drawing.Point(106, 135);
            this.txtBaoHanh.Name = "txtBaoHanh";
            this.txtBaoHanh.Size = new System.Drawing.Size(65, 20);
            this.txtBaoHanh.TabIndex = 16;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.Location = new System.Drawing.Point(255, 142);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(42, 13);
            this.lbSoLuong.TabIndex = 22;
            this.lbSoLuong.Text = "Số lượng";
            // 
            // lbBaoHanh
            // 
            this.lbBaoHanh.Location = new System.Drawing.Point(13, 142);
            this.lbBaoHanh.Name = "lbBaoHanh";
            this.lbBaoHanh.Size = new System.Drawing.Size(45, 13);
            this.lbBaoHanh.TabIndex = 21;
            this.lbBaoHanh.Text = "Bảo hành";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(106, 82);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(315, 20);
            this.txtTenSanPham.TabIndex = 14;
            // 
            // lbTenSanPham
            // 
            this.lbTenSanPham.Location = new System.Drawing.Point(13, 85);
            this.lbTenSanPham.Name = "lbTenSanPham";
            this.lbTenSanPham.Size = new System.Drawing.Size(67, 13);
            this.lbTenSanPham.TabIndex = 19;
            this.lbTenSanPham.Text = "Tên sản phẩm";
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Location = new System.Drawing.Point(106, 56);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(315, 20);
            this.txtMaSanPham.TabIndex = 17;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 59);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Mã sản phẩm";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(328, 108);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(93, 20);
            this.txtDonGia.TabIndex = 33;
            // 
            // lbDonGia
            // 
            this.lbDonGia.Location = new System.Drawing.Point(265, 111);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(37, 13);
            this.lbDonGia.TabIndex = 34;
            this.lbDonGia.Text = "Đơn giá";
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(106, 108);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(99, 20);
            this.txtDonViTinh.TabIndex = 32;
            // 
            // lbDonViTinh
            // 
            this.lbDonViTinh.Location = new System.Drawing.Point(13, 111);
            this.lbDonViTinh.Name = "lbDonViTinh";
            this.lbDonViTinh.Size = new System.Drawing.Size(52, 13);
            this.lbDonViTinh.TabIndex = 35;
            this.lbDonViTinh.Text = "Đơn vị tính";
            // 
            // FrmSuaSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 287);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.lbDonGia);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.lbDonViTinh);
            this.Controls.Add(this.btnNull);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.lbDanhMucSP);
            this.Controls.Add(this.lkDanhMucSP);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtBaoHanh);
            this.Controls.Add(this.lbSoLuong);
            this.Controls.Add(this.lbBaoHanh);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.lbTenSanPham);
            this.Controls.Add(this.txtMaSanPham);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Name = "FrmSuaSanPham";
            this.Text = "FrmSuaSanPham";
            this.Load += new System.EventHandler(this.FrmSuaSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lkDanhMucSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaoHanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonViTinh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnNull;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.LabelControl lbDanhMucSP;
        private DevExpress.XtraEditors.TreeListLookUpEdit lkDanhMucSP;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.MemoEdit txtMoTa;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtBaoHanh;
        private DevExpress.XtraEditors.LabelControl lbSoLuong;
        private DevExpress.XtraEditors.LabelControl lbBaoHanh;
        private DevExpress.XtraEditors.TextEdit txtTenSanPham;
        private DevExpress.XtraEditors.LabelControl lbTenSanPham;
        private DevExpress.XtraEditors.TextEdit txtMaSanPham;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDonGia;
        private DevExpress.XtraEditors.LabelControl lbDonGia;
        private DevExpress.XtraEditors.TextEdit txtDonViTinh;
        private DevExpress.XtraEditors.LabelControl lbDonViTinh;
    }
}