﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACS2
{
    public partial class FormInNhapHang : Form
    {
        public FormInNhapHang()
        {
            InitializeComponent();
        }

        private void FormInNhapHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DACS2DataSet1.INNHAPHANG' table. You can move, or remove it, as needed.
            this.INNHAPHANGTableAdapter.Fill(this.DACS2DataSet1.INNHAPHANG);

            this.reportViewer1.RefreshReport();
        }
    }
}
