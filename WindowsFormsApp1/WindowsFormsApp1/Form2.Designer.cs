namespace WindowsFormsApp1
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lb7 = new System.Windows.Forms.Label();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.lb6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.lb9 = new System.Windows.Forms.Label();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.lb8 = new System.Windows.Forms.Label();
            this.dtv1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lb11 = new System.Windows.Forms.Label();
            this.dtv2 = new System.Windows.Forms.DataGridView();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.bt2);
            this.panel1.Controls.Add(this.bt1);
            this.panel1.Controls.Add(this.lb5);
            this.panel1.Location = new System.Drawing.Point(16, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 123);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt2.Location = new System.Drawing.Point(196, 66);
            this.bt2.Margin = new System.Windows.Forms.Padding(4);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(100, 48);
            this.bt2.TabIndex = 6;
            this.bt2.Text = "Xóa";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt1.Location = new System.Drawing.Point(25, 66);
            this.bt1.Margin = new System.Windows.Forms.Padding(4);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(100, 48);
            this.bt1.TabIndex = 6;
            this.bt1.Text = "Tìm";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb5.Location = new System.Drawing.Point(23, 27);
            this.lb5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(77, 16);
            this.lb5.TabIndex = 6;
            this.lb5.Text = "Chọn ngày :";
            this.lb5.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb1.Location = new System.Drawing.Point(460, 9);
            this.lb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(185, 25);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Quản lý hóa đơn";
            this.lb1.Click += new System.EventHandler(this.lb1_Click);
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lb3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb3.Location = new System.Drawing.Point(409, 52);
            this.lb3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(165, 18);
            this.lb3.TabIndex = 3;
            this.lb3.Text = "Tra Cứu Theo Tháng Năm";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb2.Location = new System.Drawing.Point(104, 52);
            this.lb2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(127, 18);
            this.lb2.TabIndex = 4;
            this.lb2.Text = "Tra Cứu Theo Ngày";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lb4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb4.Location = new System.Drawing.Point(769, 52);
            this.lb4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(176, 18);
            this.lb4.TabIndex = 5;
            this.lb4.Text = "Tra Cứu Theo Khoảng Ngày";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.dateTimePicker3);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.lb7);
            this.panel2.Controls.Add(this.bt4);
            this.panel2.Controls.Add(this.bt3);
            this.panel2.Controls.Add(this.lb6);
            this.panel2.Location = new System.Drawing.Point(337, 71);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 123);
            this.panel2.TabIndex = 7;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "yyyy";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(203, 25);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(91, 22);
            this.dateTimePicker3.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "MM";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(72, 25);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(55, 22);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // lb7
            // 
            this.lb7.AutoSize = true;
            this.lb7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb7.Location = new System.Drawing.Point(154, 28);
            this.lb7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(42, 16);
            this.lb7.TabIndex = 7;
            this.lb7.Text = "Năm :";
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt4.Location = new System.Drawing.Point(185, 66);
            this.bt4.Margin = new System.Windows.Forms.Padding(4);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(100, 48);
            this.bt4.TabIndex = 6;
            this.bt4.Text = "Xóa";
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt3.Location = new System.Drawing.Point(27, 66);
            this.bt3.Margin = new System.Windows.Forms.Padding(4);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(100, 48);
            this.bt3.TabIndex = 6;
            this.bt3.Text = "Tìm";
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb6.Location = new System.Drawing.Point(16, 27);
            this.lb6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(52, 16);
            this.lb6.TabIndex = 6;
            this.lb6.Text = "Tháng :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.dateTimePicker5);
            this.panel3.Controls.Add(this.dateTimePicker4);
            this.panel3.Controls.Add(this.lb9);
            this.panel3.Controls.Add(this.bt6);
            this.panel3.Controls.Add(this.bt5);
            this.panel3.Controls.Add(this.lb8);
            this.panel3.Location = new System.Drawing.Point(665, 71);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(396, 123);
            this.panel3.TabIndex = 8;
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.CustomFormat = "";
            this.dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker5.Location = new System.Drawing.Point(244, 25);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(133, 22);
            this.dateTimePicker5.TabIndex = 10;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "";
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker4.Location = new System.Drawing.Point(60, 25);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(133, 22);
            this.dateTimePicker4.TabIndex = 9;
            // 
            // lb9
            // 
            this.lb9.AutoSize = true;
            this.lb9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb9.Location = new System.Drawing.Point(200, 27);
            this.lb9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb9.Name = "lb9";
            this.lb9.Size = new System.Drawing.Size(37, 16);
            this.lb9.TabIndex = 7;
            this.lb9.Text = "Đến :";
            // 
            // bt6
            // 
            this.bt6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt6.Location = new System.Drawing.Point(240, 66);
            this.bt6.Margin = new System.Windows.Forms.Padding(4);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(100, 48);
            this.bt6.TabIndex = 6;
            this.bt6.Text = "Xóa";
            this.bt6.UseVisualStyleBackColor = false;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt5.Location = new System.Drawing.Point(68, 66);
            this.bt5.Margin = new System.Windows.Forms.Padding(4);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(100, 48);
            this.bt5.TabIndex = 6;
            this.bt5.Text = "Tìm";
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // lb8
            // 
            this.lb8.AutoSize = true;
            this.lb8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb8.Location = new System.Drawing.Point(4, 26);
            this.lb8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb8.Name = "lb8";
            this.lb8.Size = new System.Drawing.Size(52, 16);
            this.lb8.TabIndex = 6;
            this.lb8.Text = "Tháng :";
            // 
            // dtv1
            // 
            this.dtv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv1.Location = new System.Drawing.Point(0, 19);
            this.dtv1.Margin = new System.Windows.Forms.Padding(4);
            this.dtv1.Name = "dtv1";
            this.dtv1.Size = new System.Drawing.Size(645, 314);
            this.dtv1.TabIndex = 9;
            this.dtv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv1_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.lb10);
            this.panel4.Controls.Add(this.dtv1);
            this.panel4.Location = new System.Drawing.Point(16, 202);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(649, 337);
            this.panel4.TabIndex = 10;
            // 
            // lb10
            // 
            this.lb10.AutoSize = true;
            this.lb10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lb10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb10.Location = new System.Drawing.Point(245, 0);
            this.lb10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb10.Name = "lb10";
            this.lb10.Size = new System.Drawing.Size(131, 18);
            this.lb10.TabIndex = 12;
            this.lb10.Text = "Danh Sách Hóa Đơn";
            this.lb10.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel5.Controls.Add(this.lb11);
            this.panel5.Controls.Add(this.dtv2);
            this.panel5.Location = new System.Drawing.Point(673, 202);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(388, 263);
            this.panel5.TabIndex = 11;
            // 
            // lb11
            // 
            this.lb11.AutoSize = true;
            this.lb11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lb11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb11.Location = new System.Drawing.Point(142, 0);
            this.lb11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb11.Name = "lb11";
            this.lb11.Size = new System.Drawing.Size(110, 18);
            this.lb11.TabIndex = 13;
            this.lb11.Text = "Chi Tiết Hóa Đơn";
            // 
            // dtv2
            // 
            this.dtv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv2.Location = new System.Drawing.Point(11, 20);
            this.dtv2.Margin = new System.Windows.Forms.Padding(4);
            this.dtv2.Name = "dtv2";
            this.dtv2.RowHeadersWidth = 10;
            this.dtv2.RowTemplate.Height = 20;
            this.dtv2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtv2.Size = new System.Drawing.Size(367, 240);
            this.dtv2.TabIndex = 10;
            // 
            // bt7
            // 
            this.bt7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt7.Location = new System.Drawing.Point(733, 487);
            this.bt7.Margin = new System.Windows.Forms.Padding(4);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(119, 48);
            this.bt7.TabIndex = 12;
            this.bt7.Text = "In Hóa Đơn";
            this.bt7.UseVisualStyleBackColor = false;
            // 
            // bt8
            // 
            this.bt8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt8.Location = new System.Drawing.Point(905, 487);
            this.bt8.Margin = new System.Windows.Forms.Padding(4);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(124, 48);
            this.bt8.TabIndex = 13;
            this.bt8.Text = "Xóa Hóa Đơn";
            this.bt8.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(2, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Trở về";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(971, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 35);
            this.button2.TabIndex = 15;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "QLHD";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb9;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Label lb8;
        private System.Windows.Forms.DataGridView dtv1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lb11;
        private System.Windows.Forms.DataGridView dtv2;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label lb7;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}