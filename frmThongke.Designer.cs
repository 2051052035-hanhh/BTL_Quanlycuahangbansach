namespace QLKS
{
    partial class frmThongke
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
            this.gr_tinhdoanhthu = new System.Windows.Forms.GroupBox();
            this.txt_nam = new System.Windows.Forms.TextBox();
            this.txt_thang = new System.Windows.Forms.TextBox();
            this.txt_ngay = new System.Windows.Forms.TextBox();
            this.lbl_nam = new System.Windows.Forms.Label();
            this.lbl_thang = new System.Windows.Forms.Label();
            this.lbl_ngay = new System.Windows.Forms.Label();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_tinhtien = new System.Windows.Forms.Button();
            this.txt_doanhthu = new System.Windows.Forms.TextBox();
            this.lbl_tongdoanhthu = new System.Windows.Forms.Label();
            this.lbl_titlethongkedoanhthu = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gr_tinhdoanhthu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gr_tinhdoanhthu
            // 
            this.gr_tinhdoanhthu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gr_tinhdoanhthu.Controls.Add(this.txt_nam);
            this.gr_tinhdoanhthu.Controls.Add(this.txt_thang);
            this.gr_tinhdoanhthu.Controls.Add(this.txt_ngay);
            this.gr_tinhdoanhthu.Controls.Add(this.lbl_nam);
            this.gr_tinhdoanhthu.Controls.Add(this.lbl_thang);
            this.gr_tinhdoanhthu.Controls.Add(this.lbl_ngay);
            this.gr_tinhdoanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_tinhdoanhthu.ForeColor = System.Drawing.Color.OrangeRed;
            this.gr_tinhdoanhthu.Location = new System.Drawing.Point(51, 72);
            this.gr_tinhdoanhthu.Margin = new System.Windows.Forms.Padding(4);
            this.gr_tinhdoanhthu.Name = "gr_tinhdoanhthu";
            this.gr_tinhdoanhthu.Padding = new System.Windows.Forms.Padding(4);
            this.gr_tinhdoanhthu.Size = new System.Drawing.Size(406, 248);
            this.gr_tinhdoanhthu.TabIndex = 11;
            this.gr_tinhdoanhthu.TabStop = false;
            this.gr_tinhdoanhthu.Text = "Tính doanh thu";
            // 
            // txt_nam
            // 
            this.txt_nam.Location = new System.Drawing.Point(141, 176);
            this.txt_nam.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nam.Name = "txt_nam";
            this.txt_nam.Size = new System.Drawing.Size(225, 29);
            this.txt_nam.TabIndex = 1;
            // 
            // txt_thang
            // 
            this.txt_thang.Location = new System.Drawing.Point(141, 115);
            this.txt_thang.Margin = new System.Windows.Forms.Padding(4);
            this.txt_thang.Name = "txt_thang";
            this.txt_thang.Size = new System.Drawing.Size(225, 29);
            this.txt_thang.TabIndex = 1;
            // 
            // txt_ngay
            // 
            this.txt_ngay.Location = new System.Drawing.Point(141, 57);
            this.txt_ngay.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ngay.Name = "txt_ngay";
            this.txt_ngay.Size = new System.Drawing.Size(225, 29);
            this.txt_ngay.TabIndex = 1;
            // 
            // lbl_nam
            // 
            this.lbl_nam.AutoSize = true;
            this.lbl_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nam.ForeColor = System.Drawing.Color.Black;
            this.lbl_nam.Location = new System.Drawing.Point(8, 183);
            this.lbl_nam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nam.Name = "lbl_nam";
            this.lbl_nam.Size = new System.Drawing.Size(89, 18);
            this.lbl_nam.TabIndex = 0;
            this.lbl_nam.Text = "Nhập năm:";
            // 
            // lbl_thang
            // 
            this.lbl_thang.AutoSize = true;
            this.lbl_thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thang.ForeColor = System.Drawing.Color.Black;
            this.lbl_thang.Location = new System.Drawing.Point(9, 122);
            this.lbl_thang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_thang.Name = "lbl_thang";
            this.lbl_thang.Size = new System.Drawing.Size(98, 18);
            this.lbl_thang.TabIndex = 0;
            this.lbl_thang.Text = "Nhập tháng:";
            // 
            // lbl_ngay
            // 
            this.lbl_ngay.AutoSize = true;
            this.lbl_ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngay.ForeColor = System.Drawing.Color.Black;
            this.lbl_ngay.Location = new System.Drawing.Point(14, 57);
            this.lbl_ngay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ngay.Name = "lbl_ngay";
            this.lbl_ngay.Size = new System.Drawing.Size(92, 18);
            this.lbl_ngay.TabIndex = 0;
            this.lbl_ngay.Text = "Nhập ngày:";
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.BackColor = System.Drawing.Color.Lime;
            this.btn_lammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoi.Location = new System.Drawing.Point(306, 328);
            this.btn_lammoi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(151, 49);
            this.btn_lammoi.TabIndex = 10;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = false;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_tinhtien
            // 
            this.btn_tinhtien.BackColor = System.Drawing.Color.Yellow;
            this.btn_tinhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tinhtien.ForeColor = System.Drawing.Color.Black;
            this.btn_tinhtien.Location = new System.Drawing.Point(51, 328);
            this.btn_tinhtien.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tinhtien.Name = "btn_tinhtien";
            this.btn_tinhtien.Size = new System.Drawing.Size(157, 49);
            this.btn_tinhtien.TabIndex = 9;
            this.btn_tinhtien.Text = "Tính tiền";
            this.btn_tinhtien.UseVisualStyleBackColor = false;
            this.btn_tinhtien.Click += new System.EventHandler(this.btn_tinhtien_Click);
            // 
            // txt_doanhthu
            // 
            this.txt_doanhthu.Location = new System.Drawing.Point(232, 403);
            this.txt_doanhthu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_doanhthu.Name = "txt_doanhthu";
            this.txt_doanhthu.Size = new System.Drawing.Size(225, 22);
            this.txt_doanhthu.TabIndex = 8;
            // 
            // lbl_tongdoanhthu
            // 
            this.lbl_tongdoanhthu.AutoSize = true;
            this.lbl_tongdoanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tongdoanhthu.ForeColor = System.Drawing.Color.Red;
            this.lbl_tongdoanhthu.Location = new System.Drawing.Point(58, 399);
            this.lbl_tongdoanhthu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tongdoanhthu.Name = "lbl_tongdoanhthu";
            this.lbl_tongdoanhthu.Size = new System.Drawing.Size(164, 25);
            this.lbl_tongdoanhthu.TabIndex = 6;
            this.lbl_tongdoanhthu.Text = "Tổng doanh thu\n";
            // 
            // lbl_titlethongkedoanhthu
            // 
            this.lbl_titlethongkedoanhthu.AutoSize = true;
            this.lbl_titlethongkedoanhthu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_titlethongkedoanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titlethongkedoanhthu.ForeColor = System.Drawing.Color.Red;
            this.lbl_titlethongkedoanhthu.Location = new System.Drawing.Point(56, 9);
            this.lbl_titlethongkedoanhthu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titlethongkedoanhthu.Name = "lbl_titlethongkedoanhthu";
            this.lbl_titlethongkedoanhthu.Size = new System.Drawing.Size(395, 42);
            this.lbl_titlethongkedoanhthu.TabIndex = 7;
            this.lbl_titlethongkedoanhthu.Text = "Thống Kê Doanh Thu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(476, 9);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(388, 415);
            this.dataGridView1.TabIndex = 12;
            // 
            // frmThongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 451);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gr_tinhdoanhthu);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.btn_tinhtien);
            this.Controls.Add(this.txt_doanhthu);
            this.Controls.Add(this.lbl_tongdoanhthu);
            this.Controls.Add(this.lbl_titlethongkedoanhthu);
            this.Name = "frmThongke";
            this.Text = "Thống kê doanh thu";
            this.Load += new System.EventHandler(this.frmThongke_Load);
            this.gr_tinhdoanhthu.ResumeLayout(false);
            this.gr_tinhdoanhthu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gr_tinhdoanhthu;
        private System.Windows.Forms.TextBox txt_nam;
        private System.Windows.Forms.TextBox txt_thang;
        private System.Windows.Forms.TextBox txt_ngay;
        private System.Windows.Forms.Label lbl_nam;
        private System.Windows.Forms.Label lbl_thang;
        private System.Windows.Forms.Label lbl_ngay;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_tinhtien;
        private System.Windows.Forms.TextBox txt_doanhthu;
        private System.Windows.Forms.Label lbl_tongdoanhthu;
        private System.Windows.Forms.Label lbl_titlethongkedoanhthu;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}