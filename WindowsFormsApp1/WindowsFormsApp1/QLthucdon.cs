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
    public partial class QLthucdon : Form
    {
        public QLthucdon()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

            private void updateDataGv()
            {
                using (DUAN1Entities1 db = new DUAN1Entities1())
                {
                    dataGridView1.Rows.Clear();
                    db.ThucDons.ToList().ForEach(cc =>
                    {
                        dataGridView1.Rows.Add(
                                 cc.MaThucDon,
                                 cc.LoaiThucDon.TenLoai,
                                 cc.TenThucDon,
                                 cc.DonViTinh,
                                 cc.Gia,
                                 cc.ChiTietHDs

                           );
                    });
                    dataGridView1.Update();
                }
            }

        private void QLthucdon_Load(object sender, EventArgs e)
        {
            using (DUAN1Entities1 BD = new DUAN1Entities1())
            {
                cboxloaithucdon.Items.Clear();
                var cba = BD.LoaiThucDons.Select(a => a.TenLoai);
                foreach (var item in cba)
                {
                    cboxloaithucdon.Items.Add(item);
                }
                updateDataGv();
            }
        }

        private void bttonthem_Click(object sender, EventArgs e)
        {
            
            if (txtdongia.Text.Trim() == string.Empty || txtdonvitinh.Text.Trim() == string.Empty || txttenthucdon.Text.Trim() == string.Empty || cboxloaithucdon.Text.Trim() == string.Empty)
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
                ThucDon DB = new ThucDon();
                DB.Gia = double.Parse(txtdongia.Text);
                DB.MaThucDon = txtmatd.Text;
                DB.DonViTinh = txtdonvitinh.Text;
                DB.TenThucDon = txttenthucdon.Text;
                DB.MaThucDon = txtmatd.Text;

                using (DUAN1Entities1 db = new DUAN1Entities1())
                {
                    ThucDon loaitd = db.ThucDons.Where(x => x.LoaiThucDon.TenLoai == cboxloaithucdon.SelectedItem).FirstOrDefault();
                    DB.LoaiThucDon = loaitd.LoaiThucDon;
                    db.ThucDons.Add(DB);
                    db.SaveChanges();

                }

                MessageBox.Show("Thêm thành công");
                updateDataGv();
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = dataGridView1.SelectedCells[0].RowIndex;
                var rowdata = dataGridView1.Rows[row];
                String Matd = rowdata.Cells[0].Value.ToString();
                using (DUAN1Entities1 db = new DUAN1Entities1())
                {
                    ThucDon kh = db.ThucDons.Where(x => x.MaThucDon == Matd).FirstOrDefault();
                    txtdongia.Text = kh.Gia.ToString();
                    txtdonvitinh.Text = kh.DonViTinh;
                    txttenthucdon.Text = kh.TenThucDon;
                    txtmatd.Text = kh.MaThucDon;

                    cboxloaithucdon.SelectedItem = kh.LoaiThucDon.TenLoai;

                }
                txtmatd.Enabled = false;
                txttenthucdon.Enabled = true;
                bttonthem.Enabled = true;
                bttoncapnhat.Enabled = true;
                bttonxoa.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void bttoncapnhat_Click(object sender, EventArgs e)
        {
            if (txtdongia.Text.Trim() == string.Empty || txtdonvitinh.Text.Trim() == string.Empty || txttenthucdon.Text.Trim() == string.Empty || cboxloaithucdon.Text.Trim() == string.Empty)
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
                using (DUAN1Entities1 db = new DUAN1Entities1())
                {
                    ThucDon sua = db.ThucDons.Where(x => x.MaThucDon == txtmatd.Text).FirstOrDefault();
                    sua.Gia = double.Parse(txtdongia.Text);
                    sua.DonViTinh = txtdonvitinh.Text;
                    sua.TenThucDon = txttenthucdon.Text;
                    /*sua.MaThucDon = txtmatd.Text;*/

                    ThucDon tdduocchon = db.ThucDons.Where(x => x.LoaiThucDon.TenLoai == cboxloaithucdon.SelectedItem).FirstOrDefault();
                    sua.LoaiThucDon = tdduocchon.LoaiThucDon;
                    MessageBox.Show("cập nhật thục đơn thành công");
                    updateDataGv();
                    db.SaveChanges();
                }
            }
        }

        private void bttonlammoi_Click(object sender, EventArgs e)
        {
            txtdongia.Text = " ";
            txtdonvitinh.Text = " ";
            txttenthucdon.Text = " ";
            txtmatd.Text = " ";
            txtmatd.Enabled = true;
            cboxloaithucdon.SelectedItem = null;
            bttonthem.Enabled = true;
            bttonxoa.Enabled = true;
            bttoncapnhat.Enabled = true;
            bttonlammoi.Enabled = true;
        }

        private void bttonxoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "bạn thật sự muốn xóa thực đơn này ?",
                "xác nhận",
                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (txtmatd.Text != null || txtmatd.Text != "")
                {
                    if (ok.deletethucdon(txtmatd.Text))
                    {
                        MessageBox.Show("đã xóa thực đơn");
                        this.updateDataGv();
                        txtdongia.Text = " ";
                        txtdonvitinh.Text = " ";
                        txttenthucdon.Text = " ";
                        txtmatd.Text = " ";
                        cboxloaithucdon.SelectedItem = null;
                        bttonthem.Enabled = true;
                        bttonxoa.Enabled = true;
                        bttoncapnhat.Enabled = true;
                        bttonlammoi.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show(
                            "xóa thực đơn thất bại",
                            "lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
        }

        private void bttonDX_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            this.Hide();
            form2.ShowDialog();
            this.Close();

        }
    }
    }

