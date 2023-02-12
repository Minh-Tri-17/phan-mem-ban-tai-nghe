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
using AForge.Video.DirectShow;
using ZXing.Presentation;
using AForge.Video;
using ZXing;
using DACS2.DAO;

namespace DACS2
{
    public partial class FormNhanVien : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice VideoCaptureDevice;

        string query;

        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void XulyDgvNV()
        {
            dgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvNV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvNV.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            dgvNV.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 15);
            dgvNV.EnableHeadersVisualStyles = false;
            dgvNV.BorderStyle = BorderStyle.None;

            dgvNV.BackgroundColor = Color.FromArgb(229, 221, 209);
            dgvNV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNV.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(68, 56, 38);
            dgvNV.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(147, 128, 105);
            dgvNV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(147, 128, 105);
            dgvNV.DefaultCellStyle.BackColor = Color.FromArgb(229, 221, 209);
            dgvNV.DefaultCellStyle.SelectionForeColor = Color.FromArgb(211, 204, 188);
            dgvNV.DefaultCellStyle.SelectionBackColor = Color.FromArgb(68, 56, 38);
            dgvNV.DefaultCellStyle.ForeColor = Color.FromArgb(68, 56, 38);

            dgvNV.Columns[0].Visible = false;
            dgvNV.Columns[1].HeaderText = "Tên nhân viên";
            dgvNV.Columns[2].HeaderText = "Số điện thoại";
            dgvNV.Columns[3].HeaderText = "Chức vụ";
            dgvNV.Columns[4].HeaderText = "Số ngày làm";
            dgvNV.Columns[5].HeaderText = "Hệ số lương";
            dgvNV.Columns[6].HeaderText = "Tổng lương";
        }

        private void TinhTong()
        {
            query = string.Format("update NHAN_VIEN set TONGLUONG = NGAY*HSL");
            DataProvider.Instance.ExecuteNonQuery(query);
            LoadNV();
        }

        private void LoadNV()
        {
            query = "select * from NHAN_VIEN ";
            
            dgvNV.DataSource = DataProvider.Instance.ExecuteQuery(query);
            XulyDgvNV();
            //Xử lý textbox nhân viên
            txtTNV.DataBindings.Clear();
            txtTNV.DataBindings.Add("Text", dgvNV.DataSource, "TENNV");
            txtMNV.DataBindings.Clear();
            txtMNV.DataBindings.Add("Text", dgvNV.DataSource, "MANV");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvNV.DataSource, "SDT");
            txtCV.DataBindings.Clear();
            txtCV.DataBindings.Add("Text", dgvNV.DataSource, "CHUCVU");
            txtHSL.DataBindings.Clear();
            txtHSL.DataBindings.Add("Text", dgvNV.DataSource, "HSL");
        }

        private void LoadCbx()
        {
            LoadCbxCV();
            LoadCbxMAL();
        }

        private void LoadCbxCV()
        {
            query = "select distinct CHUCVU from NHAN_VIEN";
            
            cbxSCV.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cbxSCV.DisplayMember = "CHUCVU";
            cbxSCV.Text = "";
        }

        private void LoadCbxMAL()
        {
            query = "select distinct HSL from NHAN_VIEN";
            
            cbxSHSL.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cbxSHSL.DisplayMember = "HSL";
            cbxSHSL.Text = "";
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadNV();
            TinhTong();
            LoadCbx();
            QuetMa();
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            query = string.Format("EXEC DBO.CHECKTONTAI @a = '{0}'", txtSDT.Text);
            int a = Int32.Parse(DataProvider.Instance.ExecuteScalar(query).ToString());
            if (a == 1)
            {
                MessageBox.Show("Nhân viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(a == 0)
            {
              string  query1 = string.Format("insert into NHAN_VIEN(TENNV, SDT, CHUCVU, HSL) values(N'{0}',{1} ,N'{2}',{3})",
              txtTNV.Text, Int32.Parse(txtSDT.Text), txtCV.Text, Int32.Parse(txtHSL.Text));

                try
                {
                    DataProvider.Instance.ExecuteNonQuery(query1);
                    MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNV();
                }
                catch
                {
                    MessageBox.Show("Thêm nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cbxSCV_Click(object sender, EventArgs e)
        {
            cbxSHSL.Text = "";
            LoadCbxCV();
        }

        private void cbxSML_Click(object sender, EventArgs e)
        {
            cbxSCV.Text = "";
            LoadCbxMAL();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            query = string.Format("delete from NHAN_VIEN where MANV = {0}", Int16.Parse(txtMNV.Text));
            
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNV();
            }
            catch
            {
                MessageBox.Show("Xóa nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            query = string.Format("update NHAN_VIEN set TENNV = N'{0}', SDT = {1}, CHUCVU = N'{2}', HSL = {3} where MANV = {4}",
               txtTNV.Text, Int32.Parse(txtSDT.Text), txtCV.Text, Int32.Parse(txtHSL.Text), Int32.Parse(txtMNV.Text)); 
            
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show("Sửa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNV();
                TinhTong();
            }
            catch
            {
                MessageBox.Show("Sửa nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            query = string.Format("select * from NHAN_VIEN where CHUCVU = N'{0}' or HSL = '{1}'", cbxSCV.Text, cbxSHSL.Text);
            
            dgvNV.DataSource = DataProvider.Instance.ExecuteQuery(query);

            if (cbxSCV.Text == "" && cbxSHSL.Text == "")
            {
                LoadNV();
            }
        }

        private void ChamCong()
        {
            if (txtNVFT.Text != "")
            {
                query = string.Format("update NHAN_VIEN set NGAY = NGAY + 1 where NHAN_VIEN.MANV = {0} and NGAY < 30", Int32.Parse(txtNVFT.Text));

                DataProvider.Instance.ExecuteNonQuery(query);
                LoadNV();
            }
        }

        private void txtNVFT_TextChanged(object sender, EventArgs e)
        {
            ChamCong();
        }

        private void QuetMa()
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cmbCR.Items.Add(filterInfo.Name);
            cmbCR.SelectedIndex = 0;
            VideoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cmbCR.SelectedIndex].MonikerString);
            VideoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            VideoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            ZXing.BarcodeReader reader = new ZXing.BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                txtNVFT.Invoke(new MethodInvoker(delegate ()
                {
                    txtNVFT.Text = result.ToString();
                }));
            }
        }

        private void FormNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (VideoCaptureDevice != null)
            {
                if (VideoCaptureDevice.IsRunning)
                    VideoCaptureDevice.Stop();
            }
        }

        private void btnTCR_Click(object sender, EventArgs e)
        {
            if (VideoCaptureDevice != null)
            {
                if (VideoCaptureDevice.IsRunning)
                    VideoCaptureDevice.Stop();
            }
            txtNVFT.Clear();
        }
    }
}
