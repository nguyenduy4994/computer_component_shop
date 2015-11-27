namespace GUI.HangHoa.KhoHang
{
    partial class FrmHangHoaDanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHangHoaDanhMuc));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.tlDanhMuc = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDanhMucThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnDanhMucXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnDanhMucSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnDanhMucLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.dgvHangHoa = new DevExpress.XtraGrid.GridControl();
            this.gvHangHoa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlDanhMuc)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.Panel1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.splitContainerControl1.Panel1.Controls.Add(this.tlDanhMuc);
            this.splitContainerControl1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainerControl1.Panel1.Text = "Danh mục hàng hóa";
            this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.Panel2.Controls.Add(this.dgvHangHoa);
            this.splitContainerControl1.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainerControl1.Panel2.Text = "Hàng hóa";
            this.splitContainerControl1.Size = new System.Drawing.Size(799, 466);
            this.splitContainerControl1.SplitterPosition = 253;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // tlDanhMuc
            // 
            this.tlDanhMuc.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tlDanhMuc.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn2});
            this.tlDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlDanhMuc.KeyFieldName = "cat_id";
            this.tlDanhMuc.Location = new System.Drawing.Point(0, 31);
            this.tlDanhMuc.Name = "tlDanhMuc";
            this.tlDanhMuc.ParentFieldName = "parent_id";
            this.tlDanhMuc.Size = new System.Drawing.Size(249, 431);
            this.tlDanhMuc.TabIndex = 3;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Tên danh mục";
            this.treeListColumn2.FieldName = "name";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 0;
            this.treeListColumn2.Width = 147;
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(249, 31);
            this.flowLayoutPanel1.TabIndex = 2;
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
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.simpleButton2);
            this.flowLayoutPanel2.Controls.Add(this.simpleButton6);
            this.flowLayoutPanel2.Controls.Add(this.simpleButton7);
            this.flowLayoutPanel2.Controls.Add(this.simpleButton8);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(537, 31);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(3, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(24, 24);
            this.simpleButton2.TabIndex = 1;
            // 
            // simpleButton6
            // 
            this.simpleButton6.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.Image")));
            this.simpleButton6.Location = new System.Drawing.Point(33, 3);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(24, 24);
            this.simpleButton6.TabIndex = 2;
            // 
            // simpleButton7
            // 
            this.simpleButton7.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton7.Image")));
            this.simpleButton7.Location = new System.Drawing.Point(63, 3);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(24, 24);
            this.simpleButton7.TabIndex = 3;
            // 
            // simpleButton8
            // 
            this.simpleButton8.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton8.Image")));
            this.simpleButton8.Location = new System.Drawing.Point(93, 3);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(24, 24);
            this.simpleButton8.TabIndex = 4;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Mã danh mục";
            this.treeListColumn1.FieldName = "cat_id";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 86;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Mã danh mục";
            this.treeListColumn3.FieldName = "cat_id";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 0;
            this.treeListColumn3.Width = 80;
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHangHoa.Location = new System.Drawing.Point(0, 31);
            this.dgvHangHoa.MainView = this.gvHangHoa;
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.Size = new System.Drawing.Size(537, 431);
            this.dgvHangHoa.TabIndex = 4;
            this.dgvHangHoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHangHoa});
            // 
            // gvHangHoa
            // 
            this.gvHangHoa.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvHangHoa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gvHangHoa.GridControl = this.dgvHangHoa;
            this.gvHangHoa.Name = "gvHangHoa";
            this.gvHangHoa.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã hàng hóa";
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên hàng hóa";
            this.gridColumn2.FieldName = "name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Số lượng";
            this.gridColumn3.FieldName = "quantity";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Đơn vị tính";
            this.gridColumn4.FieldName = "unit";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Bảo hành";
            this.gridColumn5.FieldName = "warranty";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Mô tả";
            this.gridColumn6.FieldName = "describe";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Tạo";
            this.gridColumn7.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn7.FieldName = "created";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Chỉnh sửa";
            this.gridColumn8.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.gridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn8.FieldName = "modified";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // FrmHangHoaDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 466);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmHangHoaDanhMuc";
            this.Text = "Danh mục hàng hóa";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlDanhMuc)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHangHoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnDanhMucThem;
        private DevExpress.XtraEditors.SimpleButton btnDanhMucXoa;
        private DevExpress.XtraEditors.SimpleButton btnDanhMucSua;
        private DevExpress.XtraEditors.SimpleButton btnDanhMucLamMoi;
        private DevExpress.XtraTreeList.TreeList tlDanhMuc;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraGrid.GridControl dgvHangHoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}