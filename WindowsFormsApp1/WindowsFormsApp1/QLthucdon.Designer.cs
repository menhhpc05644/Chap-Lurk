
namespace WindowsFormsApp1
{
    partial class QLthucdon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxloaithucdon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttenthucdon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdonvitinh = new System.Windows.Forms.TextBox();
            this.matd = new System.Windows.Forms.Label();
            this.txtmatd = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttonQL = new System.Windows.Forms.Button();
            this.bttonDX = new System.Windows.Forms.Button();
            this.bttonlammoi = new System.Windows.Forms.Button();
            this.bttonxoa = new System.Windows.Forms.Button();
            this.bttoncapnhat = new System.Windows.Forms.Button();
            this.bttonthem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ THỰC ĐƠN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-4, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách thực đơn : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loại TD : ";
            // 
            // cboxloaithucdon
            // 
            this.cboxloaithucdon.FormattingEnabled = true;
            this.cboxloaithucdon.Location = new System.Drawing.Point(102, 218);
            this.cboxloaithucdon.Name = "cboxloaithucdon";
            this.cboxloaithucdon.Size = new System.Drawing.Size(281, 24);
            this.cboxloaithucdon.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên TD : ";
            // 
            // txttenthucdon
            // 
            this.txttenthucdon.Location = new System.Drawing.Point(93, 130);
            this.txttenthucdon.Name = "txttenthucdon";
            this.txttenthucdon.Size = new System.Drawing.Size(281, 22);
            this.txttenthucdon.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Đơn Giá : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(93, 52);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(281, 22);
            this.txtdongia.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Đơn vị tính : ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtdonvitinh
            // 
            this.txtdonvitinh.Location = new System.Drawing.Point(107, 89);
            this.txtdonvitinh.Name = "txtdonvitinh";
            this.txtdonvitinh.Size = new System.Drawing.Size(267, 22);
            this.txtdonvitinh.TabIndex = 13;
            // 
            // matd
            // 
            this.matd.AutoSize = true;
            this.matd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matd.Location = new System.Drawing.Point(17, 174);
            this.matd.Name = "matd";
            this.matd.Size = new System.Drawing.Size(75, 20);
            this.matd.TabIndex = 18;
            this.matd.Text = "Ma TD : ";
            // 
            // txtmatd
            // 
            this.txtmatd.Location = new System.Drawing.Point(98, 174);
            this.txtmatd.Name = "txtmatd";
            this.txtmatd.Size = new System.Drawing.Size(281, 22);
            this.txtmatd.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(1, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(712, 240);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã thực đơn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã loại";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên thực đơn";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Đơn vị tính";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Giá";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // bttonQL
            // 
            this.bttonQL.Image = global::WindowsFormsApp1.Properties.Resources.Home;
            this.bttonQL.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttonQL.Location = new System.Drawing.Point(717, 141);
            this.bttonQL.Name = "bttonQL";
            this.bttonQL.Size = new System.Drawing.Size(90, 55);
            this.bttonQL.TabIndex = 23;
            this.bttonQL.Text = "Quay Lại";
            this.bttonQL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttonQL.UseVisualStyleBackColor = true;
            // 
            // bttonDX
            // 
            this.bttonDX.Image = global::WindowsFormsApp1.Properties.Resources.Exit;
            this.bttonDX.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttonDX.Location = new System.Drawing.Point(717, 217);
            this.bttonDX.Name = "bttonDX";
            this.bttonDX.Size = new System.Drawing.Size(90, 55);
            this.bttonDX.TabIndex = 22;
            this.bttonDX.Text = "Đăng Xuất";
            this.bttonDX.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttonDX.UseVisualStyleBackColor = true;
            this.bttonDX.Click += new System.EventHandler(this.bttonDX_Click);
            // 
            // bttonlammoi
            // 
            this.bttonlammoi.Image = global::WindowsFormsApp1.Properties.Resources.Refresh;
            this.bttonlammoi.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttonlammoi.Location = new System.Drawing.Point(717, 56);
            this.bttonlammoi.Name = "bttonlammoi";
            this.bttonlammoi.Size = new System.Drawing.Size(90, 55);
            this.bttonlammoi.TabIndex = 21;
            this.bttonlammoi.Text = "Làm Mới";
            this.bttonlammoi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttonlammoi.UseVisualStyleBackColor = true;
            this.bttonlammoi.Click += new System.EventHandler(this.bttonlammoi_Click);
            // 
            // bttonxoa
            // 
            this.bttonxoa.Image = global::WindowsFormsApp1.Properties.Resources.Delete;
            this.bttonxoa.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttonxoa.Location = new System.Drawing.Point(611, 54);
            this.bttonxoa.Name = "bttonxoa";
            this.bttonxoa.Size = new System.Drawing.Size(90, 55);
            this.bttonxoa.TabIndex = 17;
            this.bttonxoa.Text = "Xóa";
            this.bttonxoa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttonxoa.UseVisualStyleBackColor = true;
            this.bttonxoa.Click += new System.EventHandler(this.bttonxoa_Click);
            // 
            // bttoncapnhat
            // 
            this.bttoncapnhat.Image = global::WindowsFormsApp1.Properties.Resources.Edit;
            this.bttoncapnhat.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttoncapnhat.Location = new System.Drawing.Point(502, 52);
            this.bttoncapnhat.Name = "bttoncapnhat";
            this.bttoncapnhat.Size = new System.Drawing.Size(93, 57);
            this.bttoncapnhat.TabIndex = 16;
            this.bttoncapnhat.Text = "Cập nhật";
            this.bttoncapnhat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttoncapnhat.UseVisualStyleBackColor = true;
            this.bttoncapnhat.Click += new System.EventHandler(this.bttoncapnhat_Click);
            // 
            // bttonthem
            // 
            this.bttonthem.Image = global::WindowsFormsApp1.Properties.Resources.Add;
            this.bttonthem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttonthem.Location = new System.Drawing.Point(393, 51);
            this.bttonthem.Name = "bttonthem";
            this.bttonthem.Size = new System.Drawing.Size(93, 57);
            this.bttonthem.TabIndex = 15;
            this.bttonthem.Text = "Thêm";
            this.bttonthem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttonthem.UseVisualStyleBackColor = true;
            this.bttonthem.Click += new System.EventHandler(this.bttonthem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.z4884860928604_8d582874ebae32895b6055ff7ca0a1a3;
            this.pictureBox1.Location = new System.Drawing.Point(828, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 497);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // QLthucdon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 558);
            this.Controls.Add(this.bttonQL);
            this.Controls.Add(this.bttonDX);
            this.Controls.Add(this.bttonlammoi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtmatd);
            this.Controls.Add(this.matd);
            this.Controls.Add(this.bttonxoa);
            this.Controls.Add(this.bttoncapnhat);
            this.Controls.Add(this.bttonthem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtdonvitinh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdongia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttenthucdon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboxloaithucdon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QLthucdon";
            this.Text = "QLthucdon";
            this.Load += new System.EventHandler(this.QLthucdon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxloaithucdon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttenthucdon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdonvitinh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttonthem;
        private System.Windows.Forms.Button bttoncapnhat;
        private System.Windows.Forms.Button bttonxoa;
        private System.Windows.Forms.Label matd;
        private System.Windows.Forms.TextBox txtmatd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button bttonlammoi;
        private System.Windows.Forms.Button bttonDX;
        private System.Windows.Forms.Button bttonQL;
    }
}