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
    public partial class fDatra : Form
    {
        DaTra_BUS dtBus = new DaTra_BUS();
        public fDatra()
        {
            InitializeComponent();
        }

        private void fDatra_Load(object sender, EventArgs e)
        {
            dtgDatra.DataSource = dtBus.GetList();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                dtgDatra.DataSource = dtBus.GetList();

            }
            else
            {
                if (radHoten.Checked == true)
                    dtgDatra.DataSource = dtBus.TimKiem(txtTimkiem.Text, "HoTen");
                else if (radTensach.Checked == true)
                    dtgDatra.DataSource = dtBus.TimKiem(txtTimkiem.Text, "TenSach");
            }
        }
    }
}
