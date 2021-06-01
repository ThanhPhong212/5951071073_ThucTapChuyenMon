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
    public partial class fDangKy : Form
    {
        ThanhVien_BUS tvBus = new ThanhVien_BUS();
        public fDangKy()
        {
            InitializeComponent();
        }

        private void fDangKy_Load(object sender, EventArgs e)
        {
        }
        private void btnDangky_Click(object sender, EventArgs e)
        {
            lblTontai.Visible = false;
            lblTrung.Visible = false;
            lblChuanhap.Visible = false;

            if (txtMatkhau.Text == "")
            {
                lblChuanhap.Visible = true;
                return;
            }
            if (txtNLMK.Text != txtMatkhau.Text)
            {
                lblTrung.Visible = true;
                return;
            }

            ThanhVien _tv = new ThanhVien();
            _tv.TenDangNhap = txtTaikhoan.Text;
            _tv.MatKhau = txtMatkhau.Text;
            int check = tvBus.DangKy(_tv);

            if (check == 1)
            {
                txtTaikhoan.Text = _tv.TenDangNhap;
                txtMatkhau.Text = _tv.MatKhau;
                MessageBox.Show("Đăng ký thành công");
                fLogin f = new fLogin();
                this.Hide();
                f.ShowDialog();
            }
            else if (check == -1)
            {
                lblChuanhap.Visible = true;
            }
            else
            {
                lblTontai.Visible = true;
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
