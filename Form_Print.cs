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
           
                Form_Home1 h = new Form_Home1(teachername);
                this.Hide();
                h.ShowDialog();
           
            
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
            ham.HienThiDLComb(cb_lop, "SELECT TenLop, MaLop FROM Lop  " , conn, "TenLop", "MaLop");
           
                  
            int mau = function.mau;
            if (mau == 1)
            {
                this.groupBox4.ForeColor = System.Drawing.Color.FromName(function._backgroundcolor_day);
                this.groupBox2.BackColor = System.Drawing.Color.FromName(function._backcolor_day);
                this.groupBox3.BackColor = System.Drawing.Color.FromName(function._backcolor_day);
                this.groupBox4.BackColor = System.Drawing.Color.FromName(function._backgroundcolor_day);
                this.dataGridView1.BackgroundColor = System.Drawing.Color.FromName(function._dataGridViewcolor_day);
                this.BackColor = System.Drawing.Color.FromName(function._backgroundcolor_day);

            }
            else
            {
                this.groupBox4.ForeColor = System.Drawing.Color.FromName(function._backgroundcolor_day);
                this.groupBox2.BackColor = System.Drawing.Color.FromName(function._backcolor_night);
                this.groupBox3.BackColor = System.Drawing.Color.FromName(function._backcolor_night);
                this.groupBox4.BackColor = System.Drawing.Color.FromName(function._backgroundcolor_night);
                this.dataGridView1.BackgroundColor = System.Drawing.Color.FromName(function._dataGridViewcolor_night);
                this.BackColor = System.Drawing.Color.FromName(function._backgroundcolor_night);

            }
        }
        private void btn_hk_Click(object sender, EventArgs e)
        {
            string hk1 = "Hoc Kỳ 1";
            string hk2 = "Học Kỳ 2";
            string hk = cb_hk.Text;
             string lop = cb_lop.SelectedValue.ToString();
            
            // lấy mã lớp của giáo viên đăng nhập 
             string temon = "SELECT MaLop FROM GiaoVien  Where GiaoVien.MaGiaoVien ='" + teachername + "'";
             SqlCommand comd = new SqlCommand(temon, conn);
             SqlDataReader reader = comd.ExecuteReader();

             if (reader.Read())
              {
                  string maLop = reader["MaLop"].ToString();
                reader.Close();
                if (hk == hk1 && lop == maLop)
                 { 
                    // nếu là lớp mình thì hiện ra hết tất cả điểm và tất cả môn 
                     ham.HienThiDLDG(dataGridView1, "SELECT HocSinh.HoTen, MonHoc.TenMonHoc,Lop.TenLop, HocKy.TenHocKy, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi, ROUND( AVG((DiemMieng + Diem15Phut + Diem1Tiet*2 + DiemThi*3) / 7),2) AS DiemTrungBinh   " +
                         "FROM Diem   " +
                         "INNER JOIN MonHoc ON Diem.MaMon = MonHoc.MaMonHoc   " +
                         "INNER JOIN HocKy ON Diem.MaHocKy = HocKy.MaHocKy   " +
                         "INNER JOIN HocSinh ON HocSinh.MaHocSinh = Diem.MaHocSinh   " +
                         "INNER JOIN Lop ON Lop.MaLop = HocSinh.MaLop   " +
                         "WHERE Diem.MaHocKy = 'HK001'    AND Lop.MaLop = '"+lop+"'  " +
                         "GROUP BY HocSinh.HoTen,HocSinh.MaLop, MonHoc.TenMonHoc, HocKy.TenHocKy, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi,Lop.TenLop   " +
                         "ORDER BY HocKy.TenHocKy", conn);
                }
               else if (hk == hk1 && lop != maLop)
                {   
                    // Nếu không phải lớp mình chủ nhiệm thì chỉ hiện ra điểm môn mình có dạy 
                      ham.HienThiDLDG(dataGridView1, "SELECT HocSinh.HoTen, MonHoc.TenMonHoc,Lop.TenLop, HocKy.TenHocKy, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi, ROUND( AVG((DiemMieng + Diem15Phut + Diem1Tiet*2 + DiemThi*3) / 7),2) AS DiemTrungBinh   " +
                          "FROM Diem   INNER JOIN MonHoc ON Diem.MaMon = MonHoc.MaMonHoc   " +
                          "INNER JOIN HocKy ON Diem.MaHocKy = HocKy.MaHocKy   INNER JOIN HocSinh ON HocSinh.MaHocSinh = Diem.MaHocSinh   " +
                          "INNER JOIN GiaoVien ON GiaoVien.MaMon = Diem.MaMon   INNER JOIN Lop ON GiaoVien.MaLop = Lop.MaLop   WHERE Diem.MaHocKy = 'HK001'   " +
                          "AND GiaoVien.MaGiaoVien = '"+teachername+"'   AND Lop.MaLop = '"+lop+"'  " +
                          "GROUP BY Lop.TenLop,HocSinh.HoTen, MonHoc.TenMonHoc, HocKy.TenHocKy, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi   " +
                          "ORDER BY HocKy.TenHocKy", conn);
                }
                else if (hk == hk2 && lop == maLop)
                 {
                    ham.HienThiDLDG(dataGridView1, "SELECT HocSinh.HoTen, MonHoc.TenMonHoc,Lop.TenLop, HocKy.TenHocKy, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi, ROUND( AVG((DiemMieng + Diem15Phut + Diem1Tiet*2 + DiemThi*3) / 7),2) AS DiemTrungBinh   FROM Diem   INNER JOIN MonHoc ON Diem.MaMon = MonHoc.MaMonHoc   INNER JOIN HocKy ON Diem.MaHocKy = HocKy.MaHocKy   INNER JOIN HocSinh ON HocSinh.MaHocSinh = Diem.MaHocSinh   INNER JOIN Lop ON Lop.MaLop = HocSinh.MaLop   WHERE Diem.MaHocKy = 'HK002'    AND Lop.MaLop = '" + lop + "'  GROUP BY HocSinh.HoTen,HocSinh.MaLop, MonHoc.TenMonHoc, HocKy.TenHocKy, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi,Lop.TenLop   ORDER BY HocKy.TenHocKy", conn);
                }
                else if (hk == hk2 && lop != maLop)
                 {
                    ham.HienThiDLDG(dataGridView1, "SELECT HocSinh.HoTen, MonHoc.TenMonHoc,Lop.TenLop, HocKy.TenHocKy, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi, ROUND( AVG((DiemMieng + Diem15Phut + Diem1Tiet*2 + DiemThi*3) / 7),2) AS DiemTrungBinh   FROM Diem   INNER JOIN MonHoc ON Diem.MaMon = MonHoc.MaMonHoc   INNER JOIN HocKy ON Diem.MaHocKy = HocKy.MaHocKy   INNER JOIN HocSinh ON HocSinh.MaHocSinh = Diem.MaHocSinh   INNER JOIN GiaoVien ON GiaoVien.MaMon = Diem.MaMon   INNER JOIN Lop ON GiaoVien.MaLop = Lop.MaLop   WHERE Diem.MaHocKy = 'HK002'   AND GiaoVien.MaGiaoVien = '"+teachername+ "'   AND Lop.MaLop = '"+lop+"'  GROUP BY Lop.TenLop,HocSinh.HoTen, MonHoc.TenMonHoc, HocKy.TenHocKy, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi   ORDER BY HocKy.TenHocKy", conn);
                  }
                 else if(hk == "Tất cả")
                  {
                  if(lop == maLop)
                    {
                        ham.HienThiDLDG(dataGridView1, "SELECT HocSinh.HoTen, MonHoc.TenMonHoc,Lop.TenLop, HocKy.TenHocKy, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi, ROUND( AVG((DiemMieng + Diem15Phut + Diem1Tiet*2 + DiemThi*3) / 7),2) AS DiemTrungBinh   " +
                            "FROM Diem   " +
                            "INNER JOIN MonHoc ON Diem.MaMon = MonHoc.MaMonHoc   " +
                            "INNER JOIN HocKy ON Diem.MaHocKy = HocKy.MaHocKy   " +
                            "INNER JOIN HocSinh ON HocSinh.MaHocSinh = Diem.MaHocSinh   " +
                            "INNER JOIN Lop ON Lop.MaLop = HocSinh.MaLop   " +
                            "WHERE (Diem.MaHocKy = 'HK001' OR Diem.MaHocKy = 'HK002')    " +
                            "AND Lop.MaLop = '"+lop+"'  " +
                            "GROUP BY HocSinh.HoTen,HocSinh.MaLop, MonHoc.TenMonHoc, HocKy.TenHocKy, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi,Lop.TenLop   " +
                            "ORDER BY HocKy.TenHocKy", conn);
                    }

                    else
                    {
                        ham.HienThiDLDG(dataGridView1, "SELECT HocSinh.HoTen, MonHoc.TenMonHoc,Lop.TenLop, HocKy.TenHocKy, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi, ROUND( AVG((DiemMieng + Diem15Phut + Diem1Tiet*2 + DiemThi*3) / 7),2) AS DiemTrungBinh   " +
                            "FROM Diem   " +
                            "INNER JOIN MonHoc ON Diem.MaMon = MonHoc.MaMonHoc   " +
                            "INNER JOIN HocKy ON Diem.MaHocKy = HocKy.MaHocKy   " +
                            "INNER JOIN HocSinh ON HocSinh.MaHocSinh = Diem.MaHocSinh   " +
                            "INNER JOIN GiaoVien ON GiaoVien.MaMon = Diem.MaMon   " +
                            "INNER JOIN Lop ON GiaoVien.MaLop = Lop.MaLop   " +
                            "WHERE (Diem.MaHocKy = 'HK001' OR Diem.MaHocKy = 'HK002') " +
                            "AND  Lop.MaLop = '" + lop + "'  " +
                           " AND GiaoVien.MaGiaoVien = '" + teachername+ "' " +
                            "GROUP BY Lop.TenLop,HocSinh.HoTen, MonHoc.TenMonHoc, HocKy.TenHocKy, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi   " +
                            "ORDER BY HocKy.TenHocKy", conn);

                    }

                 }
            }
            reader.Close();



        }

      
    }

       
    }

    

