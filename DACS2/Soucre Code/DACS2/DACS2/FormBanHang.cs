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
using AForge.Video;
using ZXing;
using DACS2.DAO;

namespace DACS2
{
    public partial class FormBanHang : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice VideoCaptureDevice;

        DataTable Dt = new DataTable();
        string query;

        public FormBanHang()
        {
            InitializeComponent();
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            LoadBH();
            TinhTongTien();
            QuetMa();
        }

        private void FormBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (VideoCaptureDevice != null)
            {
                if (VideoCaptureDevice.IsRunning)
                    VideoCaptureDevice.Stop();
            }
        }

        private void TinhTongTien()
        {
            int sc = dgvBH.Rows.Count;
            int thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += int.Parse(dgvBH.Rows[i].Cells["THANHTIEN"].Value.ToString());
            txtTT.Text = string.Format("{0:#,##0.##}", Int32.Parse(thanhtien.ToString())) + "  VNĐ";
        }

        private void XulyDgvBH()
        {
            dgvBH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBH.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBH.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            dgvBH.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 15);
            dgvBH.EnableHeadersVisualStyles = false;
            dgvBH.BorderStyle = BorderStyle.None;

            dgvBH.BackgroundColor = Color.FromArgb(229, 221, 209);
            dgvBH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBH.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(68, 56, 38);
            dgvBH.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(147, 128, 105);
            dgvBH.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(147, 128, 105);
            dgvBH.DefaultCellStyle.BackColor = Color.FromArgb(229, 221, 209);
            dgvBH.DefaultCellStyle.SelectionForeColor = Color.FromArgb(211, 204, 188);
            dgvBH.DefaultCellStyle.SelectionBackColor = Color.FromArgb(68, 56, 38);
            dgvBH.DefaultCellStyle.ForeColor = Color.FromArgb(68, 56, 38);

            dgvBH.Columns[0].HeaderText = "Mã bán hàng";
            dgvBH.Columns[1].HeaderText = "Tên sản phẩm";
            dgvBH.Columns[1].Width = 300;
            dgvBH.Columns[2].HeaderText = "Màu";
            dgvBH.Columns[3].HeaderText = "Size";
            dgvBH.Columns[4].HeaderText = "Giá";
            dgvBH.Columns[5].HeaderText = "Giảm giá";
            dgvBH.Columns[6].HeaderText = "Số lượng";
            dgvBH.Columns[7].HeaderText = "Thành tiền";
        }

        private void LoadBH()
        {
            query = "select MABH, TENSP, MAU, SIZE, GIA, SOGG, SOLUONG, THANHTIEN from BAN_HANG, SAN_PHAM, GIAM_GIA where BAN_HANG.MASP = SAN_PHAM.MASP and GIAM_GIA.MAGG = SAN_PHAM.MAGG";

            dgvBH.DataSource = DataProvider.Instance.ExecuteQuery(query);
            XulyDgvBH();

            txtMBH.DataBindings.Clear();
            txtMBH.DataBindings.Add("Text", dgvBH.DataSource, "MABH");

        }

        private void btnXSP_Click(object sender, EventArgs e)
        {
            if (txtMSP.Text != "")
            {
                query = string.Format("delete from BAN_HANG where MABH = {0}", Int16.Parse(txtMBH.Text));

                try
                {
                    DataProvider.Instance.ExecuteNonQuery(query);
                    MessageBox.Show("Xóa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormBanHang_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Xóa sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Xóa sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTSL_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSL.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string query2 = string.Format("exec dbo.THEMSOLUONG @masp = {0}, @sl = {1}", txtMSP.Text, txtSL.Text);

                    DataProvider.Instance.ExecuteNonQuery(query2);
                    txtSL.Text = "";
                    LoadBH();
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMSP_TextChanged(object sender, EventArgs e)
        {
            if (txtMSP.Text != "")
            {
                query = string.Format("EXEC dbo.THEMSANPHAM @masp = {0}", txtMSP.Text);

                DataProvider.Instance.ExecuteNonQuery(query);
            }
            else
            {
                MessageBox.Show("Lỗi mã vạch", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            FormBanHang_Load(sender, e);
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
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                txtMSP.Invoke(new MethodInvoker(delegate ()
                {
                    txtMSP.Text = result.ToString();
                }));
            }
        }

        private void XoaBanHang()
        {
            query = "delete BAN_HANG";

            DataProvider.Instance.ExecuteNonQuery(query);
            LoadBH();
        }

        private void ThemHoaDon()
        {
            query = "select max(MAHD) from HOA_DON";

            string c = DataProvider.Instance.ExecuteScalar(query).ToString();
            int a = 1;
            if (c == "")
            {
                string query1 = string.Format("insert into HOA_DON(MAHD) values({0})", a);

                DataProvider.Instance.ExecuteNonQuery(query1);
            }
            else
            {
                string query2 = string.Format("insert into HOA_DON(MAHD) values({0})", Int32.Parse(c) + 1);

                DataProvider.Instance.ExecuteNonQuery(query2);
            }
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            if (txtMBH.Text != "")
            {
                ThemHoaDon();
                query = "select MASP, SOLUONG, THANHTIEN from BAN_HANG";
                string query1 = "select max(MAHD) from HOA_DON";
                string query2 = "update SAN_PHAM set SLTON = SLTON - BAN_HANG.SOLUONG " +
                                 "from BAN_HANG, SAN_PHAM " +
                                 "where BAN_HANG.MASP = SAN_PHAM.MASP";
                Dt = DataProvider.Instance.ExecuteQuery(query);
                int a = Int32.Parse(DataProvider.Instance.ExecuteScalar(query1).ToString());
                try
                {
                    DataProvider.Instance.ExecuteNonQuery(query2);
                    foreach (DataRow i in Dt.Rows)
                    {
                        string query3 = string.Format("insert into CHI_TIET_HOA_DON (MASP, SOLUONG, THANHTIEN, MAHD) values({0},{1},{2},{3})", i["MASP"].ToString(), i["SOLUONG"].ToString(), i["THANHTIEN"].ToString(), a);

                        DataProvider.Instance.ExecuteNonQuery(query3);
                    }
                    MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    XoaBanHang();
                    txtMBH.Clear();
                }
                catch
                {
                    MessageBox.Show("Thanh toán thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            
        }

        private void btnCMR_Click(object sender, EventArgs e)
        {
            if (VideoCaptureDevice != null)
            {
                if (VideoCaptureDevice.IsRunning)
                    VideoCaptureDevice.Stop();
            }
        }
    }
}
