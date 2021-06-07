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

namespace QuanLyThuVien.GUI
{
    public partial class fDangMuon : Form
    {
        DangMuon_BUS dmBus = new DangMuon_BUS();
        public fDangMuon()
        {
            InitializeComponent();
        }

        private void fDangMuon_Load(object sender, EventArgs e)
        {
            dtgDangmuon.DataSource = dmBus.GetList();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                dtgDangmuon.DataSource = dmBus.GetList();

            }
            else
            {
                if (radHoten.Checked == true)
                    dtgDangmuon.DataSource = dmBus.TimKiem(txtTimkiem.Text, "HoTen");
                else if (radTensach.Checked == true)
                    dtgDangmuon.DataSource = dmBus.TimKiem(txtTimkiem.Text, "TenSach");
            }
        }
    }
}
