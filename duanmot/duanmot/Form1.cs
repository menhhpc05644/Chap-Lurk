using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace duanmot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (DUANMOTEntities8 db = new DUANMOTEntities8())
            {



                // Clear items in the ComboBox
                cbnhanvien.Items.Clear();
                // Load NhanViens into the ComboBox
                var nhanViens = db.NhanViens.ToList();
                foreach (var nhanVien in nhanViens)
                {
                    cbnhanvien.Items.Add(nhanVien.Hoten);
                }

                // Clear rows in the DataGridView
                dataGridView1.Rows.Clear();

                // Load Phancongs into the DataGridView
                var phancongs = db.Phancongs.ToList();
                foreach (var bd in phancongs)
                {
                    // Assuming NhanVien is a navigation property in Phancongs
                    var nhanVienHoten = bd.NhanVien != null ? bd.NhanVien.Hoten : "";

                    dataGridView1.Rows.Add(
                        bd.Ca,
                        nhanVienHoten,
                        bd.BanAn
                    );
                }


                // Clear items in the ComboBox
                cbbanan.Items.Clear();

                // Load NhanViens into the ComboBox
                var banans = db.BanAns.ToList();
                foreach (var banan in banans)
                {
                    cbbanan.Items.Add(banan.MaBanAn);
                }
                // Clear rows in the DataGridView
                dataGridView1.Rows.Clear();

                // Load Phancongs into the DataGridView
                var phancongs1 = db.Phancongs.ToList();
                foreach (var bd in phancongs)
                {
                    // Assuming NhanVien is a navigation property in Phancongs
                    var nhanVienHoten = bd.NhanVien != null ? bd.NhanVien.Hoten : "";

                    dataGridView1.Rows.Add(
                        bd.Ca,
                        nhanVienHoten,
                        bd.MaBanAn


                    );
                }
            }
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            Phancong them = new Phancong();
            them.Ca = txtca.Text;
            using (DUANMOTEntities8 db = new DUANMOTEntities8())
            {
                
                if (cbnhanvien.SelectedItem != null && cbbanan.SelectedItem != null)
                {
                    NhanVien nhanVien1 = db.NhanViens
                        .Where(x => x.Hoten == cbnhanvien.SelectedItem.ToString())
                        .FirstOrDefault();

                    BanAn banAn1 = db.BanAns
                        .Where(r => r.MaBanAn == cbbanan.SelectedItem.ToString())
                        .FirstOrDefault();

                    // Tiếp tục xử lý
                }
                else
                {
                    MessageBox.Show("Chọn Nhân viên và Bàn ăn trước khi thêm!");
                }
                
                if (string.IsNullOrEmpty(txtca.Text))
                {                   
                    them.Ca = txtca.Text;
                    // Tiếp tục xử lý
                }
                if (!int.TryParse(txtca.Text, out _))
                {   
                    MessageBox.Show("Vui lòng chỉ nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtca.Clear();
                    return;
                    
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập giá trị cho Ca.");
                    return; // hoặc thực hiện xử lý phù hợp với trường hợp giá trị rỗng
                }
                

                NhanVien nhanVien = db.NhanViens
                    .Where(x => x.Hoten == cbnhanvien.SelectedItem.ToString())
                    .FirstOrDefault();

                BanAn banAn = db.BanAns
                    .Where(r => r.MaBanAn == cbbanan.SelectedItem.ToString())
                    .FirstOrDefault();

                if (nhanVien != null && banAn != null)
                {
                    them.MaBanAn = banAn.MaBanAn;
                    them.MaNV = nhanVien.MaNV;
                    db.Phancongs.Add(them);
                    db.SaveChanges();

                    updateDTG();

                }
                else
                {
                    MessageBox.Show("Chọn Nhân viên và Bàn ăn trước khi thêm!");
                }
            }
            

        }
        private void updateDTG()
        {
            using (DUANMOTEntities8 db = new DUANMOTEntities8())
            {              

                cbbanan.Items.Clear();
                db.BanAns.ToList().ForEach(row => cbbanan.Items.Add(row.MaBanAn));
                dataGridView1.Rows.Clear();
                db.Phancongs.ToList().ForEach(dbb =>
                {
                    dataGridView1.Rows.Add(                       
                        dbb.Ca,
                        dbb.NhanVien.Hoten,                      
                        dbb.BanAn.MaBanAn
                    );

                });
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            using (DUANMOTEntities8 db = new DUANMOTEntities8())
            {
                Phancong xoa = db.Phancongs
                    .Where(x => x.Ca == txtca.Text && x.MaBanAn == cbbanan.SelectedItem.ToString())
                    .FirstOrDefault();

                if (xoa != null)
                {
                    MessageBox.Show("Bạn thực sự muốn xóa không?");
                    db.Phancongs.Remove(xoa);
                    db.SaveChanges();
                    updateDTG();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu để xóa.");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.SelectedCells[0].RowIndex;
            var rowData = dataGridView1.Rows[row];
            string maDoi = rowData.Cells[0].Value.ToString();
            string hotenn = rowData.Cells[1].Value.ToString();
            string mba = rowData.Cells[2].Value.ToString();
            using (DUANMOTEntities8 db = new DUANMOTEntities8())
            {
                Phancong bd = db.Phancongs.Where(x => x.Ca == maDoi).FirstOrDefault();
                NhanVien hoten = db.NhanViens.Where(d => d.Hoten == hotenn).FirstOrDefault();
                BanAn mabanaAns = db.BanAns.Where(c => c.MaBanAn == mba).FirstOrDefault();
                cbnhanvien.SelectedItem = hoten.Hoten;
                txtca.Text = bd.Ca;
                cbbanan.SelectedItem = mabanaAns.MaBanAn;

            }
            btadd.Enabled = false;
            cbbanan.Enabled = false;
            cbnhanvien.Enabled = false;
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            btadd.Enabled = true;
            cbbanan.Enabled = true;
            cbnhanvien.Enabled = true;
            cbbanan.SelectedItem = null;
            cbnhanvien.SelectedItem = null;
            txtca.Text = "";
        }
        private void txtca_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(txtca.Text, out _))
            {
                MessageBox.Show("Vui lòng chỉ nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtca.Focus(); // Đưa focus lại vào TextBox để người dùng có thể sửa lỗi
            }
        }
    }
}
