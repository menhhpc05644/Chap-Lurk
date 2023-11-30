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
    public partial class giaodienchinh : Form
    {
        public giaodienchinh()
        {
            InitializeComponent();
        }
        public giaodienchinh(String username)
        {
            InitializeComponent();
        }

        private void btgoimon_Click(object sender, EventArgs e)
        {
            goimon form2 = new goimon();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void btdangxuat_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void btlaphoadon_Click(object sender, EventArgs e)
        {
            laphoadon2 form2 = new laphoadon2();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }
    }
}
