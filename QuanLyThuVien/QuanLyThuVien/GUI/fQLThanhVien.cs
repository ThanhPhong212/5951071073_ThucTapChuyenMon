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
    public partial class fQLThanhVien : Form
    {
        DocGia_BUS docGiaBUS = new DocGia_BUS();
        ThanhVien_BUS tvBUS = new ThanhVien_BUS();
        public fQLThanhVien()
        {
            InitializeComponent();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lb_MDG.Visible = false;
            lb_Trung.Visible = false;

            DocGia dg = new DocGia();
            Random rdm = new Random();
            dg.MaDocGia = rdm.Next(0, 1000).ToString();
            dg.HoTen = txtHoten.Text;
            dg.DiaChi = txtDiachi.Text;
            dg.GioiTinh = txtGioitinh.Text;
            if (dtNgaysinh.Text == "")
                dg.NamSinh = DateTime.Now;
            else
                dg.NamSinh = dtNgaysinh.Value;
            //kiem tra loi madocgia
            int check = docGiaBUS.Them(dg);
            if (check == 0)
                lb_MDG.Visible = true;
            else if (check == -1)
                lb_Trung.Visible = true;
            //load lai
            fQLThanhVien_Load(sender, e);
        }
        public void ResetData()
        {
            txtMadocgia.ResetText();
            txtHoten.ResetText();
            txtDiachi.ResetText();
            txtGioitinh.ResetText();
            dtNgaysinh.ResetText();
        }

        private void fQLThanhVien_Load(object sender, EventArgs e)
        {
            ResetData();
            dtgQLTV.DataSource = docGiaBUS.GetList();
            bingding();
        }
        public void bingding()
        {
            txtMadocgia.DataBindings.Clear();
            txtMadocgia.DataBindings.Add("text",dtgQLTV.DataSource, "MaDocGia");

            txtHoten.DataBindings.Clear();
            txtHoten.DataBindings.Add("text", dtgQLTV.DataSource, "HoTen");


            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("text", dtgQLTV.DataSource, "DiaChi");

            txtGioitinh.DataBindings.Clear();
            txtGioitinh.DataBindings.Add("text", dtgQLTV.DataSource, "GioiTinh");

            dtNgaysinh.DataBindings.Clear();
            dtNgaysinh.DataBindings.Add("text", dtgQLTV.DataSource, "NamSinh");
        }

        private void txtTimdocgia_TextChanged(object sender, EventArgs e)
        {
            if (txtTimdocgia.Text == "")
            {
                dtgQLTV.DataSource = docGiaBUS.GetList();
            }
            else
                dtgQLTV.DataSource = docGiaBUS.TimKiem(txtTimdocgia.Text);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            lb_MDG.Visible = false;
            lb_Trung.Visible = false;
            DocGia dg = new DocGia();
            dg.MaDocGia = txtMadocgia.Text;
            dg.HoTen = txtHoten.Text;
            dg.DiaChi = txtDiachi.Text;
            dg.GioiTinh = txtGioitinh.Text;
            dg.NamSinh = dtNgaysinh.Value;
            //kiem tra loi madocgia
            if (!docGiaBUS.Sua(dg))
                lb_MDG.Visible = true;
            //load lai
            fQLThanhVien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMadocgia.Text != "")
            {
                docGiaBUS.Xoa(txtMadocgia.Text);
                fQLThanhVien_Load(sender, e);
            }
        }
    }
}
