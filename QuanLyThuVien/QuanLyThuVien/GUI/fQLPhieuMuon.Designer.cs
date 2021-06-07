
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
            this.dtgPhieumuon = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radNgaymuon = new System.Windows.Forms.RadioButton();
            this.radMasach = new System.Windows.Forms.RadioButton();
            this.radDocgia = new System.Windows.Forms.RadioButton();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtNgaymuon = new System.Windows.Forms.DateTimePicker();
            this.txtMasach = new System.Windows.Forms.TextBox();
            this.txtMadocgia = new System.Windows.Forms.TextBox();
            this.txtMaphieu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtNgayphaitra = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieumuon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgPhieumuon
            // 
            this.dtgPhieumuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPhieumuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPhieumuon.Location = new System.Drawing.Point(12, 255);
            this.dtgPhieumuon.Name = "dtgPhieumuon";
            this.dtgPhieumuon.Size = new System.Drawing.Size(1043, 321);
            this.dtgPhieumuon.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(659, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 50;
            this.label6.Text = "Tìm kiếm:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radNgaymuon);
            this.groupBox1.Controls.Add(this.radMasach);
            this.groupBox1.Controls.Add(this.radDocgia);
            this.groupBox1.Location = new System.Drawing.Point(662, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 125);
            this.groupBox1.TabIndex = 49;
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
            // radDocgia
            // 
            this.radDocgia.AutoSize = true;
            this.radDocgia.Location = new System.Drawing.Point(73, 24);
            this.radDocgia.Name = "radDocgia";
            this.radDocgia.Size = new System.Drawing.Size(96, 21);
            this.radDocgia.TabIndex = 0;
            this.radDocgia.TabStop = true;
            this.radDocgia.Text = "Mã Độc Giả";
            this.radDocgia.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(735, 38);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(257, 25);
            this.txtTimkiem.TabIndex = 47;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(240, 210);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 28);
            this.btnXoa.TabIndex = 46;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(159, 210);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 28);
            this.btnSua.TabIndex = 45;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(78, 210);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 28);
            this.btnThem.TabIndex = 44;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtNgaymuon
            // 
            this.dtNgaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaymuon.Location = new System.Drawing.Point(193, 132);
            this.dtNgaymuon.Name = "dtNgaymuon";
            this.dtNgaymuon.Size = new System.Drawing.Size(194, 25);
            this.dtNgaymuon.TabIndex = 43;
            // 
            // txtMasach
            // 
            this.txtMasach.Location = new System.Drawing.Point(192, 101);
            this.txtMasach.Name = "txtMasach";
            this.txtMasach.Size = new System.Drawing.Size(194, 25);
            this.txtMasach.TabIndex = 42;
            // 
            // txtMadocgia
            // 
            this.txtMadocgia.Location = new System.Drawing.Point(192, 70);
            this.txtMadocgia.Name = "txtMadocgia";
            this.txtMadocgia.Size = new System.Drawing.Size(194, 25);
            this.txtMadocgia.TabIndex = 41;
            // 
            // txtMaphieu
            // 
            this.txtMaphieu.Location = new System.Drawing.Point(192, 39);
            this.txtMaphieu.Name = "txtMaphieu";
            this.txtMaphieu.ReadOnly = true;
            this.txtMaphieu.Size = new System.Drawing.Size(194, 25);
            this.txtMaphieu.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Ngày Mượn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Mã Sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mã Độc Giả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Mã Phiếu:";
            // 
            // dtNgayphaitra
            // 
            this.dtNgayphaitra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayphaitra.Location = new System.Drawing.Point(193, 163);
            this.dtNgayphaitra.Name = "dtNgayphaitra";
            this.dtNgayphaitra.Size = new System.Drawing.Size(194, 25);
            this.dtNgayphaitra.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Ngày Phải Trả:";
            // 
            // fQLPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.dtNgayphaitra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgPhieumuon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtNgaymuon);
            this.Controls.Add(this.txtMasach);
            this.Controls.Add(this.txtMadocgia);
            this.Controls.Add(this.txtMaphieu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fQLPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Phiếu Mượn";
            this.Load += new System.EventHandler(this.fQLPhieuMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieumuon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPhieumuon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radNgaymuon;
        private System.Windows.Forms.RadioButton radMasach;
        private System.Windows.Forms.RadioButton radDocgia;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtNgaymuon;
        private System.Windows.Forms.TextBox txtMasach;
        private System.Windows.Forms.TextBox txtMadocgia;
        private System.Windows.Forms.TextBox txtMaphieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNgayphaitra;
        private System.Windows.Forms.Label label4;
    }
}