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
            string sql = "SELECT ROUND(AVG(DiemTrungBinh), 2) AS DiemTrungBinhTong,    CASE       WHEN ROUND(AVG(DiemTrungBinh), 2) >= 9 THEN N'Xuất sắc'      WHEN ROUND(AVG(DiemTrungBinh), 2) >= 8 AND ROUND(AVG(DiemTrungBinh), 2) < 9 THEN N'Giỏi'       WHEN ROUND(AVG(DiemTrungBinh), 2) >= 7 AND ROUND(AVG(DiemTrungBinh), 2) < 8 THEN N'Khá'      WHEN ROUND(AVG(DiemTrungBinh), 2) >= 5 AND ROUND(AVG(DiemTrungBinh), 2) < 7 THEN N'Trung bình'       ELSE N'Yếu'   END AS XepLoai FROM (    SELECT (DiemMieng + Diem15Phut + Diem1Tiet * 2 + DiemThi * 3) / 7 AS DiemTrungBinh   FROM Diem   WHERE Diem.MaHocKy = 'HK001') AS HK1;";
            ham.HienThiDLDG(dataGridView1, sql, conn);
        }
    }
}
