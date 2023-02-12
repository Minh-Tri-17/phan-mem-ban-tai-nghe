using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DACS2.DAO;

namespace DACS2
{
    public partial class FormKhachHang : Form
    {
        string query;

        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            LoadKH();
        }

        private void XulyDgvKH()
        {
            dgvKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvKH.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvKH.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            dgvKH.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 15);
            dgvKH.EnableHeadersVisualStyles = false;
            dgvKH.BorderStyle = BorderStyle.None;

            dgvKH.BackgroundColor = Color.FromArgb(229, 221, 209);
            dgvKH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvKH.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(68, 56, 38);
            dgvKH.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(147, 128, 105);
            dgvKH.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(147, 128, 105);
            dgvKH.DefaultCellStyle.BackColor = Color.FromArgb(229, 221, 209);
            dgvKH.DefaultCellStyle.SelectionForeColor = Color.FromArgb(211, 204, 188);
            dgvKH.DefaultCellStyle.SelectionBackColor = Color.FromArgb(68, 56, 38);
            dgvKH.DefaultCellStyle.ForeColor = Color.FromArgb(68, 56, 38);

            dgvKH.Columns[0].Visible = false;
            dgvKH.Columns[1].HeaderText = "Tên khách hàng";
            dgvKH.Columns[2].HeaderText = "Số điện thoại";
            dgvKH.Columns[3].HeaderText = "Địa chỉ";
            dgvKH.Columns[4].HeaderText = "Loại";
        }

        private void LoadKH()
        {
            query = "select * from KHACH_HANG";

            dgvKH.DataSource = DataProvider.Instance.ExecuteQuery(query);
            XulyDgvKH();
            //Load textbox nhập hàng
            txtMKH.DataBindings.Clear();
            txtMKH.DataBindings.Add("Text", dgvKH.DataSource, "MAKH");
            txtTKH.DataBindings.Clear();
            txtTKH.DataBindings.Add("Text", dgvKH.DataSource, "TENKH");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvKH.DataSource, "SDT");
            txtDC.DataBindings.Clear();
            txtDC.DataBindings.Add("Text", dgvKH.DataSource, "DIACHI");
        }

        private void LoadCbL()
        {
            query = "select distinct LOAI from KHACH_HANG";
            
            cbxL.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cbxL.DisplayMember = "LOAI";
        }

        private void cbxL_Click(object sender, EventArgs e)
        {
            LoadCbL();
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            query = string.Format("select * from KHACH_HANG where LOAI = N'{0}'",cbxL.Text);
            
            dgvKH.DataSource = DataProvider.Instance.ExecuteQuery(query);
            if (cbxL.Text == "")
            {
                LoadKH();
            }
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            query = string.Format("EXEC DBO.CHECKTONTAI @a = '{0}'", txtSDT.Text);
            int a = Int32.Parse(DataProvider.Instance.ExecuteScalar(query).ToString());
            if(a == 1)
            {
                MessageBox.Show("Khách hàng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(a == 0)
            {
                string query1 = string.Format("insert into KHACH_HANG values(N'{0}', '{1}', N'{2}', N'{3}')", txtTKH.Text, txtSDT.Text, txtDC.Text, cbxL.Text);

                try
                {
                    DataProvider.Instance.ExecuteQuery(query1);
                    MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormKhachHang_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Thêm khách hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btxS_Click(object sender, EventArgs e)
        {
            query = string.Format("update KHACH_HANG set TENKH = N'{0}', SDT = N'{1}', DIACHI = N'{2}', LOAI = N'{3}' where MAKH = {4}",
               txtTKH.Text, txtSDT.Text, txtDC.Text, cbxL.Text, Int32.Parse(txtMKH.Text));
            
            try
            {
                DataProvider.Instance.ExecuteQuery(query);
                MessageBox.Show("Sửa khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormKhachHang_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Sửa khách hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            query = string.Format("delete from KHACH_HANG where MAKH = {0}", Int32.Parse(txtMKH.Text));
            
            try
            {
                DataProvider.Instance.ExecuteQuery(query);
                MessageBox.Show("Xóa khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormKhachHang_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Xóa khách hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
