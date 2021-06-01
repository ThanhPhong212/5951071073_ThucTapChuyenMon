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
            dtgQLphieumuon.DataSource = pmBUS.GetList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //lb_exist.Visible = false;
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
                    //_pM.NgayMuon = dtNgaymuon.Date;
                //if (d.Text == "")
                    _pM.NgayPhaiTra = DateTime.Now;
                //else
                //    _pM.NgayPhaiTra = d_NM.DateTime;

                //int check = pmBUS.Them(_pM);

               // if (check == -1)
                  //  lb_Trung.Visible = true;
               // else
                //    ucFrmQLPhieuMuon_Load(sender, e);
            }
            else
            {
               // lb_ChuaNhap.Visible = false;
               // lb_exist.Visible = true;
                //lb_Trung.Visible = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaphieu.Text != "")
            {
                pmBUS.Xoa(txtMaphieu.Text);
                fQLPhieuMuon_Load(sender, e);
            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                dtgQLphieumuon.DataSource = pmBUS.GetList();

            }
            else
            {
                if (radMasach.Checked == true)
                    dtgQLphieumuon.DataSource = pmBUS.TimKiem(txtTimkiem.Text, "MaSach");
                else if (radMadocgia.Checked == true)
                    dtgQLphieumuon.DataSource = pmBUS.TimKiem(txtTimkiem.Text, "MaDocGia");
                else if (radNgaymuon.Checked == true)
                    dtgQLphieumuon.DataSource = pmBUS.TimKiem(txtTimkiem.Text, "NgayMuon");
            }
        }

        private void dtgQLphieumuon_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgQLphieumuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgQLphieumuon.CurrentRow.Index;
            txtMaphieu.Text = dtgQLphieumuon.Rows[i].Cells[0].Value.ToString();
        }
    }
}
