namespace GUI.NhanVien
{
    partial class FrmThemNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThemNhanVien));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.chkNu = new DevExpress.XtraEditors.CheckEdit();
            this.chkNam = new DevExpress.XtraEditors.CheckEdit();
            this.dpNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.lbGioiTinh = new DevExpress.XtraEditors.LabelControl();
            this.lbUserName = new DevExpress.XtraEditors.LabelControl();
            this.lbEmail = new DevExpress.XtraEditors.LabelControl();
            this.lnMaNV = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.lbNgaySinh = new DevExpress.XtraEditors.LabelControl();
            this.txtTenNV = new DevExpress.XtraEditors.TextEdit();
            this.lbPassword = new DevExpress.XtraEditors.LabelControl();
            this.lbDiaChi = new DevExpress.XtraEditors.LabelControl();
            this.lbTenNV = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.chkNu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).BeginInit();
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
            this.labelControl2.Size = new System.Drawing.Size(334, 50);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Thêm nhân viên";
            // 
            // chkNu
            // 
            this.chkNu.Location = new System.Drawing.Point(229, 250);
            this.chkNu.Name = "chkNu";
            this.chkNu.Properties.Caption = "Nữ";
            this.chkNu.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.chkNu.Size = new System.Drawing.Size(75, 19);
            this.chkNu.TabIndex = 30;
            // 
            // chkNam
            // 
            this.chkNam.EditValue = true;
            this.chkNam.Location = new System.Drawing.Point(109, 249);
            this.chkNam.Name = "chkNam";
            this.chkNam.Properties.Caption = "Nam";
            this.chkNam.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.chkNam.Size = new System.Drawing.Size(75, 19);
            this.chkNam.TabIndex = 29;
            // 
            // dpNgaySinh
            // 
            this.dpNgaySinh.EditValue = null;
            this.dpNgaySinh.Location = new System.Drawing.Point(109, 214);
            this.dpNgaySinh.Name = "dpNgaySinh";
            this.dpNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpNgaySinh.Size = new System.Drawing.Size(195, 20);
            this.dpNgaySinh.TabIndex = 28;
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(218, 361);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(77, 28);
            this.btnHuy.TabIndex = 27;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(121, 361);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(70, 28);
            this.btnLuu.TabIndex = 26;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(109, 142);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(195, 20);
            this.txtUser.TabIndex = 20;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(109, 70);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(195, 20);
            this.txtMaNV.TabIndex = 25;
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.Location = new System.Drawing.Point(20, 253);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(38, 13);
            this.lbGioiTinh.TabIndex = 18;
            this.lbGioiTinh.Text = "Giới tính";
            // 
            // lbUserName
            // 
            this.lbUserName.Location = new System.Drawing.Point(20, 145);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(51, 13);
            this.lbUserName.TabIndex = 17;
            this.lbUserName.Text = "User name";
            // 
            // lbEmail
            // 
            this.lbEmail.Location = new System.Drawing.Point(22, 325);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(24, 13);
            this.lbEmail.TabIndex = 12;
            this.lbEmail.Text = "Email";
            // 
            // lnMaNV
            // 
            this.lnMaNV.Location = new System.Drawing.Point(20, 73);
            this.lnMaNV.Name = "lnMaNV";
            this.lnMaNV.Size = new System.Drawing.Size(64, 13);
            this.lnMaNV.TabIndex = 15;
            this.lnMaNV.Text = "Mã nhân viên";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(109, 321);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(195, 20);
            this.txtEmail.TabIndex = 21;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(109, 285);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(195, 20);
            this.txtDiaChi.TabIndex = 22;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(109, 178);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(195, 20);
            this.txtPass.TabIndex = 23;
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.Location = new System.Drawing.Point(20, 217);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(47, 13);
            this.lbNgaySinh.TabIndex = 14;
            this.lbNgaySinh.Text = "Ngày sinh";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(109, 106);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(195, 20);
            this.txtTenNV.TabIndex = 24;
            // 
            // lbPassword
            // 
            this.lbPassword.Location = new System.Drawing.Point(20, 181);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(46, 13);
            this.lbPassword.TabIndex = 13;
            this.lbPassword.Text = "Password";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.Location = new System.Drawing.Point(22, 289);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(36, 13);
            this.lbDiaChi.TabIndex = 16;
            this.lbDiaChi.Text = "Địa chỉ:";
            // 
            // lbTenNV
            // 
            this.lbTenNV.Location = new System.Drawing.Point(20, 109);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(68, 13);
            this.lbTenNV.TabIndex = 19;
            this.lbTenNV.Text = "Tên nhân viên";
            // 
            // FrmThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 417);
            this.Controls.Add(this.chkNu);
            this.Controls.Add(this.chkNam);
            this.Controls.Add(this.dpNgaySinh);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.lbGioiTinh);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lnMaNV);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lbNgaySinh);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbTenNV);
            this.Controls.Add(this.labelControl2);
            this.Name = "FrmThemNhanVien";
            this.Text = "Thêm nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.chkNu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit chkNu;
        private DevExpress.XtraEditors.CheckEdit chkNam;
        private DevExpress.XtraEditors.DateEdit dpNgaySinh;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraEditors.LabelControl lbGioiTinh;
        private DevExpress.XtraEditors.LabelControl lbUserName;
        private DevExpress.XtraEditors.LabelControl lbEmail;
        private DevExpress.XtraEditors.LabelControl lnMaNV;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.LabelControl lbNgaySinh;
        private DevExpress.XtraEditors.TextEdit txtTenNV;
        private DevExpress.XtraEditors.LabelControl lbPassword;
        private DevExpress.XtraEditors.LabelControl lbDiaChi;
        private DevExpress.XtraEditors.LabelControl lbTenNV;
    }
}