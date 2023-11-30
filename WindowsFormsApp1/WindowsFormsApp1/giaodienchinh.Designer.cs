
namespace WindowsFormsApp1
{
    partial class giaodienchinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giaodienchinh));
            this.label1 = new System.Windows.Forms.Label();
            this.btgoimon = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.btphancong = new System.Windows.Forms.Button();
            this.btnhanvien = new System.Windows.Forms.Button();
            this.btquanlyhoadon = new System.Windows.Forms.Button();
            this.btlaphoadon = new System.Windows.Forms.Button();
            this.btthongke = new System.Windows.Forms.Button();
            this.btthucdon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btketthuc = new System.Windows.Forms.Button();
            this.btdangxuat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(185, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ QUÁN ĂN";
            // 
            // btgoimon
            // 
            this.btgoimon.BackColor = System.Drawing.Color.White;
            this.btgoimon.Location = new System.Drawing.Point(2, 96);
            this.btgoimon.Name = "btgoimon";
            this.btgoimon.Size = new System.Drawing.Size(188, 43);
            this.btgoimon.TabIndex = 1;
            this.btgoimon.Text = "Gọi món";
            this.btgoimon.UseVisualStyleBackColor = false;
            this.btgoimon.Click += new System.EventHandler(this.btgoimon_Click);
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(2, 186);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(188, 43);
            this.btupdate.TabIndex = 2;
            this.btupdate.Text = "Cập nhật gọi món";
            this.btupdate.UseVisualStyleBackColor = true;
            // 
            // btphancong
            // 
            this.btphancong.Location = new System.Drawing.Point(698, 186);
            this.btphancong.Name = "btphancong";
            this.btphancong.Size = new System.Drawing.Size(188, 43);
            this.btphancong.TabIndex = 3;
            this.btphancong.Text = "Phân công";
            this.btphancong.UseVisualStyleBackColor = true;
            // 
            // btnhanvien
            // 
            this.btnhanvien.Location = new System.Drawing.Point(698, 96);
            this.btnhanvien.Name = "btnhanvien";
            this.btnhanvien.Size = new System.Drawing.Size(188, 43);
            this.btnhanvien.TabIndex = 4;
            this.btnhanvien.Text = "Quản lý nhân viên";
            this.btnhanvien.UseVisualStyleBackColor = true;
            // 
            // btquanlyhoadon
            // 
            this.btquanlyhoadon.Location = new System.Drawing.Point(2, 364);
            this.btquanlyhoadon.Name = "btquanlyhoadon";
            this.btquanlyhoadon.Size = new System.Drawing.Size(188, 43);
            this.btquanlyhoadon.TabIndex = 5;
            this.btquanlyhoadon.Text = "Quản lý hóa đơn";
            this.btquanlyhoadon.UseVisualStyleBackColor = true;
            // 
            // btlaphoadon
            // 
            this.btlaphoadon.Location = new System.Drawing.Point(2, 272);
            this.btlaphoadon.Name = "btlaphoadon";
            this.btlaphoadon.Size = new System.Drawing.Size(188, 43);
            this.btlaphoadon.TabIndex = 6;
            this.btlaphoadon.Text = "Lập hóa đơn";
            this.btlaphoadon.UseVisualStyleBackColor = true;
            this.btlaphoadon.Click += new System.EventHandler(this.btlaphoadon_Click);
            // 
            // btthongke
            // 
            this.btthongke.Location = new System.Drawing.Point(698, 364);
            this.btthongke.Name = "btthongke";
            this.btthongke.Size = new System.Drawing.Size(188, 43);
            this.btthongke.TabIndex = 7;
            this.btthongke.Text = "Thống kê";
            this.btthongke.UseVisualStyleBackColor = true;
            // 
            // btthucdon
            // 
            this.btthucdon.Location = new System.Drawing.Point(698, 272);
            this.btthucdon.Name = "btthucdon";
            this.btthucdon.Size = new System.Drawing.Size(188, 43);
            this.btthucdon.TabIndex = 8;
            this.btthucdon.Text = "Thực đơn";
            this.btthucdon.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(12, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Giảng viên hướng dẫn: Đặng Thế Duy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(337, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Thực hiện: Nhóm Chap Lurk Bro";
            // 
            // btketthuc
            // 
            this.btketthuc.BackColor = System.Drawing.Color.Transparent;
            this.btketthuc.Image = ((System.Drawing.Image)(resources.GetObject("btketthuc.Image")));
            this.btketthuc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btketthuc.Location = new System.Drawing.Point(674, 473);
            this.btketthuc.Name = "btketthuc";
            this.btketthuc.Size = new System.Drawing.Size(97, 46);
            this.btketthuc.TabIndex = 36;
            this.btketthuc.Text = "Kết thúc";
            this.btketthuc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btketthuc.UseVisualStyleBackColor = false;
            // 
            // btdangxuat
            // 
            this.btdangxuat.BackColor = System.Drawing.Color.Transparent;
            this.btdangxuat.Image = ((System.Drawing.Image)(resources.GetObject("btdangxuat.Image")));
            this.btdangxuat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btdangxuat.Location = new System.Drawing.Point(789, 473);
            this.btdangxuat.Name = "btdangxuat";
            this.btdangxuat.Size = new System.Drawing.Size(97, 46);
            this.btdangxuat.TabIndex = 35;
            this.btdangxuat.Text = "Đăng xuất";
            this.btdangxuat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btdangxuat.UseVisualStyleBackColor = false;
            this.btdangxuat.Click += new System.EventHandler(this.btdangxuat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.ve_tranh_tuong_quan_an_nb3;
            this.pictureBox1.Location = new System.Drawing.Point(192, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 311);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // giaodienchinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(898, 534);
            this.Controls.Add(this.btketthuc);
            this.Controls.Add(this.btdangxuat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btthucdon);
            this.Controls.Add(this.btthongke);
            this.Controls.Add(this.btlaphoadon);
            this.Controls.Add(this.btquanlyhoadon);
            this.Controls.Add(this.btnhanvien);
            this.Controls.Add(this.btphancong);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.btgoimon);
            this.Controls.Add(this.label1);
            this.Name = "giaodienchinh";
            this.Text = "HỆ THỐNG QUẢN LÝ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btgoimon;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btphancong;
        private System.Windows.Forms.Button btnhanvien;
        private System.Windows.Forms.Button btquanlyhoadon;
        private System.Windows.Forms.Button btlaphoadon;
        private System.Windows.Forms.Button btthongke;
        private System.Windows.Forms.Button btthucdon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btdangxuat;
        private System.Windows.Forms.Button btketthuc;
    }
}