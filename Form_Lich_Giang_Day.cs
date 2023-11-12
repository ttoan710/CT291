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
    public partial class Form_Lich_Giang_Day : Form
    {
        public SqlConnection conn = new SqlConnection();
        function ham = new function();
        string teachername;
        public Form_Lich_Giang_Day(string teachernamne)
        {
            InitializeComponent();
            this.teachername = teachernamne;
        }
       



        private void Form_Lich_Giang_Day_Load(object sender, EventArgs e)
        {
            ham.connect(conn);
            ham.HienThiDLDG(dataGridView1, " SELECT pc.MaPhanCong, gv.HoTen, mh.TenMonHoc, l.TenLop   " +
                " FROM PhanCong pc, GiaoVien gv, MonHoc mh, Lop l " +
                "where pc.MaGiaoVien = gv.MaGiaoVien " +
                "AND gv.MaMon = mh.MaMonHoc " +
                "AND pc.MaLop = l.MaLop", conn);

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

        private void logout_Click(object sender, EventArgs e)
        {
           
                Form_Home1 fh = new Form_Home1(this.teachername);
                this.Hide();
                fh.ShowDialog();
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
