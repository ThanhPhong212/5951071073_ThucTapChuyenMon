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
    public partial class fTimKiemSach : Form
    {
        Sach_BUS sachBUS = new Sach_BUS();

        public fTimKiemSach()
        {
            InitializeComponent();
        }

        private void fTimKiemSach_Load(object sender, EventArgs e)
        {
            dtgTimsach.DataSource = sachBUS.GetList();
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
    }
}
