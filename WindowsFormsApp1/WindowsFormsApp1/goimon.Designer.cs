
namespace WindowsFormsApp1
{
    partial class goimon
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
            this.cbbloaiTD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btxoamondachon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbbanan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsonguoi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btthem = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bttrangchu = new System.Windows.Forms.Button();
            this.btdangxuat = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbloaiTD
            // 
            this.cbbloaiTD.FormattingEnabled = true;
            this.cbbloaiTD.Location = new System.Drawing.Point(122, 81);
            this.cbbloaiTD.Name = "cbbloaiTD";
            this.cbbloaiTD.Size = new System.Drawing.Size(151, 24);
            this.cbbloaiTD.TabIndex = 2;
            this.cbbloaiTD.SelectedIndexChanged += new System.EventHandler(this.cbbloaiTD_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loại thực đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(436, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "GỌI MÓN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(773, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Xóa danh sách thực đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btxoamondachon
            // 
            this.btxoamondachon.Location = new System.Drawing.Point(947, 61);
            this.btxoamondachon.Name = "btxoamondachon";
            this.btxoamondachon.Size = new System.Drawing.Size(146, 52);
            this.btxoamondachon.TabIndex = 6;
            this.btxoamondachon.Text = "Xóa món đã chọn";
            this.btxoamondachon.UseVisualStyleBackColor = true;
            this.btxoamondachon.Click += new System.EventHandler(this.btxoamondachon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chọn bàn: ";
            // 
            // cbbbanan
            // 
            this.cbbbanan.FormattingEnabled = true;
            this.cbbbanan.Location = new System.Drawing.Point(397, 133);
            this.cbbbanan.Name = "cbbbanan";
            this.cbbbanan.Size = new System.Drawing.Size(142, 24);
            this.cbbbanan.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số người:";
            // 
            // txtsonguoi
            // 
            this.txtsonguoi.Location = new System.Drawing.Point(397, 187);
            this.txtsonguoi.Name = "txtsonguoi";
            this.txtsonguoi.Size = new System.Drawing.Size(142, 22);
            this.txtsonguoi.TabIndex = 10;
            this.txtsonguoi.TextChanged += new System.EventHandler(this.txtsonguoi_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Giá: ";
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(397, 238);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(142, 22);
            this.txtgia.TabIndex = 12;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(397, 298);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(142, 22);
            this.txtsoluong.TabIndex = 13;
            this.txtsoluong.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Số lượng: ";
            // 
            // btthem
            // 
            this.btthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.Location = new System.Drawing.Point(287, 358);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(99, 74);
            this.btthem.TabIndex = 15;
            this.btthem.Text = ">>";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btluu
            // 
            this.btluu.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Save;
            this.btluu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluu.Location = new System.Drawing.Point(397, 448);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(99, 66);
            this.btluu.TabIndex = 16;
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 133);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(245, 418);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên món";
            this.columnHeader6.Width = 80;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(559, 119);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(550, 425);
            this.listView2.TabIndex = 20;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
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
            // bttrangchu
            // 
            this.bttrangchu.Location = new System.Drawing.Point(12, 8);
            this.bttrangchu.Name = "bttrangchu";
            this.bttrangchu.Size = new System.Drawing.Size(86, 40);
            this.bttrangchu.TabIndex = 21;
            this.bttrangchu.Text = "Trang chủ";
            this.bttrangchu.UseVisualStyleBackColor = true;
            this.bttrangchu.Click += new System.EventHandler(this.bttrangchu_Click);
            // 
            // btdangxuat
            // 
            this.btdangxuat.Location = new System.Drawing.Point(122, 9);
            this.btdangxuat.Name = "btdangxuat";
            this.btdangxuat.Size = new System.Drawing.Size(86, 40);
            this.btdangxuat.TabIndex = 22;
            this.btdangxuat.Text = "Đăng xuất";
            this.btdangxuat.UseVisualStyleBackColor = true;
            this.btdangxuat.Click += new System.EventHandler(this.btdangxuat_Click);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(231, 12);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(86, 40);
            this.btthoat.TabIndex = 23;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // goimon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 625);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btdangxuat);
            this.Controls.Add(this.bttrangchu);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsonguoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbbanan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btxoamondachon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbloaiTD);
            this.Name = "goimon";
            this.Text = "Hệ thống quản lý";
            this.Load += new System.EventHandler(this.goimon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbloaiTD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btxoamondachon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbbanan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsonguoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button bttrangchu;
        private System.Windows.Forms.Button btdangxuat;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}