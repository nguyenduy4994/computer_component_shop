namespace GUI.MuaBan.KhachHang
{
    partial class FrmDanhMucKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanhMucKhachHang));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dgvKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gvKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaKhachHang = new DevExpress.XtraEditors.TextEdit();
            this.lbSoDienThoai = new DevExpress.XtraEditors.LabelControl();
            this.lbDiaChi = new DevExpress.XtraEditors.LabelControl();
            this.lbTenKhachHang = new DevExpress.XtraEditors.LabelControl();
            this.lbMaKhachHang = new DevExpress.XtraEditors.LabelControl();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDanhMucThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnDanhMucXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnDanhMucSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnDanhMucLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.txtSoDienThoai = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKhachHang = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDienThoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhachHang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl2.Controls.Add(this.dgvKhachHang);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(307, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(709, 504);
            this.panelControl2.TabIndex = 8;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachHang.Location = new System.Drawing.Point(0, 0);
            this.dgvKhachHang.MainView = this.gvKhachHang;
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(709, 504);
            this.dgvKhachHang.TabIndex = 0;
            this.dgvKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKhachHang});
            // 
            // gvKhachHang
            // 
            this.gvKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvKhachHang.GridControl = this.dgvKhachHang;
            this.gvKhachHang.Name = "gvKhachHang";
            this.gvKhachHang.OptionsView.ShowGroupPanel = false;
            this.gvKhachHang.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvKhachHang_FocusedRowChanged);
            this.gvKhachHang.DoubleClick += new System.EventHandler(this.gvKhachHang_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã khách hàng";
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên khách hàng";
            this.gridColumn2.FieldName = "name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Địa chỉ";
            this.gridColumn3.FieldName = "address";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Số điện thoại";
            this.gridColumn4.FieldName = "phone";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(148, 228);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(86, 28);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(51, 228);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(79, 28);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(101, 51);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Properties.ReadOnly = true;
            this.txtMaKhachHang.Size = new System.Drawing.Size(195, 20);
            this.txtMaKhachHang.TabIndex = 7;
            // 
            // lbSoDienThoai
            // 
            this.lbSoDienThoai.Location = new System.Drawing.Point(12, 186);
            this.lbSoDienThoai.Name = "lbSoDienThoai";
            this.lbSoDienThoai.Size = new System.Drawing.Size(66, 13);
            this.lbSoDienThoai.TabIndex = 0;
            this.lbSoDienThoai.Text = "Số điện thoại:";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.Location = new System.Drawing.Point(12, 142);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(36, 13);
            this.lbDiaChi.TabIndex = 0;
            this.lbDiaChi.Text = "Địa chỉ:";
            // 
            // lbTenKhachHang
            // 
            this.lbTenKhachHang.Location = new System.Drawing.Point(12, 98);
            this.lbTenKhachHang.Name = "lbTenKhachHang";
            this.lbTenKhachHang.Size = new System.Drawing.Size(80, 13);
            this.lbTenKhachHang.TabIndex = 0;
            this.lbTenKhachHang.Text = "Tên khách hàng:";
            // 
            // lbMaKhachHang
            // 
            this.lbMaKhachHang.Location = new System.Drawing.Point(12, 54);
            this.lbMaKhachHang.Name = "lbMaKhachHang";
            this.lbMaKhachHang.Size = new System.Drawing.Size(76, 13);
            this.lbMaKhachHang.TabIndex = 0;
            this.lbMaKhachHang.Text = "Mã khách hàng:";
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(302, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 504);
            this.splitterControl1.TabIndex = 7;
            this.splitterControl1.TabStop = false;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.btnHuy);
            this.panelControl1.Controls.Add(this.flowLayoutPanel1);
            this.panelControl1.Controls.Add(this.btnLuu);
            this.panelControl1.Controls.Add(this.txtMaKhachHang);
            this.panelControl1.Controls.Add(this.lbSoDienThoai);
            this.panelControl1.Controls.Add(this.lbMaKhachHang);
            this.panelControl1.Controls.Add(this.txtSoDienThoai);
            this.panelControl1.Controls.Add(this.txtDiaChi);
            this.panelControl1.Controls.Add(this.txtTenKhachHang);
            this.panelControl1.Controls.Add(this.lbDiaChi);
            this.panelControl1.Controls.Add(this.lbTenKhachHang);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(302, 504);
            this.panelControl1.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnDanhMucThem);
            this.flowLayoutPanel1.Controls.Add(this.btnDanhMucXoa);
            this.flowLayoutPanel1.Controls.Add(this.btnDanhMucSua);
            this.flowLayoutPanel1.Controls.Add(this.btnDanhMucLamMoi);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(302, 31);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnDanhMucThem
            // 
            this.btnDanhMucThem.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhMucThem.Image")));
            this.btnDanhMucThem.Location = new System.Drawing.Point(3, 3);
            this.btnDanhMucThem.Name = "btnDanhMucThem";
            this.btnDanhMucThem.Size = new System.Drawing.Size(24, 24);
            this.btnDanhMucThem.TabIndex = 1;
            this.btnDanhMucThem.Click += new System.EventHandler(this.btnDanhMucThem_Click);
            // 
            // btnDanhMucXoa
            // 
            this.btnDanhMucXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhMucXoa.Image")));
            this.btnDanhMucXoa.Location = new System.Drawing.Point(33, 3);
            this.btnDanhMucXoa.Name = "btnDanhMucXoa";
            this.btnDanhMucXoa.Size = new System.Drawing.Size(24, 24);
            this.btnDanhMucXoa.TabIndex = 2;
            this.btnDanhMucXoa.Click += new System.EventHandler(this.btnDanhMucXoa_Click);
            // 
            // btnDanhMucSua
            // 
            this.btnDanhMucSua.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhMucSua.Image")));
            this.btnDanhMucSua.Location = new System.Drawing.Point(63, 3);
            this.btnDanhMucSua.Name = "btnDanhMucSua";
            this.btnDanhMucSua.Size = new System.Drawing.Size(24, 24);
            this.btnDanhMucSua.TabIndex = 3;
            this.btnDanhMucSua.Click += new System.EventHandler(this.btnDanhMucSua_Click);
            // 
            // btnDanhMucLamMoi
            // 
            this.btnDanhMucLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhMucLamMoi.Image")));
            this.btnDanhMucLamMoi.Location = new System.Drawing.Point(93, 3);
            this.btnDanhMucLamMoi.Name = "btnDanhMucLamMoi";
            this.btnDanhMucLamMoi.Size = new System.Drawing.Size(24, 24);
            this.btnDanhMucLamMoi.TabIndex = 4;
            this.btnDanhMucLamMoi.Click += new System.EventHandler(this.btnDanhMucLamMoi_Click);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(101, 183);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(195, 20);
            this.txtSoDienThoai.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(101, 139);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(195, 20);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(101, 95);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(195, 20);
            this.txtTenKhachHang.TabIndex = 7;
            // 
            // FrmDanhMucKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 504);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmDanhMucKhachHang";
            this.Text = "Danh mục khách hàng";
            this.Load += new System.EventHandler(this.FrmDanhMucKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDienThoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhachHang.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.TextEdit txtMaKhachHang;
        private DevExpress.XtraEditors.LabelControl lbSoDienThoai;
        private DevExpress.XtraEditors.LabelControl lbDiaChi;
        private DevExpress.XtraEditors.LabelControl lbTenKhachHang;
        private DevExpress.XtraEditors.LabelControl lbMaKhachHang;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnDanhMucThem;
        private DevExpress.XtraEditors.SimpleButton btnDanhMucXoa;
        private DevExpress.XtraEditors.SimpleButton btnDanhMucSua;
        private DevExpress.XtraEditors.SimpleButton btnDanhMucLamMoi;
        private DevExpress.XtraEditors.TextEdit txtTenKhachHang;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraGrid.GridControl dgvKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.TextEdit txtSoDienThoai;
    }
}