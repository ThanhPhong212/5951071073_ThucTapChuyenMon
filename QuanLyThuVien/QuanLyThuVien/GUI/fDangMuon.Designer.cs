
namespace QuanLyThuVien.GUI
{
    partial class fDangMuon
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
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.radHoten = new System.Windows.Forms.RadioButton();
            this.radTensach = new System.Windows.Forms.RadioButton();
            this.dtgDangmuon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDangmuon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm:";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(388, 30);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(336, 25);
            this.txtTimkiem.TabIndex = 1;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // radHoten
            // 
            this.radHoten.AutoSize = true;
            this.radHoten.Location = new System.Drawing.Point(458, 77);
            this.radHoten.Name = "radHoten";
            this.radHoten.Size = new System.Drawing.Size(67, 21);
            this.radHoten.TabIndex = 2;
            this.radHoten.TabStop = true;
            this.radHoten.Text = "Họ tên";
            this.radHoten.UseVisualStyleBackColor = true;
            // 
            // radTensach
            // 
            this.radTensach.AutoSize = true;
            this.radTensach.Location = new System.Drawing.Point(544, 77);
            this.radTensach.Name = "radTensach";
            this.radTensach.Size = new System.Drawing.Size(80, 21);
            this.radTensach.TabIndex = 3;
            this.radTensach.TabStop = true;
            this.radTensach.Text = "Tên sách";
            this.radTensach.UseVisualStyleBackColor = true;
            // 
            // dtgDangmuon
            // 
            this.dtgDangmuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDangmuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDangmuon.Location = new System.Drawing.Point(12, 131);
            this.dtgDangmuon.Name = "dtgDangmuon";
            this.dtgDangmuon.Size = new System.Drawing.Size(1043, 445);
            this.dtgDangmuon.TabIndex = 4;
            // 
            // fDangMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.dtgDangmuon);
            this.Controls.Add(this.radTensach);
            this.Controls.Add(this.radHoten);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fDangMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đang Mượn";
            this.Load += new System.EventHandler(this.fDangMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDangmuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.RadioButton radHoten;
        private System.Windows.Forms.RadioButton radTensach;
        private System.Windows.Forms.DataGridView dtgDangmuon;
    }
}