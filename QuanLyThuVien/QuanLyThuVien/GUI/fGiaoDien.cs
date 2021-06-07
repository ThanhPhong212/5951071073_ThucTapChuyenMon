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
using QuanLyThuVien.DAO;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.GUI
{
    public partial class fGiaoDien : Form
    {
        private string tdn;
        private fLogin fLg;
        

        //Sách
        Sach_BUS sachBUS = new Sach_BUS();

        //Thông tin
        DataProvider _dt = new DataProvider();
        
        ThanhVien_BUS tvBUS = new ThanhVien_BUS();

        //Đổi mật khẩu
        MatKhau_BUS mkBus = new MatKhau_BUS();

        //Sách đang mượn
        SachDangMuon_BUS sdmBus = new SachDangMuon_BUS();

        //Ls mượn
        LichSuMuon_BUS lsmBus = new LichSuMuon_BUS();

        public fGiaoDien(fLogin _flg,string _tdn)
        {
            InitializeComponent();
            tdn = _tdn;
            fLg = _flg;
            DataProvider _dt = new DataProvider();
            DataTable dt = _dt.GetData("select * from ACCOUNT where ACCOUNT.TenDangNhap = '" + tdn + "'");
            string gt = dt.Rows[0]["Quyen"].ToString();
            if (gt == "1")
            {
                menuADM.Visible = false;
                menuThongke.Visible = false;
            }
        }
        
        private void fGiaoDien_Load(object sender, EventArgs e)
        {
            // load sách tìm kiếm
            dtgTimsach.DataSource = sachBUS.GetList();

            // load thông tin độc giả
            DataTable dt = _dt.GetData("select * from ACCOUNT, DOCGIA where ACCOUNT.MaDocGia = DOCGIA.MaDocGia and ACCOUNT.TenDangNhap = '" + tdn + "'");
            txtHoten.DataBindings.Add("Text", dt, "HoTen", true);
            txtMatv.DataBindings.Add("Text", dt, "MaDocGia", true);
            txtGioitinh.DataBindings.Add("Text", dt, "GioiTinh", true);
            dtNgaysinh.DataBindings.Add("Text", dt, "NamSinh", true);
            txtDiachi.DataBindings.Add("Text", dt, "DiaChi", true);
            txtTennd.DataBindings.Add("Text", dt, "HoTen", true);
            txtMatv2.DataBindings.Add("Text", dt, "MaDocGia", true);

            //load sach đang mượn
            dtgSachdangmuon.DataSource = sdmBus.GetList(tdn);

            //load ls mượn
            dtgLichsumuon.DataSource = lsmBus.GetList(tdn);
        }
        private void btnThaydoi_Click(object sender, EventArgs e)
        {
            DocGia _dg = new DocGia();
            ThanhVien tv = new ThanhVien();
            _dg.HoTen = txtHoten.Text;
            _dg.MaDocGia = txtMatv.Text;
            _dg.GioiTinh = txtGioitinh.Text;
            if (dtNgaysinh.Text == "")
                _dg.NamSinh = DateTime.Now;
            else
                _dg.NamSinh = dtNgaysinh.Value;
            _dg.DiaChi = txtDiachi.Text;
            tvBUS.sua(_dg);
            lblDaluu.Text = "Bạn đã thay đổi thông tin thành công";
            txtTennd.Text = txtHoten.Text;
            txtMatv2.Text = txtMatv.Text;
        }
        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                dtgTimsach.DataSource = sachBUS.GetList();
            }
            else
            {
                if (rdoBtnMaSach.Checked == true)
                    dtgTimsach.DataSource = sachBUS.TimKiem(txtTimkiem.Text, "MaSach");
                else if (rdoBtnNhaXuatBan.Checked == true)
                    dtgTimsach.DataSource = sachBUS.TimKiem(txtTimkiem.Text, "NhaXuatBan");
                else if (rdoBtnTacGia.Checked == true)
                    dtgTimsach.DataSource = sachBUS.TimKiem(txtTimkiem.Text, "TacGia");
                else if (rdoBtnTenSach.Checked == true)
                    dtgTimsach.DataSource = sachBUS.TimKiem(txtTimkiem.Text, "TenSach");
                else if (rdoBtnTheLoai.Checked == true)
                    dtgTimsach.DataSource = sachBUS.TimKiem(txtTimkiem.Text, "TheLoai");
                else if (rdoBtnTinhTrang.Checked == true)
                    dtgTimsach.DataSource = sachBUS.TimKiem(txtTimkiem.Text, "TinhTrang");
            }
        }
        private void btnChapnhan_Click(object sender, EventArgs e)
        {
            if (txtMKM.Text != txtNL.Text)
            {
                lblThongbao.Text = "Mật khẩu không khớp";
                txtMKC.ResetText();
                txtMKM.ResetText();
                txtNL.ResetText();
                return;
            }

            if (mkBus.CheckExist(tdn, txtMKC.Text) == true)
            {
                lblThongbao.ResetText();
                ThanhVien _tv = new ThanhVien();
                _tv.TenDangNhap = tdn;
                _tv.MatKhau = txtMKM.Text;

                mkBus.DoiMatKhau(_tv);
                MessageBox.Show("Bạn đã đổi mật khẩu thành công", "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtMKC.ResetText();
                txtMKM.ResetText();
                txtNL.ResetText();
            }
            else
            {
                lblThongbao.ResetText();
                lblThongbao.Text = "Nhập sai mật khẩu";
                txtMKC.ResetText();
                txtMKM.ResetText();
                txtNL.ResetText();
            }
        }

        private void txtTimtensachdangmuon_TextChanged(object sender, EventArgs e)
        {
            if (txtTimtensachdangmuon.Text == "")
            {
                dtgSachdangmuon.DataSource = sdmBus.GetList(tdn);

            }
            else
                dtgSachdangmuon.DataSource = sdmBus.TimKiem(txtTimtensachdangmuon.Text, tdn);
        }
        private void txtTimtensachLS_TextChanged(object sender, EventArgs e)
        {
            if (txtTimtensachLS.Text == "")
            {
                dtgLichsumuon.DataSource = lsmBus.GetList(tdn);
            }
            else
                dtgLichsumuon.DataSource = lsmBus.TimKiem(txtTimtensachLS.Text, tdn);
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLSach qls = new fQLSach();
            this.Hide();
            qls.ShowDialog();
            this.Show();
        }

        private void quảnLýSáchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fQLSach qls = new fQLSach();
            this.Hide();
            qls.ShowDialog();
            this.Show();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLThanhVien qltv = new fQLThanhVien();
            this.Hide();
            qltv.ShowDialog();
            this.Show();
        }

        private void quảnLyPhiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLPhieuMuon qlm = new fQLPhieuMuon();
            this.Hide();
            qlm.ShowDialog();
            this.Show();
        }

        private void quảnLýPhiếuTrãToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLPhieuTra qlt = new fQLPhieuTra();
            this.Hide();
            qlt.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void fGiaoDien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất !", "Thông Báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void đangMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDangMuon dm = new fDangMuon();
            this.Hide();
            dm.ShowDialog();
            this.Show();
        }

        private void đãTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDatra dt = new fDatra();
            this.Hide();
            dt.ShowDialog();
            this.Show();
        }
    }
}
