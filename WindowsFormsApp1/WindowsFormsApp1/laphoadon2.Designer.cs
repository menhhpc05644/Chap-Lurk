
namespace WindowsFormsApp1
{
    partial class laphoadon2
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
            this.cbbbanan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbnguoilap = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btong = new System.Windows.Forms.Button();
            this.txttong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btlaphoadon = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.btdangxuat = new System.Windows.Forms.Button();
            this.bttrangchu = new System.Windows.Forms.Button();
            this.lvdanhsach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(337, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "LẬP HÓA ĐƠN";
            // 
            // cbbbanan
            // 
            this.cbbbanan.FormattingEnabled = true;
            this.cbbbanan.Location = new System.Drawing.Point(110, 112);
            this.cbbbanan.Name = "cbbbanan";
            this.cbbbanan.Size = new System.Drawing.Size(142, 24);
            this.cbbbanan.TabIndex = 10;
            this.cbbbanan.SelectedIndexChanged += new System.EventHandler(this.cbbbanan_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Chọn bàn: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(662, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Người lập";
            // 
            // cbbnguoilap
            // 
            this.cbbnguoilap.FormattingEnabled = true;
            this.cbbnguoilap.Location = new System.Drawing.Point(770, 89);
            this.cbbnguoilap.Name = "cbbnguoilap";
            this.cbbnguoilap.Size = new System.Drawing.Size(197, 24);
            this.cbbnguoilap.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(662, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ngày lập";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(770, 158);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // btong
            // 
            this.btong.Location = new System.Drawing.Point(655, 215);
            this.btong.Name = "btong";
            this.btong.Size = new System.Drawing.Size(75, 38);
            this.btong.TabIndex = 16;
            this.btong.Text = "Tính tiền";
            this.btong.UseVisualStyleBackColor = true;
            this.btong.Click += new System.EventHandler(this.btong_Click);
            // 
            // txttong
            // 
            this.txttong.Location = new System.Drawing.Point(770, 223);
            this.txttong.Name = "txttong";
            this.txttong.Size = new System.Drawing.Size(120, 22);
            this.txttong.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(910, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "VND";
            // 
            // btlaphoadon
            // 
            this.btlaphoadon.Location = new System.Drawing.Point(719, 303);
            this.btlaphoadon.Name = "btlaphoadon";
            this.btlaphoadon.Size = new System.Drawing.Size(191, 101);
            this.btlaphoadon.TabIndex = 19;
            this.btlaphoadon.Text = "Lập hóa đơn";
            this.btlaphoadon.UseVisualStyleBackColor = true;
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
            // lvdanhsach
            // 
            this.lvdanhsach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvdanhsach.HideSelection = false;
            this.lvdanhsach.Location = new System.Drawing.Point(10, 142);
            this.lvdanhsach.Name = "lvdanhsach";
            this.lvdanhsach.Size = new System.Drawing.Size(639, 377);
            this.lvdanhsach.TabIndex = 27;
            this.lvdanhsach.UseCompatibleStateImageBehavior = false;
            this.lvdanhsach.View = System.Windows.Forms.View.Details;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // laphoadon2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvdanhsach);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btdangxuat);
            this.Controls.Add(this.bttrangchu);
            this.Controls.Add(this.btlaphoadon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttong);
            this.Controls.Add(this.btong);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbnguoilap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbbanan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "laphoadon2";
            this.Text = "laphoadon2";
            this.Load += new System.EventHandler(this.laphoadon2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbbanan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbnguoilap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btong;
        private System.Windows.Forms.TextBox txttong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btlaphoadon;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btdangxuat;
        private System.Windows.Forms.Button bttrangchu;
        private System.Windows.Forms.ListView lvdanhsach;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button1;
    }
}