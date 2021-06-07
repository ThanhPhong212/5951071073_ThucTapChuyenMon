using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.BUS;
using QuanLyThuVien.DTO;
namespace QuanLyThuVien.GUI
{
    public partial class fLogin : Form
    {
        ThanhVien_BUS tvBus = new ThanhVien_BUS();

        public fLogin()
        {
            InitializeComponent();
        }
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (tvBus.DangNhap(txtTaikhoan.Text, txtMatkhau.Text) == true)
            {
                fGiaoDien gd = new fGiaoDien(this, txtTaikhoan.Text);
                this.Hide();
                gd.ShowDialog();
                this.Show();
                txtTaikhoan.ResetText();
                txtMatkhau.ResetText();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnDangky_Click_1(object sender, EventArgs e)
        {
            fDangKy dk = new fDangKy();
            this.Hide();
            dk.ShowDialog();
            this.Show();
        }
        private void btnDangky_Click(object sender, EventArgs e)
        {
            fDangKy dk = new fDangKy();
            this.Hide();
            dk.ShowDialog();
        }
    }
}
