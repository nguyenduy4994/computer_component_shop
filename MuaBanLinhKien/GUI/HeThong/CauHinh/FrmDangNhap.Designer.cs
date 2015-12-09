namespace GUI.HeThong.CauHinh
{
    partial class FrmDangNhap
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
            this.com_login = new DangNhap.Login();
            this.SuspendLayout();
            // 
            // com_login
            // 
            this.com_login.Location = new System.Drawing.Point(12, 12);
            this.com_login.Name = "com_login";
            this.com_login.Size = new System.Drawing.Size(326, 159);
            this.com_login.TabIndex = 3;
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 168);
            this.Controls.Add(this.com_login);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDangNhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frm_dangNhap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DangNhap.Login com_login;

    }
}