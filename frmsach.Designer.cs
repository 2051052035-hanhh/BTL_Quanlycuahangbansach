
namespace QLKS
{
    partial class frmsach
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
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.txtMaS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.txtMaTG = new System.Windows.Forms.TextBox();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.txtMaTL = new System.Windows.Forms.TextBox();
            this.txtTenS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.grpFunction = new System.Windows.Forms.GroupBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.MaTG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaTL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lView = new System.Windows.Forms.ListView();
            this.TenS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NamXB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NXB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.grpFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCancel
            // 
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCancel.Location = new System.Drawing.Point(647, 64);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(100, 28);
            this.cmdCancel.TabIndex = 11;
            this.cmdCancel.Text = "Hủy bỏ";
            this.cmdCancel.Visible = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdSave.Location = new System.Drawing.Point(647, 27);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(100, 28);
            this.cmdSave.TabIndex = 10;
            this.cmdSave.Text = "Lưu";
            this.cmdSave.Visible = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // txtMaS
            // 
            this.txtMaS.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaS.Location = new System.Drawing.Point(133, 30);
            this.txtMaS.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaS.Name = "txtMaS";
            this.txtMaS.Size = new System.Drawing.Size(127, 23);
            this.txtMaS.TabIndex = 5;
            this.txtMaS.TextChanged += new System.EventHandler(this.txtMaS_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã sách :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã thể loại:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã tác giả:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdCancel);
            this.groupBox1.Controls.Add(this.cmdSave);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.txtNXB);
            this.groupBox1.Controls.Add(this.txtMaTG);
            this.groupBox1.Controls.Add(this.txtNamXB);
            this.groupBox1.Controls.Add(this.txtMaTL);
            this.groupBox1.Controls.Add(this.txtTenS);
            this.groupBox1.Controls.Add(this.txtMaS);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(755, 148);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(628, 106);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(127, 23);
            this.txtGia.TabIndex = 5;
            this.txtGia.TextChanged += new System.EventHandler(this.txtMaS_TextChanged);
            // 
            // txtNXB
            // 
            this.txtNXB.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNXB.Location = new System.Drawing.Point(404, 106);
            this.txtNXB.Margin = new System.Windows.Forms.Padding(4);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(127, 23);
            this.txtNXB.TabIndex = 5;
            this.txtNXB.TextChanged += new System.EventHandler(this.txtMaS_TextChanged);
            // 
            // txtMaTG
            // 
            this.txtMaTG.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTG.Location = new System.Drawing.Point(133, 106);
            this.txtMaTG.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaTG.Name = "txtMaTG";
            this.txtMaTG.Size = new System.Drawing.Size(127, 23);
            this.txtMaTG.TabIndex = 5;
            this.txtMaTG.TextChanged += new System.EventHandler(this.txtMaS_TextChanged);
            // 
            // txtNamXB
            // 
            this.txtNamXB.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamXB.Location = new System.Drawing.Point(404, 67);
            this.txtNamXB.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(127, 23);
            this.txtNamXB.TabIndex = 5;
            this.txtNamXB.TextChanged += new System.EventHandler(this.txtMaS_TextChanged);
            // 
            // txtMaTL
            // 
            this.txtMaTL.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTL.Location = new System.Drawing.Point(133, 67);
            this.txtMaTL.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.Size = new System.Drawing.Size(127, 23);
            this.txtMaTL.TabIndex = 5;
            this.txtMaTL.TextChanged += new System.EventHandler(this.txtMaS_TextChanged);
            // 
            // txtTenS
            // 
            this.txtTenS.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenS.Location = new System.Drawing.Point(404, 30);
            this.txtTenS.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenS.Name = "txtTenS";
            this.txtTenS.Size = new System.Drawing.Size(127, 23);
            this.txtTenS.TabIndex = 5;
            this.txtTenS.TextChanged += new System.EventHandler(this.txtMaS_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(282, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tên sách :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(282, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Năm XB:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(556, 108);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 30);
            this.label7.TabIndex = 8;
            this.label7.Text = "Giá:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "NXB:";
            // 
            // cmdExit
            // 
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdExit.Location = new System.Drawing.Point(11, 108);
            this.cmdExit.Margin = new System.Windows.Forms.Padding(4);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(96, 28);
            this.cmdExit.TabIndex = 3;
            this.cmdExit.Text = "Thoát";
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdDelete.Location = new System.Drawing.Point(11, 78);
            this.cmdDelete.Margin = new System.Windows.Forms.Padding(4);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(96, 28);
            this.cmdDelete.TabIndex = 2;
            this.cmdDelete.Text = "Xóa";
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdEdit.Location = new System.Drawing.Point(11, 47);
            this.cmdEdit.Margin = new System.Windows.Forms.Padding(4);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(96, 28);
            this.cmdEdit.TabIndex = 1;
            this.cmdEdit.Text = "Sửa";
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // grpFunction
            // 
            this.grpFunction.Controls.Add(this.cmdExit);
            this.grpFunction.Controls.Add(this.cmdDelete);
            this.grpFunction.Controls.Add(this.cmdEdit);
            this.grpFunction.Controls.Add(this.cmdAdd);
            this.grpFunction.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpFunction.Location = new System.Drawing.Point(779, 13);
            this.grpFunction.Margin = new System.Windows.Forms.Padding(4);
            this.grpFunction.Name = "grpFunction";
            this.grpFunction.Padding = new System.Windows.Forms.Padding(4);
            this.grpFunction.Size = new System.Drawing.Size(117, 148);
            this.grpFunction.TabIndex = 8;
            this.grpFunction.TabStop = false;
            // 
            // cmdAdd
            // 
            this.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAdd.Location = new System.Drawing.Point(11, 16);
            this.cmdAdd.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(96, 28);
            this.cmdAdd.TabIndex = 0;
            this.cmdAdd.Text = "Thêm";
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // MaTG
            // 
            this.MaTG.Text = "Mã tác giả";
            this.MaTG.Width = 100;
            // 
            // MaTL
            // 
            this.MaTL.Text = "Mã thể loại";
            this.MaTL.Width = 100;
            // 
            // MaS
            // 
            this.MaS.Text = "Mã sách";
            this.MaS.Width = 100;
            // 
            // lView
            // 
            this.lView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaS,
            this.MaTL,
            this.MaTG,
            this.TenS,
            this.NamXB,
            this.NXB,
            this.Gia});
            this.lView.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lView.FullRowSelect = true;
            this.lView.GridLines = true;
            this.lView.HideSelection = false;
            this.lView.Location = new System.Drawing.Point(16, 172);
            this.lView.Margin = new System.Windows.Forms.Padding(4);
            this.lView.Name = "lView";
            this.lView.Size = new System.Drawing.Size(880, 235);
            this.lView.TabIndex = 7;
            this.lView.UseCompatibleStateImageBehavior = false;
            this.lView.View = System.Windows.Forms.View.Details;
            this.lView.SelectedIndexChanged += new System.EventHandler(this.lView_SelectedIndexChanged);
            // 
            // TenS
            // 
            this.TenS.Text = "Tên sách";
            this.TenS.Width = 100;
            // 
            // NamXB
            // 
            this.NamXB.Text = "Năm xuất bản";
            this.NamXB.Width = 100;
            // 
            // NXB
            // 
            this.NXB.Text = "NXB";
            this.NXB.Width = 100;
            // 
            // Gia
            // 
            this.Gia.Text = "Giá";
            this.Gia.Width = 100;
            // 
            // frmsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 427);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpFunction);
            this.Controls.Add(this.lView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmsach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sách";
            this.Activated += new System.EventHandler(this.frmPhong_Activated);
            this.Load += new System.EventHandler(this.frmPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpFunction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.TextBox txtMaS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.GroupBox grpFunction;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.ColumnHeader MaTG;
        private System.Windows.Forms.ColumnHeader MaTL;
        private System.Windows.Forms.ColumnHeader MaS;
        private System.Windows.Forms.ListView lView;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.TextBox txtMaTG;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.TextBox txtMaTL;
        private System.Windows.Forms.TextBox txtTenS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader TenS;
        private System.Windows.Forms.ColumnHeader NamXB;
        private System.Windows.Forms.ColumnHeader NXB;
        private System.Windows.Forms.ColumnHeader Gia;
    }
}