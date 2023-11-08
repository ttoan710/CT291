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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLHS
{
    public partial class Form_Print : Form
    {
        public SqlConnection conn = new SqlConnection();
        function ham = new function();
        public Form_Print()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form_Home h = new Form_Home();
            h.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_Print_Load(object sender, EventArgs e)
        {
            ham.connect(conn);
           // string sql = "SELECT  HocSinh.HoTen     MonHoc.TenMonHoc,    HocKy.TenHocKy,   Diem.DiemMieng,      Diem.Diem15Phut,       Diem.Diem1Tiet,      Diem.DiemThi,        ROUND( AVG((DiemMieng + Diem15Phut + Diem1Tiet*2 + DiemThi*3) / 7),2) AS DiemTrungBinh FROM Diem INNER JOIN MonHoc ON Diem.MaMon = MonHoc.MaMonHoc,HocKy  WHERE Diem.MaHocKy = HocKy.MaHocKy AND  Diem.MaHocKy = 'HK001' OR  Diem.MaHocKy = 'HK002' GROUP BY Diem.MaDiem, MonHoc.TenMonHoc, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi, HocKy.TenHocKy ORDER BY  HocKy.TenHocKy;";
          //  ham.HienThiDLDG(dataGridView1, sql, conn);
        }
    }
}
