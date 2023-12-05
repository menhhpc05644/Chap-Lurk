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
    public partial class laphoadon2 : Form
    {
        private Dictionary<string, List<string>> dataDictionary = new Dictionary<string, List<string>>();
        private PrintDocument printDocument1 = new PrintDocument();
        public laphoadon2()
        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }

       



        private void cbbbanan_SelectedIndexChanged(object sender, EventArgs e)
        {

            string chonban = cbbbanan.SelectedItem.ToString().Trim();
            string filePath = ""; // Khai báo biến filePath ở ngoài các khối if-else để sử dụng ở bên dưới

            if (chonban.Equals("B01"))
            {
                filePath = "D:/1DUAN1/CODE/ban01.txt";
            }
            else if (chonban.Equals("B02"))
            {
                filePath = "D:/1DUAN1/CODE/ban02.txt";
            }
            else if (chonban.Equals("B03"))
            {
                filePath = "D:/1DUAN1/CODE/ban03.txt";
            }
            else
            {
                filePath = "D:/1DUAN1/CODE/data.txt"; // Nếu không phù hợp với các điều kiện trên, sử dụng đường dẫn mặc định
            }

            // Gọi hàm LoadDataToListView để đổ dữ liệu từ tệp tin đã chọn vào ListView khác
            LoadDataToListView(filePath, lvdanhsach); //
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

        private void LoadDataToListView(string filePath, ListView targetListView)
        {
            try
            {
                // Xóa dữ liệu cũ trong ListView trước khi load dữ liệu mới
                targetListView.Items.Clear();

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Thêm dòng dữ liệu vào ListView
                        targetListView.Items.Add(new ListViewItem(line.Split('\t'))); // Sử dụng ký tự phân cách (ví dụ: tab) để tách giá trị trong dòng
                    }
                }
                MessageBox.Show("Dữ liệu đã được tải vào ListView.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12, FontStyle.Regular);
            float fontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;

            // Vẽ từng cột dữ liệu từ ListView
            int offsetX = startX;
            foreach (ColumnHeader column in lvdanhsach.Columns)
            {
                e.Graphics.DrawString(column.Text, font, Brushes.Black, offsetX, startY);
                offsetX += 100; // Điều chỉnh khoảng cách giữa các cột
            }

            // Vẽ dữ liệu từng cột theo từng dòng trong ListView
            int offsetY = (int)fontHeight + 10;
            foreach (ListViewItem item in lvdanhsach.Items)
            {
                offsetX = startX;
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    e.Graphics.DrawString(subItem.Text, font, Brushes.Black, offsetX, startY + offsetY);
                    offsetX += 100; // Điều chỉnh khoảng cách giữa các cột
                }
                offsetY += (int)fontHeight + 5;
            }
            string headerText = "HÓA ĐƠN";
            SizeF textSize = e.Graphics.MeasureString(headerText, font);
            int centerX = (e.PageBounds.Width - (int)textSize.Width) / 2;
            e.Graphics.DrawString(headerText, font, Brushes.Black, centerX, startY);

            // Vẽ thông tin từ ComboBox
            string selectedComboBoxItem = cbbnguoilap.SelectedItem?.ToString();
            e.Graphics.DrawString("Người Lập: " + selectedComboBoxItem, font, Brushes.Black, startX, startY + 500);

            // Vẽ thông tin từ TextBox
            string textBoxValue = txttong.Text;
            e.Graphics.DrawString("Tổng tiền: " + textBoxValue, font, Brushes.Black, startX, startY + 520);

            // Vẽ thông tin từ DateTimePicker
            string selectedDate = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            e.Graphics.DrawString("Ngày lập: " + selectedDate, font, Brushes.Black, startX, startY + 540);
        }

        private void btlaphoadon_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }





        private void SaveDataToDatabase()
        {
          /*  try
            {
                string connectionString = "Your_Connection_String"; // Thay thế chuỗi kết nối với cơ sở dữ liệu của bạn

                using (DUAN1lamlaiEntities connection = new DUAN1lamlaiEntities(connectionString))
                {
                    connection.Open();

                    foreach (ListViewItem item in lvdanhsach.Items)
                    {
                        // Lấy dữ liệu từ các cột trong mỗi dòng của ListView
                        string column1Value = item.SubItems[0].Text; // Thay [0], [1],... bằng số thứ tự của cột tương ứng
                        string column2Value = item.SubItems[1].Text;
                        // ...

                        // Tạo câu lệnh SQL để chèn dữ liệu vào cơ sở dữ liệu
                        string query = "INSERT INTO HoaDon (MaBanAn, SoKhach, TongTien) VALUES (@value1, @value2)";
                        // Thay thế TenBang và TenCot1, TenCot2 với tên bảng và các cột tương ứng của bạn

                        DUAN1lamlaiEntities command = new DUAN1lamlaiEntities(query, connection);
                        command.Parameters.AddWithValue("@value1", column1Value);
                        command.Parameters.AddWithValue("@value2", column2Value);
                        // ...

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Dữ liệu đã được lưu vào cơ sở dữ liệu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lưu dữ liệu: " + ex.Message);
            }*/
        }
    }
}
