
namespace WindowsFormsApp1
{
    partial class laphoadon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.cbbchonban = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbnhanvien = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txttong = new System.Windows.Forms.TextBox();
            this.bttinhtien = new System.Windows.Forms.Button();
            this.btinhoadon = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btthoat = new System.Windows.Forms.Button();
            this.btdangxuat = new System.Windows.Forms.Button();
            this.bttrangchu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(345, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "LẬP HÓA ĐƠN";
            // 
            // cbbchonban
            // 
            this.cbbchonban.FormattingEnabled = true;
            this.cbbchonban.Location = new System.Drawing.Point(156, 116);
            this.cbbchonban.Name = "cbbchonban";
            this.cbbchonban.Size = new System.Drawing.Size(121, 24);
            this.cbbchonban.TabIndex = 6;
            this.cbbchonban.SelectedIndexChanged += new System.EventHandler(this.cbbchonban_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chọn bàn cần lập";
            // 
            // cbbnhanvien
            // 
            this.cbbnhanvien.FormattingEnabled = true;
            this.cbbnhanvien.Location = new System.Drawing.Point(712, 120);
            this.cbbnhanvien.Name = "cbbnhanvien";
            this.cbbnhanvien.Size = new System.Drawing.Size(207, 24);
            this.cbbnhanvien.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nhân viên lập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ngày lập";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(712, 190);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // txttong
            // 
            this.txttong.Location = new System.Drawing.Point(730, 241);
            this.txttong.Name = "txttong";
            this.txttong.Size = new System.Drawing.Size(103, 22);
            this.txttong.TabIndex = 12;
            // 
            // bttinhtien
            // 
            this.bttinhtien.Location = new System.Drawing.Point(632, 236);
            this.bttinhtien.Name = "bttinhtien";
            this.bttinhtien.Size = new System.Drawing.Size(92, 32);
            this.bttinhtien.TabIndex = 13;
            this.bttinhtien.Text = "Tính tiền";
            this.bttinhtien.UseVisualStyleBackColor = true;
            this.bttinhtien.Click += new System.EventHandler(this.bttinhtien_Click);
            // 
            // btinhoadon
            // 
            this.btinhoadon.Location = new System.Drawing.Point(712, 324);
            this.btinhoadon.Name = "btinhoadon";
            this.btinhoadon.Size = new System.Drawing.Size(141, 90);
            this.btinhoadon.TabIndex = 14;
            this.btinhoadon.Text = "In hóa đơn";
            this.btinhoadon.UseVisualStyleBackColor = true;
            this.btinhoadon.Click += new System.EventHandler(this.btinhoadon_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 156);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(624, 372);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã bàn";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số người";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số lượng";
            this.columnHeader5.Width = 100;
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(229, 15);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(86, 40);
            this.btthoat.TabIndex = 26;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btdangxuat
            // 
            this.btdangxuat.Location = new System.Drawing.Point(120, 12);
            this.btdangxuat.Name = "btdangxuat";
            this.btdangxuat.Size = new System.Drawing.Size(86, 40);
            this.btdangxuat.TabIndex = 25;
            this.btdangxuat.Text = "Đăng xuất";
            this.btdangxuat.UseVisualStyleBackColor = true;
            this.btdangxuat.Click += new System.EventHandler(this.btdangxuat_Click);
            // 
            // bttrangchu
            // 
            this.bttrangchu.Location = new System.Drawing.Point(10, 11);
            this.bttrangchu.Name = "bttrangchu";
            this.bttrangchu.Size = new System.Drawing.Size(86, 40);
            this.bttrangchu.TabIndex = 24;
            this.bttrangchu.Text = "Trang chủ";
            this.bttrangchu.UseVisualStyleBackColor = true;
            this.bttrangchu.Click += new System.EventHandler(this.bttrangchu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(850, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "VND";
            // 
            // laphoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 540);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btdangxuat);
            this.Controls.Add(this.bttrangchu);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btinhoadon);
            this.Controls.Add(this.bttinhtien);
            this.Controls.Add(this.txttong);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbnhanvien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbchonban);
            this.Controls.Add(this.label2);
            this.Name = "laphoadon";
            this.Text = "laphoadon";
            this.Load += new System.EventHandler(this.laphoadon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbchonban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbnhanvien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txttong;
        private System.Windows.Forms.Button bttinhtien;
        private System.Windows.Forms.Button btinhoadon;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btdangxuat;
        private System.Windows.Forms.Button bttrangchu;
        private System.Windows.Forms.Label label5;
    }
}