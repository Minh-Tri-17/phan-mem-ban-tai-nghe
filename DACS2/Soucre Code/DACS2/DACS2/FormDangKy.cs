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
using System.Text.RegularExpressions;
using DACS2.DAO;

namespace DACS2
{
    public partial class FormDangKy : Form
    {
        string query;

        public FormDangKy()
        {
            InitializeComponent();
        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {
            
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Thông báo", "Bạn có chắc muốn thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (h == DialogResult.OK)
            {
                this.Close();
            }
        }

        private bool CheckAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-z,A-Z,0-9]{8,24}$");
        }

        private bool CheckEmail(string e)
        {
            return Regex.IsMatch(e, @"^[a-z,A-Z,0-9]@gmail.com{8,24}$");
        }

        private bool CheckPhone(string p)
        {
            return Regex.IsMatch(p, "^[0-9]{10}$");
        }

        private bool Check()
        {
            bool check = true;
            if (!CheckEmail(txtE.Text) && !CheckAccount(txtMK.Text) && !CheckAccount(txtTDN.Text) && !CheckPhone(txtSDT.Text))
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                query = string.Format("insert into DANG_NHAP values('{0}','{1}','{2}','{3}')", txtTDN.Text, txtMK.Text, txtSDT.Text, txtE.Text);

                try
                {
                    if (txtTDN.Text != "" && txtSDT.Text != "" && txtMK.Text != "" && txtE.Text != "")
                    {
                        DataProvider.Instance.ExecuteNonQuery(query);
                        MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTDN_Click(object sender, EventArgs e)
        {
            if (txtTDN.Text == "Tên đăng nhập")
            {
                txtTDN.Text = "";
            }
        }

        private void txtMK_Click(object sender, EventArgs e)
        {
            if (txtMK.Text == "Mật khẩu")
            {
                txtMK.Text = "";
            }
        }

        private void txtSDT_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text == "Số điện thoại")
            {
                txtSDT.Text = "";
            }
        }

        private void txtE_Click(object sender, EventArgs e)
        {
            if (txtE.Text == "Email")
            {
                txtE.Text = "";
            }
        }

        private void txtTDN_Leave(object sender, EventArgs e)
        {
            if (txtTDN.Text == "")
            {
                txtTDN.Text = "Tên đăng nhập";
            }
        }

        private void txtMK_Leave(object sender, EventArgs e)
        {
            if (txtMK.Text == "")
            {
                txtMK.Text = "Mật khẩu";
            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.Text == "")
            {
                txtSDT.Text = "Số điện thoại";
            }
        }

        private void txtE_Leave(object sender, EventArgs e)
        {
            if (txtE.Text == "")
            {
                txtE.Text = "Email";
            }
        }
    }
}
