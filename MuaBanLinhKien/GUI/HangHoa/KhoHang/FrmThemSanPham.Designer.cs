namespace GUI.HangHoa.KhoHang
{
    partial class FrmThemSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThemSanPham));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaSanPham = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbTenSanPham = new DevExpress.XtraEditors.LabelControl();
            this.txtTenSanPham = new DevExpress.XtraEditors.TextEdit();
            this.lbDonViTinh = new DevExpress.XtraEditors.LabelControl();
            this.txtDonViTinh = new DevExpress.XtraEditors.TextEdit();
            this.lbBaoHanh = new DevExpress.XtraEditors.LabelControl();
            this.txtBaoHanh = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lbSoLuong = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnNull = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.lbDanhMucSP = new DevExpress.XtraEditors.LabelControl();
            this.lkDanhMucSP = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.numSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.txtMoTa = new DevExpress.XtraEditors.MemoEdit();
            this.lbDonGia = new DevExpress.XtraEditors.LabelControl();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonViTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaoHanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkDanhMucSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
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
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Thêm sản phẩm";
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Location = new System.Drawing.Point(104, 68);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(315, 20);
            this.txtMaSanPham.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 71);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Mã sản phẩm";
            // 
            // lbTenSanPham
            // 
            this.lbTenSanPham.Location = new System.Drawing.Point(11, 97);
            this.lbTenSanPham.Name = "lbTenSanPham";
            this.lbTenSanPham.Size = new System.Drawing.Size(67, 13);
            this.lbTenSanPham.TabIndex = 4;
            this.lbTenSanPham.Text = "Tên sản phẩm";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(104, 94);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(315, 20);
            this.txtTenSanPham.TabIndex = 1;
            // 
            // lbDonViTinh
            // 
            this.lbDonViTinh.Location = new System.Drawing.Point(11, 123);
            this.lbDonViTinh.Name = "lbDonViTinh";
            this.lbDonViTinh.Size = new System.Drawing.Size(52, 13);
            this.lbDonViTinh.TabIndex = 4;
            this.lbDonViTinh.Text = "Đơn vị tính";
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(104, 120);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(99, 20);
            this.txtDonViTinh.TabIndex = 2;
            // 
            // lbBaoHanh
            // 
            this.lbBaoHanh.Location = new System.Drawing.Point(11, 150);
            this.lbBaoHanh.Name = "lbBaoHanh";
            this.lbBaoHanh.Size = new System.Drawing.Size(45, 13);
            this.lbBaoHanh.TabIndex = 4;
            this.lbBaoHanh.Text = "Bảo hành";
            // 
            // txtBaoHanh
            // 
            this.txtBaoHanh.Location = new System.Drawing.Point(104, 147);
            this.txtBaoHanh.Name = "txtBaoHanh";
            this.txtBaoHanh.Size = new System.Drawing.Size(99, 20);
            this.txtBaoHanh.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(209, 150);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(28, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "tháng";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.Location = new System.Drawing.Point(263, 150);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(42, 13);
            this.lbSoLuong.TabIndex = 4;
            this.lbSoLuong.Text = "Số lượng";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(11, 176);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(31, 13);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Mô tả:";
            // 
            // btnNull
            // 
            this.btnNull.Image = ((System.Drawing.Image)(resources.GetObject("btnNull.Image")));
            this.btnNull.Location = new System.Drawing.Point(393, 237);
            this.btnNull.Name = "btnNull";
            this.btnNull.Size = new System.Drawing.Size(24, 24);
            this.btnNull.TabIndex = 13;
            this.btnNull.Click += new System.EventHandler(this.btnNull_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(263, 265);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Location = new System.Drawing.Point(344, 265);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lbDanhMucSP
            // 
            this.lbDanhMucSP.Location = new System.Drawing.Point(11, 242);
            this.lbDanhMucSP.Name = "lbDanhMucSP";
            this.lbDanhMucSP.Size = new System.Drawing.Size(65, 13);
            this.lbDanhMucSP.TabIndex = 9;
            this.lbDanhMucSP.Text = "Danh mục sp:";
            // 
            // lkDanhMucSP
            // 
            this.lkDanhMucSP.Location = new System.Drawing.Point(104, 239);
            this.lkDanhMucSP.Name = "lkDanhMucSP";
            this.lkDanhMucSP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkDanhMucSP.Properties.DisplayMember = "name";
            this.lkDanhMucSP.Properties.NullText = "Chọn danh mục sản phẩm";
            this.lkDanhMucSP.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this.lkDanhMucSP.Size = new System.Drawing.Size(283, 20);
            this.lkDanhMucSP.TabIndex = 7;
            // 
            // treeListLookUpEdit1TreeList
            // 
            this.treeListLookUpEdit1TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn2});
            this.treeListLookUpEdit1TreeList.KeyFieldName = "cat_id";
            this.treeListLookUpEdit1TreeList.Location = new System.Drawing.Point(7, 64);
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
            // numSoLuong
            // 
            this.numSoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numSoLuong.Location = new System.Drawing.Point(326, 147);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.numSoLuong.Size = new System.Drawing.Size(93, 20);
            this.numSoLuong.TabIndex = 5;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(104, 173);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMoTa.Size = new System.Drawing.Size(315, 60);
            this.txtMoTa.TabIndex = 6;
            // 
            // lbDonGia
            // 
            this.lbDonGia.Location = new System.Drawing.Point(263, 123);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(52, 13);
            this.lbDonGia.TabIndex = 4;
            this.lbDonGia.Text = "Đơn vị tính";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(326, 120);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(93, 20);
            this.txtDonGia.TabIndex = 3;
            // 
            // FrmThemSanPham
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(434, 296);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.btnNull);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.lbDanhMucSP);
            this.Controls.Add(this.lkDanhMucSP);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtBaoHanh);
            this.Controls.Add(this.lbSoLuong);
            this.Controls.Add(this.lbBaoHanh);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.lbDonGia);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.lbDonViTinh);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.lbTenSanPham);
            this.Controls.Add(this.txtMaSanPham);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Name = "FrmThemSanPham";
            this.Text = "FrmThemSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonViTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaoHanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkDanhMucSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMaSanPham;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lbTenSanPham;
        private DevExpress.XtraEditors.TextEdit txtTenSanPham;
        private DevExpress.XtraEditors.LabelControl lbDonViTinh;
        private DevExpress.XtraEditors.TextEdit txtDonViTinh;
        private DevExpress.XtraEditors.LabelControl lbBaoHanh;
        private DevExpress.XtraEditors.TextEdit txtBaoHanh;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lbSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btnNull;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.LabelControl lbDanhMucSP;
        private DevExpress.XtraEditors.TreeListLookUpEdit lkDanhMucSP;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraEditors.SpinEdit numSoLuong;
        private DevExpress.XtraEditors.MemoEdit txtMoTa;
        private DevExpress.XtraEditors.LabelControl lbDonGia;
        private DevExpress.XtraEditors.TextEdit txtDonGia;
    }
}