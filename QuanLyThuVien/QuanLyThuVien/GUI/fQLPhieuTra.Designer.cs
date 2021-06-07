
namespace QuanLyThuVien.GUI
{
    partial class fQLPhieuTra
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
            this.radNgaytra = new System.Windows.Forms.RadioButton();
            this.radDocgia = new System.Windows.Forms.RadioButton();
            this.dtgDatra = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radMasach = new System.Windows.Forms.RadioButton();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtNgaytra = new System.Windows.Forms.DateTimePicker();
            this.txtMasach = new System.Windows.Forms.TextBox();
            this.txtMadocgia = new System.Windows.Forms.TextBox();
            this.txtMaphieu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radNgaytra
            // 
            this.radNgaytra.AutoSize = true;
            this.radNgaytra.Location = new System.Drawing.Point(76, 86);
            this.radNgaytra.Name = "radNgaytra";
            this.radNgaytra.Size = new System.Drawing.Size(82, 21);
            this.radNgaytra.TabIndex = 2;
            this.radNgaytra.TabStop = true;
            this.radNgaytra.Text = "Ngày Trả";
            this.radNgaytra.UseVisualStyleBackColor = true;
            // 
            // radDocgia
            // 
            this.radDocgia.AutoSize = true;
            this.radDocgia.Location = new System.Drawing.Point(76, 24);
            this.radDocgia.Name = "radDocgia";
            this.radDocgia.Size = new System.Drawing.Size(96, 21);
            this.radDocgia.TabIndex = 0;
            this.radDocgia.TabStop = true;
            this.radDocgia.Text = "Mã Độc Giả";
            this.radDocgia.UseVisualStyleBackColor = true;
            // 
            // dtgDatra
            // 
            this.dtgDatra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDatra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatra.Location = new System.Drawing.Point(12, 226);
            this.dtgDatra.Name = "dtgDatra";
            this.dtgDatra.Size = new System.Drawing.Size(1043, 350);
            this.dtgDatra.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(642, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Tìm kiếm:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radNgaytra);
            this.groupBox1.Controls.Add(this.radMasach);
            this.groupBox1.Controls.Add(this.radDocgia);
            this.groupBox1.Location = new System.Drawing.Point(645, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 125);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo:";
            // 
            // radMasach
            // 
            this.radMasach.AutoSize = true;
            this.radMasach.Location = new System.Drawing.Point(76, 55);
            this.radMasach.Name = "radMasach";
            this.radMasach.Size = new System.Drawing.Size(77, 21);
            this.radMasach.TabIndex = 1;
            this.radMasach.TabStop = true;
            this.radMasach.Text = "Mã Sách";
            this.radMasach.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(718, 24);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(284, 25);
            this.txtTimkiem.TabIndex = 31;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(255, 176);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 28);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(156, 176);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 28);
            this.btnSua.TabIndex = 29;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(58, 176);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 28);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtNgaytra
            // 
            this.dtNgaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaytra.Location = new System.Drawing.Point(173, 120);
            this.dtNgaytra.Name = "dtNgaytra";
            this.dtNgaytra.Size = new System.Drawing.Size(194, 25);
            this.dtNgaytra.TabIndex = 27;
            // 
            // txtMasach
            // 
            this.txtMasach.Location = new System.Drawing.Point(172, 89);
            this.txtMasach.Name = "txtMasach";
            this.txtMasach.Size = new System.Drawing.Size(194, 25);
            this.txtMasach.TabIndex = 25;
            // 
            // txtMadocgia
            // 
            this.txtMadocgia.Location = new System.Drawing.Point(172, 58);
            this.txtMadocgia.Name = "txtMadocgia";
            this.txtMadocgia.Size = new System.Drawing.Size(194, 25);
            this.txtMadocgia.TabIndex = 24;
            // 
            // txtMaphieu
            // 
            this.txtMaphieu.Location = new System.Drawing.Point(172, 27);
            this.txtMaphieu.Name = "txtMaphieu";
            this.txtMaphieu.ReadOnly = true;
            this.txtMaphieu.Size = new System.Drawing.Size(194, 25);
            this.txtMaphieu.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ngày Trả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mã Sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã Độc Giả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã Phiếu:";
            // 
            // fQLPhieuTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.dtgDatra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtNgaytra);
            this.Controls.Add(this.txtMasach);
            this.Controls.Add(this.txtMadocgia);
            this.Controls.Add(this.txtMaphieu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fQLPhieuTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu Trả";
            this.Load += new System.EventHandler(this.fQLPhieuTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radNgaytra;
        private System.Windows.Forms.RadioButton radDocgia;
        private System.Windows.Forms.DataGridView dtgDatra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radMasach;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtNgaytra;
        private System.Windows.Forms.TextBox txtMasach;
        private System.Windows.Forms.TextBox txtMadocgia;
        private System.Windows.Forms.TextBox txtMaphieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}