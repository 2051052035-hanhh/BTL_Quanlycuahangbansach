
namespace QLKS
{
    partial class frmSearchSach
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdTim = new System.Windows.Forms.Button();
            this.cmdThoat = new System.Windows.Forms.Button();
            this.dtGrid = new System.Windows.Forms.DataGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdTim);
            this.groupBox2.Controls.Add(this.cmdThoat);
            this.groupBox2.Controls.Add(this.dtGrid);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNXB);
            this.groupBox2.Controls.Add(this.txtGia);
            this.groupBox2.Controls.Add(this.txtTenS);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMaS);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(608, 407);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin cần tìm";
            // 
            // cmdTim
            // 
            this.cmdTim.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTim.Location = new System.Drawing.Point(427, 30);
            this.cmdTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdTim.Name = "cmdTim";
            this.cmdTim.Size = new System.Drawing.Size(100, 28);
            this.cmdTim.TabIndex = 18;
            this.cmdTim.Text = "Tìm";
            this.cmdTim.Click += new System.EventHandler(this.cmdTim_Click);
            // 
            // cmdThoat
            // 
            this.cmdThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdThoat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdThoat.Location = new System.Drawing.Point(427, 79);
            this.cmdThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdThoat.Name = "cmdThoat";
            this.cmdThoat.Size = new System.Drawing.Size(100, 28);
            this.cmdThoat.TabIndex = 17;
            this.cmdThoat.Text = "Thoát";
            this.cmdThoat.Click += new System.EventHandler(this.cmdThoat_Click);
            // 
            // dtGrid
            // 
            this.dtGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtGrid.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtGrid.CaptionForeColor = System.Drawing.SystemColors.ControlText;
            this.dtGrid.CaptionText = "Danh sách  thỏa điều kiện";
            this.dtGrid.DataMember = "";
            this.dtGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dtGrid.Location = new System.Drawing.Point(8, 167);
            this.dtGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.ReadOnly = true;
            this.dtGrid.Size = new System.Drawing.Size(587, 180);
            this.dtGrid.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã sách:";
            // 
            // txtMaS
            // 
            this.txtMaS.Location = new System.Drawing.Point(141, 30);
            this.txtMaS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaS.Name = "txtMaS";
            this.txtMaS.Size = new System.Drawing.Size(188, 22);
            this.txtMaS.TabIndex = 10;
            this.txtMaS.TextChanged += new System.EventHandler(this.txtMaP_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tên sách:";
            // 
            // txtTenS
            // 
            this.txtTenS.Location = new System.Drawing.Point(141, 56);
            this.txtTenS.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenS.Name = "txtTenS";
            this.txtTenS.Size = new System.Drawing.Size(188, 22);
            this.txtTenS.TabIndex = 10;
            this.txtTenS.TextChanged += new System.EventHandler(this.txtMaP_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nhà xuất bản:";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(141, 86);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(188, 22);
            this.txtGia.TabIndex = 10;
            this.txtGia.TextChanged += new System.EventHandler(this.txtMaP_TextChanged);
            // 
            // txtNXB
            // 
            this.txtNXB.Location = new System.Drawing.Point(141, 112);
            this.txtNXB.Margin = new System.Windows.Forms.Padding(4);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(188, 22);
            this.txtNXB.TabIndex = 10;
            this.txtNXB.TextChanged += new System.EventHandler(this.txtMaP_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 30);
            this.label4.TabIndex = 14;
            this.label4.Text = "Giá :";
            // 
            // frmSearchSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 446);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSearchSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm sách";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdTim;
        private System.Windows.Forms.Button cmdThoat;
        private System.Windows.Forms.DataGrid dtGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenS;
        private System.Windows.Forms.Label label2;
    }
}