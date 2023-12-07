using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class goimon : Form
    {
        private DUAN1lamlaiEntities dbContext = new DUAN1lamlaiEntities(); // Khởi tạo DbContext của bạn
        public goimon()
        {
            InitializeComponent();
            TaiDuLieuVaoListView();
        }
       

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void goimon_Load(object sender, EventArgs e)
        {
            using (DUAN1lamlaiEntities BD = new DUAN1lamlaiEntities())
            {
                var cba = BD.LoaiThucDons.Select(a => a.TenLoai);
                foreach (var item in cba)
                {
                    cbbloaiTD.Items.Add(item);
                }

                var ban = BD.BanAns.Select(a => a.MaBanAn);
                foreach (var item in ban) // Sử dụng biến ban để lấy dữ liệu từ BD.BanAns
                {
                    cbbbanan.Items.Add(item);
                }
                listView2.FullRowSelect = true;

                //updateDataGv();
            }
        }

        private void cbbloaiTD_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear(); // Xóa dữ liệu cũ trong ListView trước khi thêm dữ liệu mới

            if (cbbloaiTD.SelectedItem != null) // Kiểm tra xem có loại thực đơn nào được chọn không
            {
                string selectedLoai = cbbloaiTD.SelectedItem.ToString(); // Lấy loại thực đơn được chọn từ ComboBox

                using (DUAN1lamlaiEntities BD = new DUAN1lamlaiEntities())
                {
                    var thucDons = BD.ThucDons.Where(td => td.LoaiThucDon.TenLoai == selectedLoai).ToList();
                  
                    foreach (var thucDon in thucDons)
                    {
                        ListViewItem item = new ListViewItem(thucDon.TenThucDon);
                        // Thêm các sub item cần thiết tại đây
                        listView1.Items.Add(item);
                    }

                }
            }

        }
        private void TaiDuLieuVaoListView()
        {
            try
            {
                var duLieu = dbContext.ThucDons.ToList(); // Lấy dữ liệu từ cơ sở dữ liệu bằng Entity Framework

                foreach (var thucThe in duLieu)
                {
                    ListViewItem item = new ListViewItem(thucThe.TenThucDon); // Thay "ThuocTinh1" bằng tên thực tế của các thuộc tính trong ThucTheCuaBan của bạn
                    //item.SubItems.Add(thucThe.TenThucDon); // Thêm các sub item cần thiết
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                try
                {
                    // Lặp qua từng mục đã chọn trong listView1 và thêm chúng vào listView2
                    foreach (ListViewItem selectedItem in listView1.SelectedItems)
                    {
                        if (!string.IsNullOrEmpty(cbbbanan.Text) && !string.IsNullOrEmpty(txtsonguoi.Text) &&
                            !string.IsNullOrEmpty(txtgia.Text) && !string.IsNullOrEmpty(txtsoluong.Text))
                        {
                            // Kiểm tra xem giá trị nhập vào các TextBox txtsonguoi, txtgia, txtsoluong có phải là số không
                            int soNguoi, gia, soLuong;

                            if (!int.TryParse(txtsonguoi.Text, out soNguoi) || !int.TryParse(txtgia.Text, out gia) || !int.TryParse(txtsoluong.Text, out soLuong))
                            {
                                MessageBox.Show("Vui lòng nhập số cho Số người, Giá và Số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return; // Thoát khỏi vòng lặp nếu dữ liệu không hợp lệ
                            }

                            // Tạo một ListViewItem mới từ mục đã chọn và thêm vào listView2
                            ListViewItem newItem = (ListViewItem)selectedItem.Clone();
                            newItem.SubItems.Add(cbbbanan.Text);
                            newItem.SubItems.Add(txtsonguoi.Text);
                            newItem.SubItems.Add(txtgia.Text);
                            newItem.SubItems.Add(txtsoluong.Text);
                            listView2.Items.Add(newItem);
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return; // Thoát khỏi vòng lặp nếu dữ liệu không hợp lệ
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món ăn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear(); // Xóa tất cả các mục trong ListView
        }

        private void btxoamondachon_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listView2.SelectedItems)
                {
                    listView2.Items.Remove(item); // Xóa mục đã chọn từ ListView
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void SaveDataToFile(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (ListViewItem item in listView2.Items)
                    {
                        string line = "";

                        // Lấy giá trị từ mỗi SubItem trong mỗi ListViewItem và ghép thành một dòng
                        foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                        {
                            line += subItem.Text + "\t"; // Sử dụng ký tự phân cách (ví dụ: tab) để phân tách giá trị
                        }

                        // Ghi mỗi dòng dữ liệu vào tệp tin
                        writer.WriteLine(line.Trim());
                    }
                }

                MessageBox.Show("Đã lưu gọi món.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu thất bại " + ex.Message);
            }
        }



        private void btluu_Click(object sender, EventArgs e)
        {
            if (cbbbanan.SelectedItem != null)
            {
                string chonban = cbbbanan.SelectedItem.ToString().Trim();

                if (chonban.Equals("B01"))
                {
                    SaveDataToFile("D:/1DUAN1/CODE/ban01.txt");
                }
                else if (chonban.Equals("B02"))
                {
                    SaveDataToFile("D:/1DUAN1/CODE/ban02.txt");
                }
                else if (chonban.Equals("B03"))
                {
                    SaveDataToFile("D:/1DUAN1/CODE/ban03.txt");
                }
              
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bàn ăn.");
            }


        }
      

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtsonguoi_TextChanged(object sender, EventArgs e)
        {

        }
    }
   
}
