
namespace QuanLyThuVien.GUI
{
    partial class fDatra
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
            this.dtgDatra = new System.Windows.Forms.DataGridView();
            this.radTensach = new System.Windows.Forms.RadioButton();
            this.radHoten = new System.Windows.Forms.RadioButton();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatra)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDatra
            // 
            this.dtgDatra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDatra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatra.Location = new System.Drawing.Point(12, 122);
            this.dtgDatra.Name = "dtgDatra";
            this.dtgDatra.Size = new System.Drawing.Size(1043, 454);
            this.dtgDatra.TabIndex = 9;
            // 
            // radTensach
            // 
            this.radTensach.AutoSize = true;
            this.radTensach.Location = new System.Drawing.Point(544, 68);
            this.radTensach.Name = "radTensach";
            this.radTensach.Size = new System.Drawing.Size(80, 21);
            this.radTensach.TabIndex = 8;
            this.radTensach.TabStop = true;
            this.radTensach.Text = "Tên sách";
            this.radTensach.UseVisualStyleBackColor = true;
            // 
            // radHoten
            // 
            this.radHoten.AutoSize = true;
            this.radHoten.Location = new System.Drawing.Point(458, 68);
            this.radHoten.Name = "radHoten";
            this.radHoten.Size = new System.Drawing.Size(67, 21);
            this.radHoten.TabIndex = 7;
            this.radHoten.TabStop = true;
            this.radHoten.Text = "Họ tên";
            this.radHoten.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(388, 21);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(336, 25);
            this.txtTimkiem.TabIndex = 6;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tìm kiếm:";
            // 
            // fDatra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.dtgDatra);
            this.Controls.Add(this.radTensach);
            this.Controls.Add(this.radHoten);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fDatra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đã Trả";
            this.Load += new System.EventHandler(this.fDatra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDatra;
        private System.Windows.Forms.RadioButton radTensach;
        private System.Windows.Forms.RadioButton radHoten;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label label1;
    }
}