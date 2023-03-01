namespace QLKS
{
    partial class TheLoai
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.txtMaTL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenTL = new System.Windows.Forms.TextBox();
            this.TenTL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpFunction = new System.Windows.Forms.GroupBox();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.lView = new System.Windows.Forms.ListView();
            this.MaTG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.grpFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdCancel);
            this.groupBox1.Controls.Add(this.cmdSave);
            this.groupBox1.Controls.Add(this.txtMaTL);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenTL);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(76, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(512, 138);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // cmdCancel
            // 
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCancel.Location = new System.Drawing.Point(402, 74);
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
            this.cmdSave.Location = new System.Drawing.Point(402, 23);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(100, 28);
            this.cmdSave.TabIndex = 10;
            this.cmdSave.Text = "Lưu";
            this.cmdSave.Visible = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // txtMaTL
            // 
            this.txtMaTL.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTL.Location = new System.Drawing.Point(160, 20);
            this.txtMaTL.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.Size = new System.Drawing.Size(169, 23);
            this.txtMaTL.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã thể loại:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên thể loại:";
            // 
            // txtTenTL
            // 
            this.txtTenTL.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTL.Location = new System.Drawing.Point(160, 59);
            this.txtTenTL.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenTL.Name = "txtTenTL";
            this.txtTenTL.Size = new System.Drawing.Size(169, 23);
            this.txtTenTL.TabIndex = 5;
            // 
            // TenTL
            // 
            this.TenTL.Text = "Tên thể loại";
            this.TenTL.Width = 150;
            // 
            // grpFunction
            // 
            this.grpFunction.Controls.Add(this.cmdExit);
            this.grpFunction.Controls.Add(this.cmdDelete);
            this.grpFunction.Controls.Add(this.cmdEdit);
            this.grpFunction.Controls.Add(this.cmdAdd);
            this.grpFunction.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpFunction.Location = new System.Drawing.Point(607, 18);
            this.grpFunction.Margin = new System.Windows.Forms.Padding(4);
            this.grpFunction.Name = "grpFunction";
            this.grpFunction.Padding = new System.Windows.Forms.Padding(4);
            this.grpFunction.Size = new System.Drawing.Size(117, 414);
            this.grpFunction.TabIndex = 14;
            this.grpFunction.TabStop = false;
            // 
            // cmdExit
            // 
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdExit.Location = new System.Drawing.Point(11, 138);
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
            this.cmdDelete.Location = new System.Drawing.Point(11, 98);
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
            this.cmdEdit.Location = new System.Drawing.Point(11, 59);
            this.cmdEdit.Margin = new System.Windows.Forms.Padding(4);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(96, 28);
            this.cmdEdit.TabIndex = 1;
            this.cmdEdit.Text = "Sửa";
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAdd.Location = new System.Drawing.Point(11, 20);
            this.cmdAdd.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(96, 28);
            this.cmdAdd.TabIndex = 0;
            this.cmdAdd.Text = "Thêm";
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // lView
            // 
            this.lView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaTG,
            this.TenTL});
            this.lView.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lView.FullRowSelect = true;
            this.lView.GridLines = true;
            this.lView.HideSelection = false;
            this.lView.Location = new System.Drawing.Point(76, 156);
            this.lView.Margin = new System.Windows.Forms.Padding(4);
            this.lView.Name = "lView";
            this.lView.Size = new System.Drawing.Size(512, 275);
            this.lView.TabIndex = 13;
            this.lView.UseCompatibleStateImageBehavior = false;
            this.lView.View = System.Windows.Forms.View.Details;
            this.lView.SelectedIndexChanged += new System.EventHandler(this.lView_SelectedIndexChanged);
            // 
            // MaTG
            // 
            this.MaTG.Text = "Mã thể loại";
            this.MaTG.Width = 100;
            // 
            // TheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpFunction);
            this.Controls.Add(this.lView);
            this.Name = "TheLoai";
            this.Text = "Quản lý thể loại";
            this.Activated += new System.EventHandler(this.TheLoai_Activated);
            this.Load += new System.EventHandler(this.TheLoai_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpFunction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.TextBox txtMaTL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenTL;
        private System.Windows.Forms.ColumnHeader TenTL;
        private System.Windows.Forms.GroupBox grpFunction;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.ListView lView;
        private System.Windows.Forms.ColumnHeader MaTG;
    }
}