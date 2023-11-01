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
            string sql = "SELECT Diem.MaHocSinh, HocSinh.HoTen, AVG(DiemTrungBinh) AS MaHocSinhDiemTrungBinhTong,     CASE       WHEN AVG(DiemTrungBinh) >= 9 THEN N'Xuất săc'         WHEN AVG(DiemTrungBinh) >= 8 AND AVG(DiemTrungBinh) < 9 THEN N'Giỏi'        WHEN AVG(DiemTrungBinh) >= 7 AND AVG(DiemTrungBinh) < 8 THEN N'Khá'          WHEN AVG(DiemTrungBinh) >= 5 AND AVG(DiemTrungBinh) < 7 THEN N'Trung bình'                 ELSE N'Yếu'         END AS XepLoai FROM (  SELECT (DiemMieng + Diem15Phut + Diem1Tiet + DiemThi) / 4 AS DiemTrungBinh, Diem.MaHocSinh, HocSinh.HoTen    FROM Diem   JOIN HocSinh ON Diem.MaHocSinh = HocSinh.MaHocSinh) AS DiemTrungBinhCacMon, Diem,HocSinh where Diem.MaHocSinh = HocSinh.MaHocSinh GROUP BY Diem.MaHocSinh, HocSinh.HoTen;";
            ham.HienThiDLDG(dataGridView1, sql, conn);
        }
    }
}
