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

        //tìm kiếm sách
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
        }
        
        private void fGiaoDien_Load(object sender, EventArgs e)
        {
            // load sách tìm kiếm
            dtgTimsach.DataSource = sachBUS.GetList();

            // load thông tin độc giả
            DataTable dt = _dt.GetData("select * from ACCOUNT, DOCGIA where ACCOUNT.MaDocGia = DOCGIA.MaDocGia and ACCOUNT.TenDangNhap = '" + tdn + "'");
            txtHoten.DataBindings.Add("Text", dt, "HoTen", true);
            txtMatv.DataBindings.Add("Text", dt, "MaDocGia", true);
            //string gt = dt.Rows[0]["GioiTinh"].ToString();
            txtGioitinh.DataBindings.Add("Text", dt, "GioiTinh", true);
            if (txtGioitinh.Text == "Nữ   ")
                radNu.Checked = true;
            else if (txtGioitinh.Text == "Nam  ")
                radNam.Checked = true;
            dtNgaysinh.DataBindings.Add("Text", dt, "NamSinh", true);
            txtDiachi.DataBindings.Add("Text", dt, "DiaChi", true);

            //load sach đang mượn
            dtgSachdangmuon.DataSource = sdmBus.GetList(tdn);

            //load ls mượn
            dtgLichsumuon.DataSource = lsmBus.GetList(tdn);
        }
        private void btnThaydoi_Click(object sender, EventArgs e)
        {
            DocGia _dg = new DocGia();
            _dg.HoTen = txtHoten.Text;
            _dg.MaDocGia = txtMatv.Text;

            if (radNam.Checked == true)
                _dg.GioiTinh = "Nam  ";
            else if (radNu.Checked == true)
                _dg.GioiTinh = "Nữ   ";

            if (dtNgaysinh.Text == "")
                _dg.NamSinh = DateTime.Now;
            else
                _dg.NamSinh = dtNgaysinh.Value;

            _dg.DiaChi = txtDiachi.Text;
            tvBUS.sua(_dg);
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

        private void button3_Click(object sender, EventArgs e)
        {

            lb_KhongKhop.Visible = false;
            lb_sai.Visible = false;
            lb_ThanhCong.Visible = false;
            lblchua.Visible = false;
            if (txtMKM.Text != txtNL.Text)
            {
                lb_KhongKhop.Visible = true;
                return;
            }

            if (mkBus.CheckExist(tdn, txtMKC.Text) == true)
            {
                ThanhVien _tv = new ThanhVien();
                _tv.TenDangNhap = tdn;
                _tv.MatKhau = txtMKM.Text;

                mkBus.DoiMatKhau(_tv);
                lb_ThanhCong.Visible = true;
            }
            else
            {
                lb_sai.Visible = true;
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
    }
}
