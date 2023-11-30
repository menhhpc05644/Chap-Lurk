using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtuser.Text)
              || String.IsNullOrWhiteSpace(txtuser.Text)
              || String.IsNullOrEmpty(txtpass.Text)
              || String.IsNullOrWhiteSpace(txtpass.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập đủ tài khoản và mật khẩu",
                    "Lỗi nhập liệu",
                    MessageBoxButtons.OK,   
                    MessageBoxIcon.Error
                );
            }
            else
            {
                String role = cl1.Login(txtuser.Text, txtpass.Text);
                if (!String.IsNullOrEmpty(role))
                {
                    /*if (checkBox1.Checked)
                    {
                        Properties.Settings.Default.Username_Remember = txtUsername.Text;
                        Properties.Settings.Default.Password_Remember = txtPassword.Text;
                    }*/
                    if (role.Equals("Admin"))
                    {
                        this.Hide();
                        giaodienchinh form = new giaodienchinh(txtuser.Text);
                        form.ShowDialog();
                        this.Close();
                    }
                    else if (role.Equals("Nhân viên"))
                    {
                        /*this.Hide();
                        quanly form = new quanly(txtusername.Text);
                        form.ShowDialog();
                        this.Close();*/
                    }
                    else
                    {
                        MessageBox.Show(
                            "Tài khoản chưa được cấp quyền",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Tài khoản hoặc mật khẩu chưa đúng",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void cbhienpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbhienpass.Checked)
            {
                txtpass.PasswordChar = '\0';
            }
            else
            {
                txtpass.PasswordChar = '*';
            }
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
