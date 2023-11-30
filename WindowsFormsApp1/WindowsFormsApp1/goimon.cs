﻿using System;
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
        public goimon()
        {
            InitializeComponent();
        }
        private List<string> dataList = new List<string>();

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
            listView1.Items.Clear();
            string loai = cbbloaiTD.SelectedItem.ToString();
            if(loai=="Thức ăn")
            {
                listView1.Items.Add("Bánh mì ");
                listView1.Items.Add("Cơm chiên");
                listView1.Items.Add("Hủ tiếu");
                listView1.Items.Add("Bánh canh");
            }
            else if(loai=="Thức uống")
            {
                listView1.Items.Add("Coca ");
                listView1.Items.Add("Pepsi");
                listView1.Items.Add("Trà ô long");
                listView1.Items.Add("Trà đường");
            }
            
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Lặp qua từng mục đã chọn trong listView1 và thêm chúng vào listView2
                foreach (ListViewItem selectedItem in listView1.SelectedItems)
                {
                    // Kiểm tra và bắt lỗi nếu một hoặc nhiều trường thông tin được bỏ trống
                    if (!string.IsNullOrEmpty(cbbbanan.Text) && !string.IsNullOrEmpty(txtsonguoi.Text) &&
                        !string.IsNullOrEmpty(txtgia.Text) && !string.IsNullOrEmpty(txtsoluong.Text))
                    {
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
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // Danh sách để lưu trữ dữ liệu

        private void SaveDataToList()
        {
            dataList.Clear(); // Xóa dữ liệu cũ trong danh sách trước khi lưu
            foreach (ListViewItem item in listView1.Items)
            {
                // Lưu dữ liệu từ mỗi item trong ListView vào danh sách
                dataList.Add(item.Text); // Ở đây, giả sử chỉ lưu dữ liệu từ cột đầu tiên của mỗi item
            }
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            SaveDataToList();
            MessageBox.Show("Dữ liệu đã được lưu vào danh sách.");
        }
        public ListView GetDataListView()
        {
            return listView2;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
   
}