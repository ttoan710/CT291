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
        string teachername;
        public Form_Print(string teachernamne)
        {
            InitializeComponent();
            this.teachername = teachernamne;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Form_Home1.IsFormOpenedFromHome1)
            {
                Form_Home1 h = new Form_Home1(teachername);

                h.ShowDialog();
            }
            else {
                Form_Home h = new Form_Home();

                h.ShowDialog();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void HocKyToComboBox()
        {
            cb_hk.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_hk.Items.Add("Hoc Kỳ 1");
            cb_hk.Items.Add("Học Kỳ 2");
            cb_hk.Items.Add("Tất cả");

        }
        private void Form_Print_Load(object sender, EventArgs e)
        {
            ham.connect(conn);
            HocKyToComboBox();
            if (Form_Home1.IsFormOpenedFromHome1)
            {
                ham.HienThiDLDG(dataGridView1, "SELECT HocSinh.HoTen, MonHoc.TenMonHoc, HocKy.TenHocKy, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi, ROUND( AVG((DiemMieng + Diem15Phut + Diem1Tiet*2 + DiemThi*3) / 7),2) AS DiemTrungBinh FROM Diem INNER JOIN MonHoc ON Diem.MaMon = MonHoc.MaMonHoc INNER JOIN HocKy ON Diem.MaHocKy = HocKy.MaHocKy INNER JOIN HocSinh ON HocSinh.MaHocSinh = Diem.MaHocSinh INNER JOIN GiaoVien ON GiaoVien.MaMon = Diem.MaMon \rWHERE Diem.MaHocKy = 'HK001' AND GiaoVien.MaGiaoVien = '"+teachername+"' GROUP BY HocSinh.HoTen, MonHoc.TenMonHoc, HocKy.TenHocKy, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi ORDER BY HocKy.TenHocKy         ", conn);
            }
            else
            {
                ham.HienThiDLDG(dataGridView1, "SELECT HocSinh.HoTen, MonHoc.TenMonHoc, HocKy.TenHocKy, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi, ROUND( AVG((DiemMieng + Diem15Phut + Diem1Tiet*2 + DiemThi*3) / 7),2) AS DiemTrungBinh FROM Diem INNER JOIN MonHoc ON Diem.MaMon = MonHoc.MaMonHoc INNER JOIN HocKy ON Diem.MaHocKy = HocKy.MaHocKy INNER JOIN HocSinh ON HocSinh.MaHocSinh = Diem.MaHocSinh WHERE Diem.MaHocKy = 'HK001' GROUP BY HocSinh.HoTen, MonHoc.TenMonHoc, HocKy.TenHocKy, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi ORDER BY HocKy.TenHocKy", conn);
            }
        }
        private void btn_hk_Click(object sender, EventArgs e)
        {
            string hk1 = "Hoc Kỳ 1";
            string hk2 = "Học Kỳ 2";
            string hk = cb_hk.Text;
            if (Form_Home1.IsFormOpenedFromHome1)
            {
                if (hk == hk1)
                {
                    ham.HienThiDLDG(dataGridView1, "SELECT HocSinh.HoTen, MonHoc.TenMonHoc, HocKy.TenHocKy, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi, ROUND( AVG((DiemMieng + Diem15Phut + Diem1Tiet*2 + DiemThi*3) / 7),2) AS DiemTrungBinh FROM Diem INNER JOIN MonHoc ON Diem.MaMon = MonHoc.MaMonHoc INNER JOIN HocKy ON Diem.MaHocKy = HocKy.MaHocKy INNER JOIN HocSinh ON HocSinh.MaHocSinh = Diem.MaHocSinh INNER JOIN GiaoVien ON GiaoVien.MaMon = Diem.MaMon WHERE Diem.MaHocKy = 'HK001' AND GiaoVien.MaGiaoVien = '" + teachername + "' GROUP BY HocSinh.HoTen, MonHoc.TenMonHoc, HocKy.TenHocKy, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi ORDER BY HocKy.TenHocKy         ", conn);
                }
                else if (hk == hk2)
                {
                    ham.HienThiDLDG(dataGridView1, "SELECT HocSinh.HoTen, MonHoc.TenMonHoc, HocKy.TenHocKy, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi, ROUND( AVG((DiemMieng + Diem15Phut + Diem1Tiet*2 + DiemThi*3) / 7),2) AS DiemTrungBinh FROM Diem INNER JOIN MonHoc ON Diem.MaMon = MonHoc.MaMonHoc INNER JOIN HocKy ON Diem.MaHocKy = HocKy.MaHocKy INNER JOIN HocSinh ON HocSinh.MaHocSinh = Diem.MaHocSinh INNER JOIN GiaoVien ON GiaoVien.MaMon = Diem.MaMon WHERE Diem.MaHocKy = 'HK002' AND GiaoVien.MaGiaoVien = '" + teachername + "' GROUP BY HocSinh.HoTen, MonHoc.TenMonHoc, HocKy.TenHocKy, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi ORDER BY HocKy.TenHocKy         ", conn);
                }
                else
                {
                    ham.HienThiDLDG(dataGridView1, "SELECT HocSinh.HoTen, MonHoc.TenMonHoc, HocKy.TenHocKy, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi, ROUND( AVG((DiemMieng + Diem15Phut + Diem1Tiet*2 + DiemThi*3) / 7),2) AS DiemTrungBinh FROM Diem INNER JOIN MonHoc ON Diem.MaMon = MonHoc.MaMonHoc INNER JOIN HocKy ON Diem.MaHocKy = HocKy.MaHocKy INNER JOIN HocSinh ON HocSinh.MaHocSinh = Diem.MaHocSinh  INNER JOIN GiaoVien ON GiaoVien.MaMon = Diem.MaMon WHERE Diem.MaHocKy IN ('HK001', 'HK002') AND GiaoVien.MaGiaoVien = '" + teachername + "' GROUP BY HocSinh.HoTen, MonHoc.TenMonHoc, HocKy.TenHocKy, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi ORDER BY HocKy.TenHocKy", conn);
                }
            }
            else {
                if (hk == hk1)
                {
                    ham.HienThiDLDG(dataGridView1, "SELECT HocSinh.HoTen, MonHoc.TenMonHoc, HocKy.TenHocKy, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi, ROUND( AVG((DiemMieng + Diem15Phut + Diem1Tiet*2 + DiemThi*3) / 7),2) AS DiemTrungBinh FROM Diem INNER JOIN MonHoc ON Diem.MaMon = MonHoc.MaMonHoc INNER JOIN HocKy ON Diem.MaHocKy = HocKy.MaHocKy INNER JOIN HocSinh ON HocSinh.MaHocSinh = Diem.MaHocSinh WHERE Diem.MaHocKy = 'HK001'  GROUP BY HocSinh.HoTen, MonHoc.TenMonHoc, HocKy.TenHocKy, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi ORDER BY HocKy.TenHocKy         ", conn);
                }
                else if (hk == hk2)
                {
                    ham.HienThiDLDG(dataGridView1, "SELECT HocSinh.HoTen, MonHoc.TenMonHoc, HocKy.TenHocKy, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi, ROUND( AVG((DiemMieng + Diem15Phut + Diem1Tiet*2 + DiemThi*3) / 7),2) AS DiemTrungBinh FROM Diem INNER JOIN MonHoc ON Diem.MaMon = MonHoc.MaMonHoc INNER JOIN HocKy ON Diem.MaHocKy = HocKy.MaHocKy INNER JOIN HocSinh ON HocSinh.MaHocSinh = Diem.MaHocSinh  WHERE Diem.MaHocKy = 'HK002'  GROUP BY HocSinh.HoTen, MonHoc.TenMonHoc, HocKy.TenHocKy, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi ORDER BY HocKy.TenHocKy         ", conn);
                }
                else
                {
                    ham.HienThiDLDG(dataGridView1, "SELECT HocSinh.HoTen, MonHoc.TenMonHoc, HocKy.TenHocKy, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi, ROUND( AVG((DiemMieng + Diem15Phut + Diem1Tiet*2 + DiemThi*3) / 7),2) AS DiemTrungBinh FROM Diem INNER JOIN MonHoc ON Diem.MaMon = MonHoc.MaMonHoc INNER JOIN HocKy ON Diem.MaHocKy = HocKy.MaHocKy INNER JOIN HocSinh ON HocSinh.MaHocSinh = Diem.MaHocSinh  WHERE Diem.MaHocKy IN ('HK001', 'HK002')  GROUP BY HocSinh.HoTen, MonHoc.TenMonHoc, HocKy.TenHocKy, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi ORDER BY HocKy.TenHocKy", conn);
                }
            }
        }
        }

    }

