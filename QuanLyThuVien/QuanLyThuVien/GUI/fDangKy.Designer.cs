
namespace QuanLyThuVien.GUI
{
    partial class fDangKy
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
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangky = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtNLMK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTrung = new System.Windows.Forms.Label();
            this.lblTontai = new System.Windows.Forms.Label();
            this.lblChuanhap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(159, 58);
            this.txtMatkhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(201, 25);
            this.txtMatkhau.TabIndex = 7;
            this.txtMatkhau.UseSystemPasswordChar = true;
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Location = new System.Drawing.Point(159, 25);
            this.txtTaikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(201, 25);
            this.txtTaikhoan.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tài Khoản";
            // 
            // btnDangky
            // 
            this.btnDangky.Location = new System.Drawing.Point(72, 138);
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Size = new System.Drawing.Size(91, 30);
            this.btnDangky.TabIndex = 8;
            this.btnDangky.Text = "Đăng Ký";
            this.btnDangky.UseVisualStyleBackColor = true;
            this.btnDangky.Click += new System.EventHandler(this.btnDangky_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(205, 138);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(91, 30);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtNLMK
            // 
            this.txtNLMK.Location = new System.Drawing.Point(159, 93);
            this.txtNLMK.Margin = new System.Windows.Forms.Padding(4);
            this.txtNLMK.Name = "txtNLMK";
            this.txtNLMK.Size = new System.Drawing.Size(201, 25);
            this.txtNLMK.TabIndex = 13;
            this.txtNLMK.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // lblTrung
            // 
            this.lblTrung.AutoSize = true;
            this.lblTrung.Location = new System.Drawing.Point(108, 180);
            this.lblTrung.Name = "lblTrung";
            this.lblTrung.Size = new System.Drawing.Size(146, 17);
            this.lblTrung.TabIndex = 15;
            this.lblTrung.Text = "Không trùng mật khẩu";
            // 
            // lblTontai
            // 
            this.lblTontai.AutoSize = true;
            this.lblTontai.Location = new System.Drawing.Point(116, 180);
            this.lblTontai.Name = "lblTontai";
            this.lblTontai.Size = new System.Drawing.Size(130, 17);
            this.lblTontai.TabIndex = 16;
            this.lblTontai.Text = "Tài khoản đã tồn tại";
            // 
            // lblChuanhap
            // 
            this.lblChuanhap.AutoSize = true;
            this.lblChuanhap.Location = new System.Drawing.Point(69, 180);
            this.lblChuanhap.Name = "lblChuanhap";
            this.lblChuanhap.Size = new System.Drawing.Size(227, 17);
            this.lblChuanhap.TabIndex = 17;
            this.lblChuanhap.Text = "Chưa nhập mật khẩu hoạt tài khoản";
            // 
            // fDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 217);
            this.Controls.Add(this.lblChuanhap);
            this.Controls.Add(this.lblTontai);
            this.Controls.Add(this.lblTrung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNLMK);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDangky);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txtTaikhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fDangKy";
            this.Load += new System.EventHandler(this.fDangKy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangky;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtNLMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTrung;
        private System.Windows.Forms.Label lblTontai;
        private System.Windows.Forms.Label lblChuanhap;
    }
}