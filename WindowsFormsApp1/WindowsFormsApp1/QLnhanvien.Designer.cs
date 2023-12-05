
namespace WindowsFormsApp1
{
    partial class QLnhanvien
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttenNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttenDN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnhaplaiMK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxQUYEN = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmaNV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bttonlammoi = new System.Windows.Forms.Button();
            this.bttonxoa = new System.Windows.Forms.Button();
            this.bttoncapnhat = new System.Windows.Forms.Button();
            this.bttonthem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttonQL = new System.Windows.Forms.Button();
            this.bttonDX = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(681, 285);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã NV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày Sinh";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tên ĐN";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Quyền";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Tên NV : ";
            // 
            // txttenNV
            // 
            this.txttenNV.Location = new System.Drawing.Point(102, 32);
            this.txttenNV.Name = "txttenNV";
            this.txttenNV.Size = new System.Drawing.Size(247, 22);
            this.txttenNV.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Đăng Nhập : ";
            // 
            // txttenDN
            // 
            this.txttenDN.Location = new System.Drawing.Point(488, 32);
            this.txttenDN.Name = "txttenDN";
            this.txttenDN.Size = new System.Drawing.Size(225, 22);
            this.txttenDN.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nhập lại MK : ";
            // 
            // txtnhaplaiMK
            // 
            this.txtnhaplaiMK.Location = new System.Drawing.Point(108, 139);
            this.txtnhaplaiMK.Name = "txtnhaplaiMK";
            this.txtnhaplaiMK.Size = new System.Drawing.Size(241, 22);
            this.txtnhaplaiMK.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày Sinh : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(92, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(257, 22);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mật Khẩu : ";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(92, 100);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(257, 22);
            this.txtMK.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Quyền : ";
            // 
            // cboxQUYEN
            // 
            this.cboxQUYEN.FormattingEnabled = true;
            this.cboxQUYEN.Location = new System.Drawing.Point(438, 64);
            this.cboxQUYEN.Name = "cboxQUYEN";
            this.cboxQUYEN.Size = new System.Drawing.Size(275, 24);
            this.cboxQUYEN.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmaNV);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboxQUYEN);
            this.groupBox1.Controls.Add(this.txttenNV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txttenDN);
            this.groupBox1.Controls.Add(this.txtnhaplaiMK);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMK);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 219);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // txtmaNV
            // 
            this.txtmaNV.Location = new System.Drawing.Point(92, 174);
            this.txtmaNV.Name = "txtmaNV";
            this.txtmaNV.Size = new System.Drawing.Size(257, 22);
            this.txtmaNV.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Mã NV : ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // bttonlammoi
            // 
            this.bttonlammoi.Image = global::WindowsFormsApp1.Properties.Resources.Refresh;
            this.bttonlammoi.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttonlammoi.Location = new System.Drawing.Point(832, 129);
            this.bttonlammoi.Name = "bttonlammoi";
            this.bttonlammoi.Size = new System.Drawing.Size(56, 72);
            this.bttonlammoi.TabIndex = 18;
            this.bttonlammoi.Text = "Làm mới";
            this.bttonlammoi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttonlammoi.UseVisualStyleBackColor = true;
            this.bttonlammoi.Click += new System.EventHandler(this.bttonlammoi_Click);
            // 
            // bttonxoa
            // 
            this.bttonxoa.Image = global::WindowsFormsApp1.Properties.Resources.Delete;
            this.bttonxoa.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttonxoa.Location = new System.Drawing.Point(832, 56);
            this.bttonxoa.Name = "bttonxoa";
            this.bttonxoa.Size = new System.Drawing.Size(52, 52);
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
            this.bttoncapnhat.Location = new System.Drawing.Point(756, 129);
            this.bttoncapnhat.Name = "bttoncapnhat";
            this.bttoncapnhat.Size = new System.Drawing.Size(56, 72);
            this.bttoncapnhat.TabIndex = 16;
            this.bttoncapnhat.Text = "Cập Nhật";
            this.bttoncapnhat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttoncapnhat.UseVisualStyleBackColor = true;
            this.bttoncapnhat.Click += new System.EventHandler(this.bttoncapnhat_Click);
            // 
            // bttonthem
            // 
            this.bttonthem.Image = global::WindowsFormsApp1.Properties.Resources.Add;
            this.bttonthem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttonthem.Location = new System.Drawing.Point(756, 56);
            this.bttonthem.Name = "bttonthem";
            this.bttonthem.Size = new System.Drawing.Size(59, 52);
            this.bttonthem.TabIndex = 15;
            this.bttonthem.Text = "Thêm";
            this.bttonthem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttonthem.UseVisualStyleBackColor = true;
            this.bttonthem.Click += new System.EventHandler(this.bttonthem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Screenshot_24;
            this.pictureBox1.Location = new System.Drawing.Point(711, 270);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 294);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // bttonQL
            // 
            this.bttonQL.Image = global::WindowsFormsApp1.Properties.Resources.Home;
            this.bttonQL.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttonQL.Location = new System.Drawing.Point(901, 37);
            this.bttonQL.Name = "bttonQL";
            this.bttonQL.Size = new System.Drawing.Size(52, 71);
            this.bttonQL.TabIndex = 19;
            this.bttonQL.Text = "Quay Lại";
            this.bttonQL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttonQL.UseVisualStyleBackColor = true;
            // 
            // bttonDX
            // 
            this.bttonDX.Image = global::WindowsFormsApp1.Properties.Resources.Exit;
            this.bttonDX.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttonDX.Location = new System.Drawing.Point(901, 129);
            this.bttonDX.Name = "bttonDX";
            this.bttonDX.Size = new System.Drawing.Size(56, 72);
            this.bttonDX.TabIndex = 20;
            this.bttonDX.Text = "Đăng Xuất";
            this.bttonDX.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttonDX.UseVisualStyleBackColor = true;
            this.bttonDX.Click += new System.EventHandler(this.bttonDX_Click);
            // 
            // QLnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 589);
            this.Controls.Add(this.bttonDX);
            this.Controls.Add(this.bttonQL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bttonlammoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttonxoa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bttoncapnhat);
            this.Controls.Add(this.bttonthem);
            this.Name = "QLnhanvien";
            this.Text = "QLnhanvien";
            this.Load += new System.EventHandler(this.QLnhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttenDN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnhaplaiMK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboxQUYEN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttoncapnhat;
        private System.Windows.Forms.Button bttonthem;
        private System.Windows.Forms.Button bttonxoa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttonlammoi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmaNV;
        private System.Windows.Forms.Button bttonQL;
        private System.Windows.Forms.Button bttonDX;
    }
}