using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS
{
    public partial class Form_Phan_Hoi : Form
    {
        public SqlConnection conn = new SqlConnection();
        function ham = new function();
        public Form_Phan_Hoi()
        {
            InitializeComponent();
        }

        private void Form_Phan_Hoi_Load(object sender, EventArgs e)
        {
            ham.connect(conn);
            ham.HienThiDLDG(dataGridView1, " select ph.MaPhanHoi,  hs.HoTen,l.tenlop, ph.PhanHoi from Lop l, PhanHoi ph, HocSinh hs where hs.MaHocSinh = ph.MaHocSinh And hs.MaLop = l.MaLop", conn);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ma.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string maDiem = txt_ma.Text;
            string query = "DELETE From PhanHoi Where MaPhanHoi = '" + maDiem + "'";
            ham.capnhat(query, conn);
            ham.HienThiDLDG(dataGridView1, " select ph.MaPhanHoi,  hs.HoTen,l.tenlop, ph.PhanHoi from Lop l, PhanHoi ph, HocSinh hs where hs.MaHocSinh = ph.MaHocSinh And hs.MaLop = l.MaLop", conn);
            
        }
    }
}
