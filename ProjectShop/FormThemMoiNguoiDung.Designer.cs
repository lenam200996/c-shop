namespace ProjectShop
{
    partial class FormThemMoiNguoiDung
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnGhiDuLieu = new System.Windows.Forms.Button();
            this.btnThemMoiDuLieu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Người Dùng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên người dùng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên đăng nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật Khẩu";
            // 
            // btnGhiDuLieu
            // 
            this.btnGhiDuLieu.Location = new System.Drawing.Point(101, 257);
            this.btnGhiDuLieu.Name = "btnGhiDuLieu";
            this.btnGhiDuLieu.Size = new System.Drawing.Size(75, 23);
            this.btnGhiDuLieu.TabIndex = 4;
            this.btnGhiDuLieu.Text = "Ghi";
            this.btnGhiDuLieu.UseVisualStyleBackColor = true;
            // 
            // btnThemMoiDuLieu
            // 
            this.btnThemMoiDuLieu.Location = new System.Drawing.Point(267, 257);
            this.btnThemMoiDuLieu.Name = "btnThemMoiDuLieu";
            this.btnThemMoiDuLieu.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoiDuLieu.TabIndex = 5;
            this.btnThemMoiDuLieu.Text = "Thêm mới";
            this.btnThemMoiDuLieu.UseVisualStyleBackColor = true;
            this.btnThemMoiDuLieu.Click += new System.EventHandler(this.btnThemMoiDuLieu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(440, 257);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(182, 73);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(271, 20);
            this.txtFullName.TabIndex = 7;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(182, 130);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(145, 20);
            this.txtUserName.TabIndex = 8;
            this.txtUserName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(182, 192);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(145, 20);
            this.txtMatKhau.TabIndex = 9;
            // 
            // FormThemMoiNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 354);
            this.ControlBox = false;
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThemMoiDuLieu);
            this.Controls.Add(this.btnGhiDuLieu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormThemMoiNguoiDung";
            this.Text = "FormThemMoiNguoiDung";
            this.Load += new System.EventHandler(this.FormThemMoiNguoiDung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGhiDuLieu;
        private System.Windows.Forms.Button btnThemMoiDuLieu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtMatKhau;
    }
}