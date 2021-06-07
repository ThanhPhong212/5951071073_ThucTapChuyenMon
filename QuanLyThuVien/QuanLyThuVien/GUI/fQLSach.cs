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
{    public partial class fQLSach : Form
    {
        Sach_BUS sachBUS = new Sach_BUS();
        public fQLSach()
        {
            InitializeComponent();
        }

        private void fQLSach_Load(object sender, EventArgs e)
        {
            ResetData();
            dtgSach.DataSource = sachBUS.GetList();
            bigdings();
        }
        public void bigdings()
        {
            txtMasach.DataBindings.Clear();
            txtMasach.DataBindings.Add("text", dtgSach.DataSource, "MaSach");

            txtTensach.DataBindings.Clear();
            txtTensach.DataBindings.Add("text", dtgSach.DataSource, "TenSach");

            txtTacgia.DataBindings.Clear();
            txtTacgia.DataBindings.Add("text", dtgSach.DataSource, "TacGia");

            txtTheloai.DataBindings.Clear();
            txtTheloai.DataBindings.Add("text", dtgSach.DataSource, "TheLoai");

            txtNXB.DataBindings.Clear();
            txtNXB.DataBindings.Add("text", dtgSach.DataSource, "NhaXuatBan");

            txtGiasach.DataBindings.Clear();
            txtGiasach.DataBindings.Add("text", dtgSach.DataSource, "GiaSach");

            txtSoluong.DataBindings.Clear();
            txtSoluong.DataBindings.Add("text", dtgSach.DataSource, "SoLuong");

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
           
            Sach _s = new Sach();
            Random rdm = new Random();
            _s.MaSach = rdm.Next(0, 1000).ToString();
            _s.TenSach = txtTensach.Text;
            _s.TacGia = txtTacgia.Text;
            _s.NhaXuatBan = txtNXB.Text;
            _s.TheLoai = txtTheloai.Text;
            if (txtGiasach.Text != "")
                _s.GiaSach = int.Parse(txtGiasach.Text);
                _s.SoLuong = Convert.ToInt32(txtSoluong.Text);
            fQLSach_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMasach.Text != "")
            {
                sachBUS.Xoa(txtMasach.Text);
                fQLSach_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Sach _s = new Sach();
            _s.MaSach = txtMasach.Text;
            _s.TenSach = txtTensach.Text;
            _s.TacGia = txtTacgia.Text;
            _s.NhaXuatBan = txtNXB.Text;
            _s.TheLoai = txtTheloai.Text;
            if (txtGiasach.Text != "")
            _s.GiaSach = int.Parse(txtGiasach.Text);
            _s.SoLuong = Convert.ToInt32(txtSoluong.Text);
            if (!sachBUS.Sua(_s))
            {
                //lb_MDG.Visible = true;
            }
            fQLSach_Load(sender, e);
        }
        private void ResetData()
        {
            txtMasach.ResetText();
            txtTensach.ResetText();
            txtTheloai.ResetText();
            txtTacgia.ResetText();
            txtGiasach.ResetText();
            txtNXB.ResetText();
            txtSoluong.ResetText();
        }

        private void txtTimsach_TextChanged(object sender, EventArgs e)
        {
            if (txtTimsach.Text == "")
            {
                dtgSach.DataSource = sachBUS.GetList();
            }
            else
                dtgSach.DataSource = sachBUS.TimKiem(txtTimsach.Text, "MaSach");
        }
    }
}
