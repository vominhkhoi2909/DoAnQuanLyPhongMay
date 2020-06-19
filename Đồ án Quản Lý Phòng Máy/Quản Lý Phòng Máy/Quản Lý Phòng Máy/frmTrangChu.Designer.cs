namespace Quản_Lý_Phòng_Máy
{
    partial class frmTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btndangxuat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnQLlichsuthaydoi = new System.Windows.Forms.Button();
            this.btnQLthanhly = new System.Windows.Forms.Button();
            this.btnQLnhap = new System.Windows.Forms.Button();
            this.btnQLphongmay = new System.Windows.Forms.Button();
            this.btnQLmay = new System.Windows.Forms.Button();
            this.btnGVphutrach = new System.Windows.Forms.Button();
            this.btntrangchu = new System.Windows.Forms.Button();
            this.dgvShowForm = new System.Windows.Forms.DataGridView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 82);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(643, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(146, 82);
            this.panel3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(31, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Người dùng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UTM AbeatbyKai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(47, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "admin";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(302, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(297, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Loko", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(98, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phòng Máy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(96, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quản_Lý_Phòng_Máy.Properties.Resources.open_menu;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btndangxuat);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnQLlichsuthaydoi);
            this.panel2.Controls.Add(this.btnQLthanhly);
            this.panel2.Controls.Add(this.btnQLnhap);
            this.panel2.Controls.Add(this.btnQLphongmay);
            this.panel2.Controls.Add(this.btnQLmay);
            this.panel2.Controls.Add(this.btnGVphutrach);
            this.panel2.Controls.Add(this.btntrangchu);
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(1, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 534);
            this.panel2.TabIndex = 1;
            // 
            // btndangxuat
            // 
            this.btndangxuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndangxuat.Font = new System.Drawing.Font("UTM Alexander", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangxuat.ForeColor = System.Drawing.Color.White;
            this.btndangxuat.Image = ((System.Drawing.Image)(resources.GetObject("btndangxuat.Image")));
            this.btndangxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndangxuat.Location = new System.Drawing.Point(3, 470);
            this.btndangxuat.Name = "btndangxuat";
            this.btndangxuat.Size = new System.Drawing.Size(231, 47);
            this.btndangxuat.TabIndex = 8;
            this.btndangxuat.Text = "Đăng Xuất";
            this.btndangxuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndangxuat.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 56);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnQLlichsuthaydoi
            // 
            this.btnQLlichsuthaydoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLlichsuthaydoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLlichsuthaydoi.Font = new System.Drawing.Font("UTM Alexander", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLlichsuthaydoi.ForeColor = System.Drawing.Color.White;
            this.btnQLlichsuthaydoi.Image = ((System.Drawing.Image)(resources.GetObject("btnQLlichsuthaydoi.Image")));
            this.btnQLlichsuthaydoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLlichsuthaydoi.Location = new System.Drawing.Point(3, 321);
            this.btnQLlichsuthaydoi.Name = "btnQLlichsuthaydoi";
            this.btnQLlichsuthaydoi.Size = new System.Drawing.Size(231, 47);
            this.btnQLlichsuthaydoi.TabIndex = 6;
            this.btnQLlichsuthaydoi.Text = "Quản Lý Lịch Sử Máy";
            this.btnQLlichsuthaydoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLlichsuthaydoi.UseVisualStyleBackColor = true;
            // 
            // btnQLthanhly
            // 
            this.btnQLthanhly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLthanhly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLthanhly.Font = new System.Drawing.Font("UTM Alexander", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLthanhly.ForeColor = System.Drawing.Color.White;
            this.btnQLthanhly.Image = ((System.Drawing.Image)(resources.GetObject("btnQLthanhly.Image")));
            this.btnQLthanhly.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLthanhly.Location = new System.Drawing.Point(3, 268);
            this.btnQLthanhly.Name = "btnQLthanhly";
            this.btnQLthanhly.Size = new System.Drawing.Size(231, 47);
            this.btnQLthanhly.TabIndex = 5;
            this.btnQLthanhly.Text = "Quản Lý Thanh Lý Máy";
            this.btnQLthanhly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLthanhly.UseVisualStyleBackColor = true;
            // 
            // btnQLnhap
            // 
            this.btnQLnhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLnhap.Font = new System.Drawing.Font("UTM Alexander", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLnhap.ForeColor = System.Drawing.Color.White;
            this.btnQLnhap.Image = ((System.Drawing.Image)(resources.GetObject("btnQLnhap.Image")));
            this.btnQLnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLnhap.Location = new System.Drawing.Point(3, 215);
            this.btnQLnhap.Name = "btnQLnhap";
            this.btnQLnhap.Size = new System.Drawing.Size(231, 47);
            this.btnQLnhap.TabIndex = 4;
            this.btnQLnhap.Text = "Quản Lý Nhập Máy";
            this.btnQLnhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLnhap.UseVisualStyleBackColor = true;
            // 
            // btnQLphongmay
            // 
            this.btnQLphongmay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLphongmay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLphongmay.Font = new System.Drawing.Font("UTM Alexander", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLphongmay.ForeColor = System.Drawing.Color.White;
            this.btnQLphongmay.Image = ((System.Drawing.Image)(resources.GetObject("btnQLphongmay.Image")));
            this.btnQLphongmay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLphongmay.Location = new System.Drawing.Point(3, 162);
            this.btnQLphongmay.Name = "btnQLphongmay";
            this.btnQLphongmay.Size = new System.Drawing.Size(231, 47);
            this.btnQLphongmay.TabIndex = 3;
            this.btnQLphongmay.Text = "Quản Lý Phòng Máy";
            this.btnQLphongmay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLphongmay.UseVisualStyleBackColor = true;
            // 
            // btnQLmay
            // 
            this.btnQLmay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLmay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLmay.Font = new System.Drawing.Font("UTM Alexander", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLmay.ForeColor = System.Drawing.Color.White;
            this.btnQLmay.Image = ((System.Drawing.Image)(resources.GetObject("btnQLmay.Image")));
            this.btnQLmay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLmay.Location = new System.Drawing.Point(3, 109);
            this.btnQLmay.Name = "btnQLmay";
            this.btnQLmay.Size = new System.Drawing.Size(231, 47);
            this.btnQLmay.TabIndex = 2;
            this.btnQLmay.Text = "Quản Lý Máy";
            this.btnQLmay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLmay.UseVisualStyleBackColor = true;
            // 
            // btnGVphutrach
            // 
            this.btnGVphutrach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGVphutrach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGVphutrach.Font = new System.Drawing.Font("UTM Alexander", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGVphutrach.ForeColor = System.Drawing.Color.White;
            this.btnGVphutrach.Image = ((System.Drawing.Image)(resources.GetObject("btnGVphutrach.Image")));
            this.btnGVphutrach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGVphutrach.Location = new System.Drawing.Point(3, 56);
            this.btnGVphutrach.Name = "btnGVphutrach";
            this.btnGVphutrach.Size = new System.Drawing.Size(231, 47);
            this.btnGVphutrach.TabIndex = 1;
            this.btnGVphutrach.Text = "GV Phụ Trách";
            this.btnGVphutrach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGVphutrach.UseVisualStyleBackColor = true;
            // 
            // btntrangchu
            // 
            this.btntrangchu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntrangchu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntrangchu.Font = new System.Drawing.Font("UTM Alexander", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrangchu.ForeColor = System.Drawing.Color.White;
            this.btntrangchu.Image = ((System.Drawing.Image)(resources.GetObject("btntrangchu.Image")));
            this.btntrangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntrangchu.Location = new System.Drawing.Point(3, 3);
            this.btntrangchu.Name = "btntrangchu";
            this.btntrangchu.Size = new System.Drawing.Size(231, 47);
            this.btntrangchu.TabIndex = 0;
            this.btntrangchu.Text = "Trang Chủ";
            this.btntrangchu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntrangchu.UseVisualStyleBackColor = true;
            // 
            // dgvShowForm
            // 
            this.dgvShowForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowForm.Location = new System.Drawing.Point(241, 83);
            this.dgvShowForm.Name = "dgvShowForm";
            this.dgvShowForm.Size = new System.Drawing.Size(592, 534);
            this.dgvShowForm.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Aqua;
            this.linkLabel1.Location = new System.Drawing.Point(49, 55);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(46, 16);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Hồ Sơ";
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 617);
            this.Controls.Add(this.dgvShowForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "frmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTrangChu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btndangxuat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnQLlichsuthaydoi;
        private System.Windows.Forms.Button btnQLthanhly;
        private System.Windows.Forms.Button btnQLnhap;
        private System.Windows.Forms.Button btnQLphongmay;
        private System.Windows.Forms.Button btnQLmay;
        private System.Windows.Forms.Button btnGVphutrach;
        private System.Windows.Forms.Button btntrangchu;
        private System.Windows.Forms.DataGridView dgvShowForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}