namespace GUI.HeThong.CauHinh
{
    partial class FrmCauHinh
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
            this.com_cauHinh = new DangNhap.cauHinh();
            this.SuspendLayout();
            // 
            // com_cauHinh
            // 
            this.com_cauHinh.Location = new System.Drawing.Point(13, 13);
            this.com_cauHinh.Name = "com_cauHinh";
            this.com_cauHinh.Size = new System.Drawing.Size(293, 220);
            this.com_cauHinh.TabIndex = 0;
            // 
            // FrmCauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 244);
            this.Controls.Add(this.com_cauHinh);
            this.Name = "FrmCauHinh";
            this.Text = "Cấu hình";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_cauHinh_FormClosed);
            this.Load += new System.EventHandler(this.frm_cauHinh_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DangNhap.cauHinh com_cauHinh;

    }
}