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
        string teachername;
        
        public Form_Phan_Hoi(string teachernamne)
        {
            InitializeComponent();
            this.teachername = teachernamne;
        }

        private void Form_Phan_Hoi_Load(object sender, EventArgs e)
        {
            ham.connect(conn);
            ham.HienThiDLDG(dataGridView1, " select ph.MaPhanHoi,  hs.HoTen, l.tenlop, ph.PhanHoi " +
                "from Lop l, PhanHoi ph, HocSinh hs " +
                "where hs.MaHocSinh = ph.MaHocSinh " +
                "And hs.MaLop = l.MaLop", conn);


            int mau = function.mau;
            if (mau == 1)
            {
                this.groupBox1.BackColor = System.Drawing.Color.FromName(function._backcolor_day);
                this.dataGridView1.BackgroundColor = System.Drawing.Color.FromName(function._dataGridViewcolor_day);
                this.BackColor = System.Drawing.Color.FromName(function._backgroundcolor_day);

            }
            else
            {
                this.groupBox1.BackColor = System.Drawing.Color.FromName(function._backcolor_night);
                this.dataGridView1.BackgroundColor = System.Drawing.Color.FromName(function._dataGridViewcolor_night);
                this.BackColor = System.Drawing.Color.FromName(function._backgroundcolor_night);

            }
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
            ham.HienThiDLDG(dataGridView1, " select ph.MaPhanHoi,  hs.HoTen,l.tenlop, ph.PhanHoi " +
                "from Lop l, PhanHoi ph, HocSinh hs " +
                "where hs.MaHocSinh = ph.MaHocSinh " +
                "And hs.MaLop = l.MaLop", conn);
            txt_ma.Text = "";
            
        }

        private void logout_Click(object sender, EventArgs e)
        {
            if (Form_Home1.IsFormOpenedFromHome1)
            {
                Form_Home1 fh = new Form_Home1(this.teachername);
                this.Hide();
                fh.ShowDialog();
            }
            else
            {
                Form_Home fh = new Form_Home();
                this.Hide();
                fh.ShowDialog();
            }
        }
    }
}
