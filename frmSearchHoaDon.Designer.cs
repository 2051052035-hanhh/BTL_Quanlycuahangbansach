namespace QLKS
{
    partial class frmSearchHoaDon
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
            this.dtGrid = new System.Windows.Forms.DataGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdTim = new System.Windows.Forms.Button();
            this.cmdThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNV = new System.Windows.Forms.TextBox();
            this.txtSHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaK = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGrid
            // 
            this.dtGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtGrid.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtGrid.CaptionForeColor = System.Drawing.SystemColors.ControlText;
            this.dtGrid.CaptionText = "Danh sách thỏa điều kiện";
            this.dtGrid.DataMember = "";
            this.dtGrid.GridLineColor = System.Drawing.SystemColors.ControlDark;
            this.dtGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dtGrid.Location = new System.Drawing.Point(0, 140);
            this.dtGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.ParentRowsBackColor = System.Drawing.Color.Black;
            this.dtGrid.ReadOnly = true;
            this.dtGrid.Size = new System.Drawing.Size(587, 140);
            this.dtGrid.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdTim);
            this.groupBox2.Controls.Add(this.cmdThoat);
            this.groupBox2.Controls.Add(this.dtGrid);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNV);
            this.groupBox2.Controls.Add(this.txtSHD);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMaK);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(96, 69);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(608, 313);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin cần tìm";
            // 
            // cmdTim
            // 
            this.cmdTim.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTim.Location = new System.Drawing.Point(427, 30);
            this.cmdTim.Margin = new System.Windows.Forms.Padding(4);
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
            this.cmdThoat.Margin = new System.Windows.Forms.Padding(4);
            this.cmdThoat.Name = "cmdThoat";
            this.cmdThoat.Size = new System.Drawing.Size(100, 28);
            this.cmdThoat.TabIndex = 17;
            this.cmdThoat.Text = "Thoát";
            this.cmdThoat.Click += new System.EventHandler(this.cmdThoat_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã hóa đơn";
            // 
            // txtNV
            // 
            this.txtNV.Location = new System.Drawing.Point(139, 59);
            this.txtNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtNV.Name = "txtNV";
            this.txtNV.Size = new System.Drawing.Size(223, 22);
            this.txtNV.TabIndex = 12;
            // 
            // txtSHD
            // 
            this.txtSHD.Location = new System.Drawing.Point(139, 30);
            this.txtSHD.Margin = new System.Windows.Forms.Padding(4);
            this.txtSHD.Name = "txtSHD";
            this.txtSHD.Size = new System.Drawing.Size(223, 22);
            this.txtSHD.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã khách:";
            // 
            // txtMaK
            // 
            this.txtMaK.Location = new System.Drawing.Point(139, 89);
            this.txtMaK.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaK.Name = "txtMaK";
            this.txtMaK.Size = new System.Drawing.Size(223, 22);
            this.txtMaK.TabIndex = 11;
            // 
            // frmSearchHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmSearchHoaDon";
            this.Text = "Tìm kiếm hóa đơn";
            this.Load += new System.EventHandler(this.frmSearchHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dtGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdTim;
        private System.Windows.Forms.Button cmdThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNV;
        private System.Windows.Forms.TextBox txtSHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaK;
    }
}