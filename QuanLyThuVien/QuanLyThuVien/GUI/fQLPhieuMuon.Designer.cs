
namespace QuanLyThuVien.GUI
{
    partial class fQLPhieuMuon
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaphieu = new System.Windows.Forms.TextBox();
            this.txtMadocgia = new System.Windows.Forms.TextBox();
            this.txtMasach = new System.Windows.Forms.TextBox();
            this.dtNgaymuon = new System.Windows.Forms.DateTimePicker();
            this.dtNgayphaitra = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radNgaymuon = new System.Windows.Forms.RadioButton();
            this.radMasach = new System.Windows.Forms.RadioButton();
            this.radMadocgia = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgQLphieumuon = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgQLphieumuon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phiếu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Đọc Giả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Sách:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Mượn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Phải Trả:";
            // 
            // txtMaphieu
            // 
            this.txtMaphieu.Location = new System.Drawing.Point(167, 35);
            this.txtMaphieu.Name = "txtMaphieu";
            this.txtMaphieu.Size = new System.Drawing.Size(194, 25);
            this.txtMaphieu.TabIndex = 5;
            // 
            // txtMadocgia
            // 
            this.txtMadocgia.Location = new System.Drawing.Point(167, 66);
            this.txtMadocgia.Name = "txtMadocgia";
            this.txtMadocgia.Size = new System.Drawing.Size(194, 25);
            this.txtMadocgia.TabIndex = 6;
            // 
            // txtMasach
            // 
            this.txtMasach.Location = new System.Drawing.Point(167, 97);
            this.txtMasach.Name = "txtMasach";
            this.txtMasach.Size = new System.Drawing.Size(194, 25);
            this.txtMasach.TabIndex = 7;
            // 
            // dtNgaymuon
            // 
            this.dtNgaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaymuon.Location = new System.Drawing.Point(167, 128);
            this.dtNgaymuon.Name = "dtNgaymuon";
            this.dtNgaymuon.Size = new System.Drawing.Size(147, 25);
            this.dtNgaymuon.TabIndex = 8;
            // 
            // dtNgayphaitra
            // 
            this.dtNgayphaitra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayphaitra.Location = new System.Drawing.Point(167, 159);
            this.dtNgayphaitra.Name = "dtNgayphaitra";
            this.dtNgayphaitra.Size = new System.Drawing.Size(147, 25);
            this.dtNgayphaitra.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(53, 200);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 26);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(168, 200);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 26);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(286, 200);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 26);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(601, 38);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(257, 25);
            this.txtTimkiem.TabIndex = 13;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radNgaymuon);
            this.groupBox1.Controls.Add(this.radMasach);
            this.groupBox1.Controls.Add(this.radMadocgia);
            this.groupBox1.Location = new System.Drawing.Point(528, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 125);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo:";
            // 
            // radNgaymuon
            // 
            this.radNgaymuon.AutoSize = true;
            this.radNgaymuon.Location = new System.Drawing.Point(73, 86);
            this.radNgaymuon.Name = "radNgaymuon";
            this.radNgaymuon.Size = new System.Drawing.Size(99, 21);
            this.radNgaymuon.TabIndex = 2;
            this.radNgaymuon.TabStop = true;
            this.radNgaymuon.Text = "Ngày Mượn";
            this.radNgaymuon.UseVisualStyleBackColor = true;
            // 
            // radMasach
            // 
            this.radMasach.AutoSize = true;
            this.radMasach.Location = new System.Drawing.Point(73, 55);
            this.radMasach.Name = "radMasach";
            this.radMasach.Size = new System.Drawing.Size(77, 21);
            this.radMasach.TabIndex = 1;
            this.radMasach.TabStop = true;
            this.radMasach.Text = "Mã Sách";
            this.radMasach.UseVisualStyleBackColor = true;
            // 
            // radMadocgia
            // 
            this.radMadocgia.AutoSize = true;
            this.radMadocgia.Location = new System.Drawing.Point(73, 24);
            this.radMadocgia.Name = "radMadocgia";
            this.radMadocgia.Size = new System.Drawing.Size(96, 21);
            this.radMadocgia.TabIndex = 0;
            this.radMadocgia.TabStop = true;
            this.radMadocgia.Text = "Mã Độc Giả";
            this.radMadocgia.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(525, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tìm kiếm:";
            // 
            // dtgQLphieumuon
            // 
            this.dtgQLphieumuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgQLphieumuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgQLphieumuon.Location = new System.Drawing.Point(23, 246);
            this.dtgQLphieumuon.Name = "dtgQLphieumuon";
            this.dtgQLphieumuon.Size = new System.Drawing.Size(946, 292);
            this.dtgQLphieumuon.TabIndex = 17;
            this.dtgQLphieumuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgQLphieumuon_CellContentClick);
            // 
            // fQLPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 550);
            this.Controls.Add(this.dtgQLphieumuon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtNgayphaitra);
            this.Controls.Add(this.dtNgaymuon);
            this.Controls.Add(this.txtMasach);
            this.Controls.Add(this.txtMadocgia);
            this.Controls.Add(this.txtMaphieu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fQLPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLPhieuMuon";
            this.Load += new System.EventHandler(this.fQLPhieuMuon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgQLphieumuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaphieu;
        private System.Windows.Forms.TextBox txtMadocgia;
        private System.Windows.Forms.TextBox txtMasach;
        private System.Windows.Forms.DateTimePicker dtNgaymuon;
        private System.Windows.Forms.DateTimePicker dtNgayphaitra;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgQLphieumuon;
        private System.Windows.Forms.RadioButton radNgaymuon;
        private System.Windows.Forms.RadioButton radMasach;
        private System.Windows.Forms.RadioButton radMadocgia;
    }
}