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
    public partial class fQLPhieuTra : Form
    {
        PhieuTra_BUS ptBUS = new PhieuTra_BUS();
        public fQLPhieuTra()
        {
            InitializeComponent();
        }

        private void fQLPhieuTra_Load(object sender, EventArgs e)
        {
            ResetGridview();
            dtgDatra.DataSource = ptBUS.GetList();
            bigdings();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //lb_exist.Visible = false;
            if (ptBUS.CheckExist("DOCGIA", txtMaphieu.Text) == true && ptBUS.CheckExist("SACH", txtMasach.Text) == true)
            {
                PhieuTra _pt = new PhieuTra();
                _pt.MaDocGia = txtMadocgia.Text;
                _pt.MaSach = txtMasach.Text;

                Random rdm = new Random();
                _pt.MaPhieu = rdm.Next(0, 1000).ToString();

                if (dtNgaytra.Text == "")
                    _pt.NgayTra = DateTime.Now;
                else
                    _pt.NgayTra = dtNgaytra.Value;

                int check = ptBUS.Them(_pt);
                if (check == -1)
                {

                }
                //lb_Trung.Visible = true;
                else
                    fQLPhieuTra_Load(sender, e);
            }
            else
            {
                //lb_ChuaNhap.Visible = false;
                //lb_exist.Visible = true;
                //lb_Trung.Visible = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaphieu.Text != "")
            {
                if (ptBUS.CheckExist("DOCGIA", txtMadocgia.Text) == true && ptBUS.CheckExist("SACH", txtMasach.Text) == true)
                {
                    PhieuTra _pt = new PhieuTra();
                    _pt.MaDocGia = txtMadocgia.Text;
                    _pt.MaSach = txtMasach.Text;
                    _pt.MaPhieu = txtMaphieu.Text;

                    if (dtNgaytra.Text == "")
                        _pt.NgayTra = DateTime.Now;
                    else
                        _pt.NgayTra = dtNgaytra.Value;

                    ptBUS.Sua(_pt);
                    fQLPhieuTra_Load(sender, e);
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
                ptBUS.Xoa(txtMaphieu.Text);
                ResetGridview();
                fQLPhieuTra_Load(sender, e);
            }
        }
        private void ResetGridview()
        {
            txtMaphieu.ResetText();
            txtMasach.ResetText();
            txtMadocgia.ResetText();
            dtNgaytra.ResetText();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                dtgDatra.DataSource = ptBUS.GetList();

            }
            else
            {
                if (radMasach.Checked == true)
                    dtgDatra.DataSource = ptBUS.TimKiem(txtTimkiem.Text, "MaSach");
                else if (radDocgia.Checked == true)
                    dtgDatra.DataSource = ptBUS.TimKiem(txtTimkiem.Text, "MaDocGia");
                else if (radNgaytra.Checked == true)
                    dtgDatra.DataSource = ptBUS.TimKiem(txtTimkiem.Text, "NgayTra");

            }
        }
        public void bigdings()
        {
            txtMasach.DataBindings.Clear();
            txtMasach.DataBindings.Add("text", dtgDatra.DataSource, "MaSach");

            txtMaphieu.DataBindings.Clear();
            txtMaphieu.DataBindings.Add("text", dtgDatra.DataSource, "MaPhieu");

            txtMadocgia.DataBindings.Clear();
            txtMadocgia.DataBindings.Add("text", dtgDatra.DataSource, "MaDocGia");

            dtNgaytra.DataBindings.Clear();
            dtNgaytra.DataBindings.Add("text", dtgDatra.DataSource, "NgayTra");
        }
    }
}
