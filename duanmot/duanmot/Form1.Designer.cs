
namespace duanmot
{
    partial class Form1
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
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbanan = new System.Windows.Forms.ComboBox();
            this.cbnhanvien = new System.Windows.Forms.ComboBox();
            this.btreset = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.txtca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(345, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 29);
            this.label7.TabIndex = 26;
            this.label7.Text = "PHÂN CÔNG";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ca,
            this.nhanvien,
            this.msb});
            this.dataGridView1.Location = new System.Drawing.Point(64, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(620, 321);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Ca
            // 
            this.Ca.HeaderText = "Ca";
            this.Ca.MinimumWidth = 6;
            this.Ca.Name = "Ca";
            // 
            // nhanvien
            // 
            this.nhanvien.HeaderText = "Nhân Viên";
            this.nhanvien.MinimumWidth = 6;
            this.nhanvien.Name = "nhanvien";
            // 
            // msb
            // 
            this.msb.HeaderText = "Mã Số Bàn";
            this.msb.MinimumWidth = 6;
            this.msb.Name = "msb";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(685, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Bàn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nhân viên:";
            // 
            // cbbanan
            // 
            this.cbbanan.FormattingEnabled = true;
            this.cbbanan.Location = new System.Drawing.Point(734, 60);
            this.cbbanan.Name = "cbbanan";
            this.cbbanan.Size = new System.Drawing.Size(152, 24);
            this.cbbanan.TabIndex = 32;
            // 
            // cbnhanvien
            // 
            this.cbnhanvien.FormattingEnabled = true;
            this.cbnhanvien.Location = new System.Drawing.Point(146, 53);
            this.cbnhanvien.Name = "cbnhanvien";
            this.cbnhanvien.Size = new System.Drawing.Size(208, 24);
            this.cbnhanvien.TabIndex = 35;
            // 
            // btreset
            // 
            this.btreset.Image = global::duanmot.Properties.Resources.Refresh;
            this.btreset.Location = new System.Drawing.Point(768, 166);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(118, 109);
            this.btreset.TabIndex = 38;
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // btadd
            // 
            this.btadd.Image = global::duanmot.Properties.Resources.Add;
            this.btadd.Location = new System.Drawing.Point(768, 298);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(118, 109);
            this.btadd.TabIndex = 22;
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btdelete
            // 
            this.btdelete.Image = global::duanmot.Properties.Resources.Delete;
            this.btdelete.Location = new System.Drawing.Point(768, 439);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(118, 109);
            this.btdelete.TabIndex = 21;
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // txtca
            // 
            this.txtca.Location = new System.Drawing.Point(433, 58);
            this.txtca.Name = "txtca";
            this.txtca.Size = new System.Drawing.Size(186, 22);
            this.txtca.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 560);
            this.Controls.Add(this.txtca);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.cbnhanvien);
            this.Controls.Add(this.cbbanan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbanan;
        private System.Windows.Forms.ComboBox cbnhanvien;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ca;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn msb;
        private System.Windows.Forms.TextBox txtca;
    }
}

