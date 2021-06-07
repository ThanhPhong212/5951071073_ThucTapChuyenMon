
namespace QuanLyThuVien.GUI
{
    partial class fQLSach
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
            this.dtgSach = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimsach = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTacgia = new System.Windows.Forms.TextBox();
            this.txtTensach = new System.Windows.Forms.TextBox();
            this.txtMasach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGiasach = new System.Windows.Forms.TextBox();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.txtTheloai = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgSach
            // 
            this.dtgSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSach.Location = new System.Drawing.Point(12, 242);
            this.dtgSach.Name = "dtgSach";
            this.dtgSach.Size = new System.Drawing.Size(969, 296);
            this.dtgSach.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(636, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 50;
            this.label6.Text = "Tìm kiếm:";
            // 
            // txtTimsach
            // 
            this.txtTimsach.Location = new System.Drawing.Point(712, 207);
            this.txtTimsach.Name = "txtTimsach";
            this.txtTimsach.Size = new System.Drawing.Size(269, 25);
            this.txtTimsach.TabIndex = 47;
            this.txtTimsach.TextChanged += new System.EventHandler(this.txtTimsach_TextChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(258, 200);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 36);
            this.btnXoa.TabIndex = 46;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(143, 200);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 36);
            this.btnSua.TabIndex = 45;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(23, 200);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 36);
            this.btnThem.TabIndex = 44;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTacgia
            // 
            this.txtTacgia.Location = new System.Drawing.Point(100, 99);
            this.txtTacgia.Name = "txtTacgia";
            this.txtTacgia.Size = new System.Drawing.Size(194, 25);
            this.txtTacgia.TabIndex = 42;
            // 
            // txtTensach
            // 
            this.txtTensach.Location = new System.Drawing.Point(100, 68);
            this.txtTensach.Name = "txtTensach";
            this.txtTensach.Size = new System.Drawing.Size(194, 25);
            this.txtTensach.TabIndex = 41;
            // 
            // txtMasach
            // 
            this.txtMasach.Location = new System.Drawing.Point(100, 37);
            this.txtMasach.Name = "txtMasach";
            this.txtMasach.ReadOnly = true;
            this.txtMasach.Size = new System.Drawing.Size(194, 25);
            this.txtMasach.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Thể loại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tác giả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tên sách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Mã sách:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Nhà xuất bản:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "Giá Sách:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 54;
            this.label8.Text = "Số Lượng:";
            // 
            // txtGiasach
            // 
            this.txtGiasach.Location = new System.Drawing.Point(492, 68);
            this.txtGiasach.Name = "txtGiasach";
            this.txtGiasach.Size = new System.Drawing.Size(194, 25);
            this.txtGiasach.TabIndex = 55;
            // 
            // txtNXB
            // 
            this.txtNXB.Location = new System.Drawing.Point(492, 37);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(194, 25);
            this.txtNXB.TabIndex = 56;
            // 
            // txtTheloai
            // 
            this.txtTheloai.Location = new System.Drawing.Point(100, 130);
            this.txtTheloai.Name = "txtTheloai";
            this.txtTheloai.Size = new System.Drawing.Size(194, 25);
            this.txtTheloai.TabIndex = 57;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Items.Add("10");
            this.txtSoluong.Items.Add("20");
            this.txtSoluong.Items.Add("30");
            this.txtSoluong.Items.Add("40");
            this.txtSoluong.Items.Add("50");
            this.txtSoluong.Items.Add("60");
            this.txtSoluong.Items.Add("70");
            this.txtSoluong.Items.Add("80");
            this.txtSoluong.Items.Add("90");
            this.txtSoluong.Items.Add("100");
            this.txtSoluong.Location = new System.Drawing.Point(492, 99);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(194, 25);
            this.txtSoluong.TabIndex = 58;
            // 
            // fQLSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(993, 550);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.txtTheloai);
            this.Controls.Add(this.txtNXB);
            this.Controls.Add(this.txtGiasach);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgSach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTimsach);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtTacgia);
            this.Controls.Add(this.txtTensach);
            this.Controls.Add(this.txtMasach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fQLSach";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sách";
            this.Load += new System.EventHandler(this.fQLSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimsach;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTacgia;
        private System.Windows.Forms.TextBox txtTensach;
        private System.Windows.Forms.TextBox txtMasach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGiasach;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.TextBox txtTheloai;
        private System.Windows.Forms.DomainUpDown txtSoluong;
    }
}