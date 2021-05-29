using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.BUS;

namespace QuanLyThuVien.GUI
{
    public partial class fLichSuMuon : Form
    {
        LichSuMuon_BUS lsmBus = new LichSuMuon_BUS();
        private string tdn;
        public fLichSuMuon()
        {
            InitializeComponent();
            //tdn = _tdn;
        }
        private void fLichSuMuon_Load(object sender, EventArgs e)
        {
            dtgLichsumuon.DataSource = lsmBus.GetList(tdn);
        }
        private void txtTimTenSach_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTimtensach.Text == "")
            {
                dtgLichsumuon.DataSource = lsmBus.GetList(tdn);
            }
            else
                dtgLichsumuon.DataSource = lsmBus.TimKiem(txtTimtensach.Text, tdn);
        }

    }
}
