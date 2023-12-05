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
    public partial class QLnhanvien : Form
    {
        public QLnhanvien()
        {
            InitializeComponent();
        }
        private void updateDataGv()
        {
            using (DUAN1Entities1 db = new DUAN1Entities1())
            {
                dataGridView1.Rows.Clear();
                db.NhanViens.ToList().ForEach(cc =>
                {
                    dataGridView1.Rows.Add(
                             cc.MaNV,
                             cc.Hoten,
                             cc.NgaySinh,
                             cc.TenDN,
                             cc.Quyen,
                             cc.Matkhau,
                             cc.HoaDons,
                             cc.Phancongs
                       );
                });
                dataGridView1.Update();
            }
        }

        private void QLnhanvien_Load(object sender, EventArgs e)
        {           
            using (DUAN1Entities1 BD = new DUAN1Entities1())
            {
                cboxQUYEN.Items.Clear();
                var cba = BD.NhanViens.Select(a => a.Quyen);
                foreach (var item in cba)
                {
                    
                    cboxQUYEN.Items.Add(item);                   
                }
                updateDataGv();
            }
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = dataGridView1.SelectedCells[0].RowIndex;
                var rowdata = dataGridView1.Rows[row];
                String Matd = rowdata.Cells[0].Value.ToString();
                using (DUAN1Entities1 db = new DUAN1Entities1())
                {
                    NhanVien kh = db.NhanViens.Where(x => x.MaNV == Matd).FirstOrDefault();
                    txtmaNV.Text = kh.MaNV;
                    txttenNV.Text = kh.Hoten;
                    txtMK.Text = kh.Matkhau;
                    txtnhaplaiMK.Text = kh.Matkhau;
                    txttenDN.Text = kh.TenDN;
                    dateTimePicker1.Value = kh.NgaySinh;
                    cboxQUYEN.SelectedItem = kh.Quyen;

                }
                txtmaNV.Enabled = false;
                bttonthem.Enabled = false;
                bttoncapnhat.Enabled = true;
                bttonxoa.Enabled = true;
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                /*bttontimkiem.Enabled = true;*/
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void bttonlammoi_Click(object sender, EventArgs e)
        {
            txttenNV.Text = " ";
            txttenDN.Text = " ";
            txtMK.Text = " ";
            txtnhaplaiMK.Text = " ";
            /*txttimnhanvien.Text = " ";*/
            bttoncapnhat.Enabled = true;
            bttonxoa.Enabled = true;
            bttonthem.Enabled = true;
            /*bttontimkiem.Enabled = true;*/
            cboxQUYEN.SelectedItem = null;
            txtmaNV.Text = " ";
            txtmaNV.Enabled = true;
            /*dateTimePicker1.Enabled = true;*/
            /*dateTimePicker1.Value = null;*/
            dateTimePicker1.Text = string.Empty;
            /*dateTimePicker1.CustomFormat = " ";*/
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void bttonthem_Click(object sender, EventArgs e)
        {
            if (txtMK.Text.Trim() != txtnhaplaiMK.Text.Trim())
            {
                MessageBox.Show("xác nhận mật khẩu 0 trùng khớp!\n Vui lòng nhập lại", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMK.Text.Trim() == string.Empty || txtnhaplaiMK.Text.Trim() == string.Empty || txttenDN.Text.Trim() == string.Empty || cboxQUYEN.Text.Trim() == string.Empty || txttenNV.Text.Trim() == string.Empty)
            {
                MessageBox.Show("k được để trống các thông tin !", "chú ý !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            /*else if (txtmanhanvien.Text.Trim() == null )
            {
                MessageBox.Show("kh được để trống mã NV");
                return;
            }    */
            else
            {
                NhanVien DB = new NhanVien();               
                DB.MaNV = txtmaNV.Text;
                DB.Hoten = txttenNV.Text;
                DB.TenDN = txttenDN.Text;
                DB.Matkhau = txtMK.Text;
                DB.Matkhau = txtnhaplaiMK.Text;
                DB.NgaySinh = dateTimePicker1.Value;

                using (DUAN1Entities1 db = new DUAN1Entities1())
                {
                    NhanVien quyen = db.NhanViens.Where(x => x.Quyen == cboxQUYEN.SelectedItem).FirstOrDefault();
                    DB.Quyen = quyen.Quyen;
                    db.NhanViens.Add(DB);
                    db.SaveChanges();

                }

                MessageBox.Show("Thêm thành công");
                updateDataGv();
            }
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bttonxoa_Click(object sender, EventArgs e)
        {
            if (txtMK.Text.Trim() == string.Empty || txtnhaplaiMK.Text.Trim() == string.Empty || txttenDN.Text.Trim() == string.Empty || cboxQUYEN.Text.Trim() == string.Empty || txttenNV.Text.Trim() == string.Empty)
            {
                MessageBox.Show("k được để trống các thông tin !", "chú ý !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var confirmResult = MessageBox.Show(
                "bạn thật sự muốn xóa nhân viên này ?",
                "xác nhận",
                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (txtmaNV.Text != null || txtmaNV.Text != "")
                {
                    if (ok.deleteNV(txtmaNV.Text))
                    {
                        MessageBox.Show("đã xóa NV");
                        this.updateDataGv();
                        txttenNV.Text = " ";
                        txttenDN.Text = " ";
                        txtMK.Text = " ";
                        txtnhaplaiMK.Text = " ";
                        /*txttimnhanvien.Text = " ";*/
                        bttoncapnhat.Enabled = true;
                        bttonxoa.Enabled = true;
                        bttonthem.Enabled = true;
                        /*bttontimkiem.Enabled = true;*/
                        cboxQUYEN.SelectedItem = null;
                        txtmaNV.Text = " ";
                    }
                    else
                    {
                        MessageBox.Show(
                            "xóa NV thất bại",
                            "lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void bttoncapnhat_Click(object sender, EventArgs e)
        {
            if (txtMK.Text.Trim() == string.Empty || txtnhaplaiMK.Text.Trim() == string.Empty || txttenDN.Text.Trim() == string.Empty || cboxQUYEN.Text.Trim() == string.Empty || txttenNV.Text.Trim() == string.Empty)
            {
                MessageBox.Show("k được để trống các thông tin !", "chú ý !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMK.Text.Trim() != txtnhaplaiMK.Text.Trim())
            {
                MessageBox.Show("xác nhận mật khẩu 0 trùng khớp!\n Vui lòng nhập lại", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            /*else if (txtmanhanvien.Text.Trim() == null )
            {
                MessageBox.Show("kh được để trống mã NV");
                return;
            }    */
            else
            {
                using (DUAN1Entities1 db = new DUAN1Entities1())
                {
                    NhanVien sua = db.NhanViens.Where(x => x.MaNV == txtmaNV.Text).FirstOrDefault();
                    sua.Hoten = txttenNV.Text;
                    sua.TenDN = txttenDN.Text;
                    sua.Matkhau = txtMK.Text;
                    sua.Matkhau = txtnhaplaiMK.Text;
                    sua.NgaySinh = dateTimePicker1.Value;

                    NhanVien nvdcchon = db.NhanViens.Where(x => x.Quyen == cboxQUYEN.SelectedItem).FirstOrDefault();
                    sua.Quyen = nvdcchon.Quyen;
                    MessageBox.Show("cập nhật nhân viên thành công");
                    updateDataGv();
                    db.SaveChanges();
                }
            }
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void bttonDX_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        /*private void bttontimkiem_Click(object sender, EventArgs e)
        {
            
        }*/
    }
}
