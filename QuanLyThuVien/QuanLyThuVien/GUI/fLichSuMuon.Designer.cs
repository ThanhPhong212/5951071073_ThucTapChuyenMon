
namespace QuanLyThuVien.GUI
{
    partial class fLichSuMuon
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
            this.txtTimtensach = new System.Windows.Forms.TextBox();
            this.dtgLichsumuon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLichsumuon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm tên sách:";
            // 
            // txtTimtensach
            // 
            this.txtTimtensach.Location = new System.Drawing.Point(376, 50);
            this.txtTimtensach.Name = "txtTimtensach";
            this.txtTimtensach.Size = new System.Drawing.Size(299, 25);
            this.txtTimtensach.TabIndex = 1;
            // 
            // dtgLichsumuon
            // 
            this.dtgLichsumuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLichsumuon.Location = new System.Drawing.Point(12, 120);
            this.dtgLichsumuon.Name = "dtgLichsumuon";
            this.dtgLichsumuon.Size = new System.Drawing.Size(945, 418);
            this.dtgLichsumuon.TabIndex = 2;
            // 
            // fLichSuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 550);
            this.Controls.Add(this.dtgLichsumuon);
            this.Controls.Add(this.txtTimtensach);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fLichSuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fLichSuMuon";
            this.Load += new System.EventHandler(this.fLichSuMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLichsumuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimtensach;
        private System.Windows.Forms.DataGridView dtgLichsumuon;
    }
}