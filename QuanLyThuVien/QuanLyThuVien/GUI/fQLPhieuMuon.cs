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
    public partial class fQLPhieuMuon : Form
    {
        PhieuMuon_BUS pmBUS = new PhieuMuon_BUS();
        public fQLPhieuMuon()
        {
            InitializeComponent();
        }

        private void fQLPhieuMuon_Load(object sender, EventArgs e)
        {
            ResetData();
            dtgPhieumuon.DataSource = pmBUS.GetList();
            bigdings();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ///lb_exist.Visible = false;
            if (pmBUS.CheckExist("DOCGIA", txtMadocgia.Text) == true && pmBUS.CheckExist("SACH", txtMasach.Text) == true)
            {
                PhieuMuon _pM = new PhieuMuon();
                Random rdm = new Random();
                _pM.MaPhieu = rdm.Next(0, 1000).ToString();
                _pM.MaDocGia = txtMadocgia.Text;
                _pM.MaSach = txtMasach.Text;

                if (dtNgaymuon.Text == "")
                    _pM.NgayMuon = DateTime.Now;
                else
                    _pM.NgayMuon = dtNgaymuon.Value;
                if (dtgPhieumuon.Text == "")
                    _pM.NgayPhaiTra = DateTime.Now;
                else
                    _pM.NgayPhaiTra = dtNgayphaitra.Value;

                int check = pmBUS.Them(_pM);
                if (check == -1)
                {
                    //lb_Trung.Visible = true;
                }
                else
                fQLPhieuMuon_Load(sender, e);
            }
            else
            {
                //lb_ChuaNhap.Visible = false;
                //lb_exist.Visible = true;
                //lb_Trung.Visible = false;
            }
        }
        public void bigdings()
        {
            txtMasach.DataBindings.Clear();
            txtMasach.DataBindings.Add("text", dtgPhieumuon.DataSource, "MaSach");

            txtMadocgia.DataBindings.Clear();
            txtMadocgia.DataBindings.Add("text", dtgPhieumuon.DataSource, "MaDocGia");

            txtMaphieu.DataBindings.Clear();
            txtMaphieu.DataBindings.Add("text", dtgPhieumuon.DataSource, "MaPhieu");

            dtNgaymuon.DataBindings.Clear();
            dtNgaymuon.DataBindings.Add("text", dtgPhieumuon.DataSource, "NgayMuon");

            dtNgayphaitra.DataBindings.Clear();
            dtNgayphaitra.DataBindings.Add("text", dtgPhieumuon.DataSource, "NgayPhaiTra");

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaphieu.Text != "")
            {
                if (pmBUS.CheckExist("DOCGIA", txtMadocgia.Text) == true && pmBUS.CheckExist("SACH", txtMasach.Text) == true)
                {
                    PhieuMuon _pM = new PhieuMuon();
                    _pM.MaDocGia = txtMadocgia.Text;
                    _pM.MaSach = txtMasach.Text;
                    _pM.MaPhieu = txtMaphieu.Text;


                    if (dtNgaymuon.Text == "")
                        _pM.NgayMuon = DateTime.Now;
                    else
                        _pM.NgayMuon = dtNgaymuon.Value;
                    if (dtNgayphaitra.Text == "")
                        _pM.NgayPhaiTra = DateTime.Now;
                    else
                        _pM.NgayPhaiTra = dtNgaymuon.Value;

                    pmBUS.Sua(_pM);
                    fQLPhieuMuon_Load(sender, e);
                }
                else
                {
                    //lb_exist.Visible = true;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaphieu.Text != "")
            {
                pmBUS.Xoa(txtMaphieu.Text);
                ResetData();
                fQLPhieuMuon_Load(sender, e);
            }
        }
        private void ResetData()
        {
            txtMaphieu.ResetText();
            txtMasach.ResetText();
            txtMadocgia.ResetText();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                dtgPhieumuon.DataSource = pmBUS.GetList();
            }
            else
            {
                if (radDocgia.Checked == true)
                    dtgPhieumuon.DataSource = pmBUS.TimKiem(txtTimkiem.Text, "MaSach");
                else if (radMasach.Checked == true)
                    dtgPhieumuon.DataSource = pmBUS.TimKiem(txtTimkiem.Text, "MaDocGia");
                else if (radNgaymuon.Checked == true)
                    dtgPhieumuon.DataSource = pmBUS.TimKiem(txtTimkiem.Text, "NgayMuon");
            }
        }
    }
}
