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
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaPhieuNhap = new DevExpress.XtraEditors.TextEdit();
            this.lbNhanVien = new DevExpress.XtraEditors.LabelControl();
            this.lbNhaCungCap = new DevExpress.XtraEditors.LabelControl();
            this.lbNgayLap = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDanhMucThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnDanhMucXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnDanhMucSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnDanhMucLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.dgvKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gvKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieuNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachHang)).BeginInit();
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
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(148, 228);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(86, 28);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(51, 228);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(79, 28);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(101, 51);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(195, 20);
            this.txtMaPhieuNhap.TabIndex = 7;
            // 
            // lbNhanVien
            // 
            this.lbNhanVien.Location = new System.Drawing.Point(12, 186);
            this.lbNhanVien.Name = "lbNhanVien";
            this.lbNhanVien.Size = new System.Drawing.Size(66, 13);
            this.lbNhanVien.TabIndex = 0;
            this.lbNhanVien.Text = "Số điện thoại:";
            // 
            // lbNhaCungCap
            // 
            this.lbNhaCungCap.Location = new System.Drawing.Point(12, 142);
            this.lbNhaCungCap.Name = "lbNhaCungCap";
            this.lbNhaCungCap.Size = new System.Drawing.Size(36, 13);
            this.lbNhaCungCap.TabIndex = 0;
            this.lbNhaCungCap.Text = "Địa chỉ:";
            // 
            // lbNgayLap
            // 
            this.lbNgayLap.Location = new System.Drawing.Point(12, 98);
            this.lbNgayLap.Name = "lbNgayLap";
            this.lbNgayLap.Size = new System.Drawing.Size(80, 13);
            this.lbNgayLap.TabIndex = 0;
            this.lbNgayLap.Text = "Tên khách hàng:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 54);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã khách hàng:";
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
            this.panelControl1.Controls.Add(this.txtMaPhieuNhap);
            this.panelControl1.Controls.Add(this.textEdit3);
            this.panelControl1.Controls.Add(this.lbNhanVien);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.textEdit1);
            this.panelControl1.Controls.Add(this.textEdit2);
            this.panelControl1.Controls.Add(this.lbNhaCungCap);
            this.panelControl1.Controls.Add(this.lbNgayLap);
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
            // 
            // btnDanhMucXoa
            // 
            this.btnDanhMucXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhMucXoa.Image")));
            this.btnDanhMucXoa.Location = new System.Drawing.Point(33, 3);
            this.btnDanhMucXoa.Name = "btnDanhMucXoa";
            this.btnDanhMucXoa.Size = new System.Drawing.Size(24, 24);
            this.btnDanhMucXoa.TabIndex = 2;
            // 
            // btnDanhMucSua
            // 
            this.btnDanhMucSua.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhMucSua.Image")));
            this.btnDanhMucSua.Location = new System.Drawing.Point(63, 3);
            this.btnDanhMucSua.Name = "btnDanhMucSua";
            this.btnDanhMucSua.Size = new System.Drawing.Size(24, 24);
            this.btnDanhMucSua.TabIndex = 3;
            // 
            // btnDanhMucLamMoi
            // 
            this.btnDanhMucLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhMucLamMoi.Image")));
            this.btnDanhMucLamMoi.Location = new System.Drawing.Point(93, 3);
            this.btnDanhMucLamMoi.Name = "btnDanhMucLamMoi";
            this.btnDanhMucLamMoi.Size = new System.Drawing.Size(24, 24);
            this.btnDanhMucLamMoi.TabIndex = 4;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(101, 139);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(195, 20);
            this.textEdit1.TabIndex = 7;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(101, 95);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(195, 20);
            this.textEdit2.TabIndex = 7;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(101, 183);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(195, 20);
            this.textEdit3.TabIndex = 7;
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
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã khách hàng";
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên khách hàng";
            this.gridColumn2.FieldName = "name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Địa chỉ";
            this.gridColumn3.FieldName = "address";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Số điện thoại";
            this.gridColumn4.FieldName = "phone";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
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
            this.Text = "FrmDanhMucKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieuNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.TextEdit txtMaPhieuNhap;
        private DevExpress.XtraEditors.LabelControl lbNhanVien;
        private DevExpress.XtraEditors.LabelControl lbNhaCungCap;
        private DevExpress.XtraEditors.LabelControl lbNgayLap;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnDanhMucThem;
        private DevExpress.XtraEditors.SimpleButton btnDanhMucXoa;
        private DevExpress.XtraEditors.SimpleButton btnDanhMucSua;
        private DevExpress.XtraEditors.SimpleButton btnDanhMucLamMoi;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.GridControl dgvKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}