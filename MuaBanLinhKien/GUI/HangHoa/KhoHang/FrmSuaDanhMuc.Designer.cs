﻿namespace GUI.HangHoa.KhoHang
{
    partial class FrmSuaDanhMuc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSuaDanhMuc));
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenDanhMuc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaDanhMuc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lkDanhMucCha = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btnNull = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMoTa = new DevExpress.XtraEditors.MemoEdit();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDanhMuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDanhMuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkDanhMucCha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(264, 205);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu";
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Location = new System.Drawing.Point(345, 205);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 16;
            this.btnHuy.Text = "Hủy";
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoryBindingSource, "name", true));
            this.txtTenDanhMuc.Location = new System.Drawing.Point(105, 87);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(315, 20);
            this.txtTenDanhMuc.TabIndex = 11;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 182);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Danh mục cha:";
            // 
            // txtMaDanhMuc
            // 
            this.txtMaDanhMuc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoryBindingSource, "cat_id", true));
            this.txtMaDanhMuc.Location = new System.Drawing.Point(105, 61);
            this.txtMaDanhMuc.Name = "txtMaDanhMuc";
            this.txtMaDanhMuc.Size = new System.Drawing.Size(315, 20);
            this.txtMaDanhMuc.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 90);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Tên danh mục:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl2.Appearance.Image")));
            this.labelControl2.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl2.Location = new System.Drawing.Point(0, 0);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Padding = new System.Windows.Forms.Padding(10);
            this.labelControl2.Size = new System.Drawing.Size(433, 50);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Sửa danh mục";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 64);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Mã danh mục:";
            // 
            // lkDanhMucCha
            // 
            this.lkDanhMucCha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoryBindingSource, "category1", true));
            this.lkDanhMucCha.Location = new System.Drawing.Point(105, 179);
            this.lkDanhMucCha.Name = "lkDanhMucCha";
            this.lkDanhMucCha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkDanhMucCha.Properties.DisplayMember = "name";
            this.lkDanhMucCha.Properties.NullText = "Chọn danh mục cha";
            this.lkDanhMucCha.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this.lkDanhMucCha.Size = new System.Drawing.Size(283, 20);
            this.lkDanhMucCha.TabIndex = 14;
            // 
            // treeListLookUpEdit1TreeList
            // 
            this.treeListLookUpEdit1TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn2});
            this.treeListLookUpEdit1TreeList.KeyFieldName = "cat_id";
            this.treeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 5);
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
            // btnNull
            // 
            this.btnNull.Image = ((System.Drawing.Image)(resources.GetObject("btnNull.Image")));
            this.btnNull.Location = new System.Drawing.Point(394, 177);
            this.btnNull.Name = "btnNull";
            this.btnNull.Size = new System.Drawing.Size(24, 24);
            this.btnNull.TabIndex = 17;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 116);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Mô tả:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoryBindingSource, "describe", true));
            this.txtMoTa.Location = new System.Drawing.Point(105, 113);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(315, 60);
            this.txtMoTa.TabIndex = 13;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(DAL.category);
            // 
            // FrmSuaDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 232);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.txtTenDanhMuc);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtMaDanhMuc);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lkDanhMucCha);
            this.Controls.Add(this.btnNull);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtMoTa);
            this.Name = "FrmSuaDanhMuc";
            this.Text = "Sửa danh mục";
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDanhMuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDanhMuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkDanhMucCha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.TextEdit txtTenDanhMuc;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtMaDanhMuc;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TreeListLookUpEdit lkDanhMucCha;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraEditors.SimpleButton btnNull;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.MemoEdit txtMoTa;
        private System.Windows.Forms.BindingSource categoryBindingSource;

    }
}