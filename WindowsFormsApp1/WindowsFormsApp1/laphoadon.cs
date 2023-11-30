using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class laphoadon : Form
    {
        //private PrintDocument printDocument = new PrintDocument();
        //  private PrintDialog printDialog = new PrintDialog();


        public laphoadon()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear(); // Xóa dữ liệu cũ trong ListView trước khi tải dữ liệu mới

                using (StreamReader sr = new StreamReader("ListViewData.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] values = line.Split(','); // Tách dữ liệu theo dấu phẩy để lấy các giá trị

                        // Tạo một ListViewItem mới và thêm vào listView1
                        ListViewItem newItem = new ListViewItem(values[0]);
                        for (int i = 1; i < values.Length; i++)
                        {
                            newItem.SubItems.Add(values[i]);
                        }
                        listView1.Items.Add(newItem);
                    }
                }

                MessageBox.Show("Dữ liệu đã được tải vào ListView.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbchonban_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbchonban.SelectedItem != null)
            {
                string selectedForeignKey = cbbchonban.SelectedItem.ToString();

                // Gọi hàm để lấy dữ liệu từ cơ sở dữ liệu với khóa ngoại đã chọn
                // Trong trường hợp này, giả sử sử dụng một phương thức GetForeignKeyDataFromDatabase để lấy dữ liệu
                string data = GetForeignKeyDataFromDatabase(selectedForeignKey);

                // Hiển thị dữ liệu đã lấy được từ cơ sở dữ liệu
                MessageBox.Show("Dữ liệu từ khóa ngoại " + selectedForeignKey + " là: " + data);
            }

        }
        private string GetForeignKeyDataFromDatabase(string selectedForeignKey)
        {
            string data = ""; // Biến để lưu dữ liệu từ cơ sở dữ liệu

            // Thực hiện truy vấn cơ sở dữ liệu để lấy dữ liệu tương ứng với khóa ngoại đã chọn
            // Viết mã để truy vấn cơ sở dữ liệu và lấy dữ liệu với khóa ngoại là selectedForeignKey
            // Gán dữ liệu lấy được vào biến data

            return data; // Trả về dữ liệu từ cơ sở dữ liệu
        }


        private void laphoadon_Load(object sender, EventArgs e)
        {
            using (DUAN1lamlaiEntities BD = new DUAN1lamlaiEntities())
            {
                var cba = BD.BanAns.Select(a => a.MaBanAn);
                foreach (var item in cba)
                {
                    cbbchonban.Items.Add(item);
                }

                var ban = BD.NhanViens.Select(a => a.Hoten);
                foreach (var item in ban) // Sử dụng biến ban để lấy dữ liệu từ BD.BanAns
                {
                    cbbnhanvien.Items.Add(item);
                }
                

                //updateDataGv();
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btdangxuat_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void bttrangchu_Click(object sender, EventArgs e)
        {
            giaodienchinh form2 = new giaodienchinh();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void bttinhtien_Click(object sender, EventArgs e)
        {
            int tong = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                int giaTri;
                int soluong;
                int.TryParse(item.SubItems[3].Text, out giaTri);
                int.TryParse(item.SubItems[4].Text, out soluong);

                tong += giaTri*soluong;
                
            }
            txttong.Text = tong.ToString(); // Đổ tổng vào TextBox

        }

        private void btinhoadon_Click(object sender, EventArgs e)
        {
          /*  if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print(); // In hóa đơn khi người dùng chọn máy in và nhấn OK
            }*/
        }
       
        

       
    }
}
