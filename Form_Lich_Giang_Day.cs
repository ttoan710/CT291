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
        public Form_Lich_Giang_Day()
        {
            InitializeComponent();
        }

       
       

        private void Form_Lich_Giang_Day_Load(object sender, EventArgs e)
        {
            ham.connect(conn);
            ham.HienThiDLDG(dataGridView1, " SELECT pc.MaPhanCong, gv.HoTen, mh.TenMonHoc, l.TenLop   " +
                " FROM PhanCong pc, GiaoVien gv, MonHoc mh, Lop l " +
                "where pc.MaGiaoVien = gv.MaGiaoVien " +
                "AND gv.MaMon = mh.MaMonHoc " +
                "AND pc.MaLop = l.MaLop", conn);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
