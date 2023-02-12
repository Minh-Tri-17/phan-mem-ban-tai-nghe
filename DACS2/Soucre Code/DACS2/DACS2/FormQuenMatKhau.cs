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
    public partial class FormQuenMatKhau : Form
    {
        string query;
        public FormQuenMatKhau()
        {
            InitializeComponent();
        }

        private void FormQuenMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Thông báo", "Bạn có chắc muốn thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (h == DialogResult.OK)
            {
                this.Close();
            }
        }

        private bool CheckAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[/w]{8,24}$");
        }

        private void buttonCN_Click(object sender, EventArgs e)
        {
            query = string.Format("update DANG_NHAP set PASSWORD = '{0}' where USERNAME = '{1}' and  SDT = '{2}' and EMAIL = '{3}'", txtMKM.Text, txtTDN.Text, txtSDT.Text, txtE.Text);
            
                try
                {
                    if (txtTDN.Text != "Tên đăng nhập" && txtSDT.Text != "Số điện thoại" && !CheckAccount(txtMKM.Text) && txtE.Text != "Email")
                    {
                        DataProvider.Instance.ExecuteNonQuery(query);
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        private void txtTDN_Click(object sender, EventArgs e)
        {
            if(txtTDN.Text == "Tên đăng nhập")
            {
                txtTDN.Text = "";
            }
        }

        private void txtSDT_Click(object sender, EventArgs e)
        {
            if(txtSDT.Text == "Số điện thoại")
            {
                txtSDT.Text = "";
            }
        }

        private void txtE_Click(object sender, EventArgs e)
        {
            if(txtE.Text == "Email")
            {
                txtE.Text = "";
            }
        }

        private void txtMKM_Click(object sender, EventArgs e)
        {
            if(txtMKM.Text == "Mật khẩu mới")
            {
                txtMKM.Text = "";
            }
        }

        private void txtTDN_Leave(object sender, EventArgs e)
        {
            if (txtTDN.Text == "")
            {
                txtTDN.Text = "Tên đăng nhập";
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

        private void txtMKM_Leave(object sender, EventArgs e)
        {
            if (txtMKM.Text == "")
            {
                txtMKM.Text = "Mật khẩu mới";
            }
        }
    }
}
