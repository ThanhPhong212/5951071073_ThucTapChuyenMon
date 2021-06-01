
namespace QuanLyThuVien.GUI
{
    partial class fTimKiemSach
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
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgTimsach = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoBtnNhaXuatBan = new System.Windows.Forms.RadioButton();
            this.rdoBtnTinhTrang = new System.Windows.Forms.RadioButton();
            this.rdoBtnTacGia = new System.Windows.Forms.RadioButton();
            this.rdoBtnTheLoai = new System.Windows.Forms.RadioButton();
            this.rdoBtnTenSach = new System.Windows.Forms.RadioButton();
            this.rdoBtnMaSach = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTimsach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(389, 24);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(299, 25);
            this.txtTimkiem.TabIndex = 7;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm tên sách:";
            // 
            // dtgTimsach
            // 
            this.dtgTimsach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTimsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTimsach.Location = new System.Drawing.Point(12, 216);
            this.dtgTimsach.Name = "dtgTimsach";
            this.dtgTimsach.Size = new System.Drawing.Size(969, 322);
            this.dtgTimsach.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoBtnNhaXuatBan);
            this.groupBox2.Controls.Add(this.rdoBtnTinhTrang);
            this.groupBox2.Controls.Add(this.rdoBtnTacGia);
            this.groupBox2.Controls.Add(this.rdoBtnTheLoai);
            this.groupBox2.Controls.Add(this.rdoBtnTenSach);
            this.groupBox2.Controls.Add(this.rdoBtnMaSach);
            this.groupBox2.Location = new System.Drawing.Point(347, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 125);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm theo:";
            // 
            // rdoBtnNhaXuatBan
            // 
            this.rdoBtnNhaXuatBan.AutoSize = true;
            this.rdoBtnNhaXuatBan.Location = new System.Drawing.Point(172, 86);
            this.rdoBtnNhaXuatBan.Name = "rdoBtnNhaXuatBan";
            this.rdoBtnNhaXuatBan.Size = new System.Drawing.Size(110, 21);
            this.rdoBtnNhaXuatBan.TabIndex = 5;
            this.rdoBtnNhaXuatBan.TabStop = true;
            this.rdoBtnNhaXuatBan.Text = "Nhà Xuất Bản";
            this.rdoBtnNhaXuatBan.UseVisualStyleBackColor = true;
            // 
            // rdoBtnTinhTrang
            // 
            this.rdoBtnTinhTrang.AutoSize = true;
            this.rdoBtnTinhTrang.Location = new System.Drawing.Point(172, 55);
            this.rdoBtnTinhTrang.Name = "rdoBtnTinhTrang";
            this.rdoBtnTinhTrang.Size = new System.Drawing.Size(93, 21);
            this.rdoBtnTinhTrang.TabIndex = 4;
            this.rdoBtnTinhTrang.TabStop = true;
            this.rdoBtnTinhTrang.Text = "Tình Trạng";
            this.rdoBtnTinhTrang.UseVisualStyleBackColor = true;
            // 
            // rdoBtnTacGia
            // 
            this.rdoBtnTacGia.AutoSize = true;
            this.rdoBtnTacGia.Location = new System.Drawing.Point(172, 24);
            this.rdoBtnTacGia.Name = "rdoBtnTacGia";
            this.rdoBtnTacGia.Size = new System.Drawing.Size(71, 21);
            this.rdoBtnTacGia.TabIndex = 3;
            this.rdoBtnTacGia.TabStop = true;
            this.rdoBtnTacGia.Text = "Tác Giả";
            this.rdoBtnTacGia.UseVisualStyleBackColor = true;
            // 
            // rdoBtnTheLoai
            // 
            this.rdoBtnTheLoai.AutoSize = true;
            this.rdoBtnTheLoai.Location = new System.Drawing.Point(19, 86);
            this.rdoBtnTheLoai.Name = "rdoBtnTheLoai";
            this.rdoBtnTheLoai.Size = new System.Drawing.Size(76, 21);
            this.rdoBtnTheLoai.TabIndex = 2;
            this.rdoBtnTheLoai.TabStop = true;
            this.rdoBtnTheLoai.Text = "Thể loại";
            this.rdoBtnTheLoai.UseVisualStyleBackColor = true;
            // 
            // rdoBtnTenSach
            // 
            this.rdoBtnTenSach.AutoSize = true;
            this.rdoBtnTenSach.Location = new System.Drawing.Point(19, 55);
            this.rdoBtnTenSach.Name = "rdoBtnTenSach";
            this.rdoBtnTenSach.Size = new System.Drawing.Size(80, 21);
            this.rdoBtnTenSach.TabIndex = 1;
            this.rdoBtnTenSach.TabStop = true;
            this.rdoBtnTenSach.Text = "Tên sách";
            this.rdoBtnTenSach.UseVisualStyleBackColor = true;
            // 
            // rdoBtnMaSach
            // 
            this.rdoBtnMaSach.AutoSize = true;
            this.rdoBtnMaSach.Location = new System.Drawing.Point(19, 24);
            this.rdoBtnMaSach.Name = "rdoBtnMaSach";
            this.rdoBtnMaSach.Size = new System.Drawing.Size(76, 21);
            this.rdoBtnMaSach.TabIndex = 0;
            this.rdoBtnMaSach.TabStop = true;
            this.rdoBtnMaSach.Text = "Mã sách";
            this.rdoBtnMaSach.UseVisualStyleBackColor = true;
            // 
            // fTimKiemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 550);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtgTimsach);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fTimKiemSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTimKiemSach";
            this.Load += new System.EventHandler(this.fTimKiemSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTimsach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgTimsach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoBtnNhaXuatBan;
        private System.Windows.Forms.RadioButton rdoBtnTinhTrang;
        private System.Windows.Forms.RadioButton rdoBtnTacGia;
        private System.Windows.Forms.RadioButton rdoBtnTheLoai;
        private System.Windows.Forms.RadioButton rdoBtnTenSach;
        private System.Windows.Forms.RadioButton rdoBtnMaSach;
    }
}