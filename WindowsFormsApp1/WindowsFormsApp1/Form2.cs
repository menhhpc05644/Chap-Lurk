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
    public partial class Form2 : Form
    {
        DUANNEntities5 db= new DUANNEntities5();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        HoaDon HD = new HoaDon();
        public Form2()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {

            var result = from c in db.HoaDons select c;
            dt.Columns.Add("Số HĐ", typeof(int));
            dt.Columns.Add("Thời Gian", typeof(DateTime));
            dt.Columns.Add("Mã Bàn Ăn", typeof(string));
            dt.Columns.Add("Số Khách", typeof(int));
            dt.Columns.Add("Mã NV", typeof(string));
            dt.Columns.Add("Tổng Tiền", typeof(double));
            
            foreach (var item  in result)
            {
                dt.Rows.Add(item.SoHD,item.ThoiGian,item.BanAn.MaBanAn,item.SoKhach,item.NhanVien.MaNV,item.TongTien);               
            }
            dtv1.DataSource = dt;
            var result1 = from a in db.ChiTietHDs select a;          
            dt1.Columns.Add("Tên Thực Đơn", typeof (string));
            dt1.Columns.Add("Số Lượng", typeof(int));
            dt1.Columns.Add("Đơn Giá", typeof(float));
            
            foreach (var item1 in result1)
            {
                dt1.Rows.Add(item1.ThucDon.TenThucDon, item1.SoLuong, item1.Dongia);
            }
            dtv2.DataSource = dt1;
            
        }
        void timngay()
        {
            DateTime ngay = dateTimePicker1.Value.Date;
            var result = from c in db.HoaDons select c;
            var result1 = from a in db.ChiTietHDs select a;

            dt.Clear();
            dt1.Clear();            
            foreach (var item in result)
            {
                    if(ngay==item.ThoiGian.Date)
                    {
                        dt.Rows.Add(item.SoHD, item.ThoiGian, item.BanAn.MaBanAn, item.SoKhach, item.NhanVien.MaNV, item.TongTien);
                       
                    }
                    

            }
            dtv1.DataSource = dt;

            int columnIndex = dtv1.Columns["Số HĐ"].Index;
            
            string cellValue = dtv1.Rows[0].Cells[columnIndex].Value.ToString();
            foreach (var item1 in result1)
            {
                if (cellValue==item1.SoHD.ToString())
                {
                    dt1.Rows.Add(item1.ThucDon.TenThucDon, item1.SoLuong, item1.Dongia);

                }
            }
            
            
            dtv2.DataSource = dt1;


        }
        void timthangnam()
        {
            int Thang = dateTimePicker2.Value.Month;
            int Nam = dateTimePicker3.Value.Year;
            var result = from c in db.HoaDons select c;
            dt.Clear();
            foreach (var item in result)
            {
                if (Thang == item.ThoiGian.Month)
                {
                    dt.Rows.Add(item.SoHD, item.ThoiGian, item.BanAn.MaBanAn, item.SoKhach, item.NhanVien.MaNV, item.TongTien);
                }

            }
            dtv1.DataSource = dt;
        }
        void timkn()
        {
            DateTime Tu = dateTimePicker4.Value.Date;
            DateTime Den = dateTimePicker5.Value.Date;
            var result = from c in db.HoaDons select c;
            dt.Clear();
            foreach (var item in result)
            {
                if (Tu<= item.ThoiGian.Date && Den>= item.ThoiGian.Date)
                {
                    dt.Rows.Add(item.SoHD, item.ThoiGian, item.BanAn.MaBanAn, item.SoKhach, item.NhanVien.MaNV, item.TongTien);
                }

            }
            dtv1.DataSource = dt;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt1.Clear();
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timngay();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lb1_Click(object sender, EventArgs e)
        {

        }

        private void dtv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt4_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt1.Clear();
            LoadData();

        }

        private void bt3_Click(object sender, EventArgs e)
        {
            timthangnam();
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            timkn();
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt1.Clear();
            LoadData();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
