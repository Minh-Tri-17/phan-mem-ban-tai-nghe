using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DACS2.DAO;

namespace DACS2
{
    public partial class FormQuanLy : Form
    {
        public FormQuanLy()
        {
            InitializeComponent();
        }

        private void FormQuanLy_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private Form CurrentFormchild;

        private void OpenChildForm(Form ChildForm)
        {            
            CurrentFormchild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.Dock = DockStyle.Fill;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            panelBody.Controls.Add(ChildForm);
            panelBody.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btnBH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBanHang());
            label1.Text = btnBH.Text;
        }

        private void btnNH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhapHang());
            label1.Text = btnNH.Text;
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhanVien());
            label1.Text = btnNV.Text;
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormKho());
            label1.Text = btnTK.Text;
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormKhachHang());
            label1.Text = btnKH.Text;
        }
    }
}
