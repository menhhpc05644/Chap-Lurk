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
    public partial class laphoadon2 : Form
    {
        public laphoadon2()
        {
            InitializeComponent();
        }

        private void cbbbanan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bttrangchu_Click(object sender, EventArgs e)
        {
            giaodienchinh form2 = new giaodienchinh();
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

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void laphoadon2_Load(object sender, EventArgs e)
        {
            using (DUAN1lamlaiEntities BD = new DUAN1lamlaiEntities())
            {
                var cba = BD.BanAns.Select(a => a.MaBanAn);
                foreach (var item in cba)
                {
                    cbbbanan.Items.Add(item);
                }

                var ban = BD.NhanViens.Select(a => a.Hoten);
                foreach (var item in ban) // Sử dụng biến ban để lấy dữ liệu từ BD.BanAns
                {
                    cbbnguoilap.Items.Add(item);
                }


                //updateDataGv();
            }
        }
        private goimon formAInstance;
        public laphoadon2(goimon formA)
        {
            InitializeComponent();
            formAInstance = formA; // Lưu trữ tham chiếu đến instance của Form A
        }

        public void DisplayDataFromFormA()
        {
            if (formAInstance != null)
            {
                // Lấy dữ liệu từ ListView trong Form A
                ListView listViewFormA = formAInstance.GetDataListView();

                // Hiển thị dữ liệu từ ListView của Form A vào ListView của Form B
                foreach (ListViewItem item in listViewFormA.Items)
                {
                    lvdanhsach.Items.Add((ListViewItem)item.Clone());
                }
            }
            else
            {
                MessageBox.Show("Không thể truy cập dữ liệu từ Form A.");
            }
        }
        private void btong_Click(object sender, EventArgs e)
        {

            int tong = 0;

            foreach (ListViewItem item in lvdanhsach.Items)
            {
                int giaTri;
                int soluong;
                int.TryParse(item.SubItems[3].Text, out giaTri);
                int.TryParse(item.SubItems[4].Text, out soluong);

                tong += giaTri * soluong;

            }
            txttong.Text = tong.ToString(); // Đổ tổng vào TextBox
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayDataFromFormA();
        }
    }
}
