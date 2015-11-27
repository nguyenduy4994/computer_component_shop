﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;

namespace GUI.HangHoa.KhoHang
{
    public partial class FrmHangHoaDanhMuc : Form
    {
        BusDanhMuc busDanhMuc;
        BusHangHoa busHangHoa;
        public FrmHangHoaDanhMuc()
        {
            InitializeComponent();

            // Initial
            busDanhMuc = BusDanhMuc.GetInstance();
            busHangHoa = BusHangHoa.GetInstance();

            // Form event
            this.Load += FrmHangHoaDanhMuc_Load;

            // Btn event
            btnDanhMucThem.Click += btnDanhMucThem_Click;
        }

        void btnDanhMucThem_Click(object sender, EventArgs e)
        {
            FrmThemDanhMuc frm = new FrmThemDanhMuc();
            frm.ShowDialog();
        }

        void FrmHangHoaDanhMuc_Load(object sender, EventArgs e)
        {
            tlDanhMuc.DataSource = busDanhMuc.GetAll();
            if (tlDanhMuc.AllNodesCount > 0)
            {
                category cat = (category)tlDanhMuc.GetDataRecordByNode(tlDanhMuc.Nodes[0]);
                dgvHangHoa.DataSource = busHangHoa.GetByCat(cat);
            }
        }
    }
}
