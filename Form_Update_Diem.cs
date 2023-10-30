using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLHS
{
    public partial class Form_Update_Diem : Form
    {
        public SqlConnection conn = new SqlConnection();
        function ham = new function();

        public Form_Update_Diem()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form_Home fh = new Form_Home();
            fh.ShowDialog();
        }

        private void print_Click(object sender, EventArgs e)
        {
            Form_Print fp = new Form_Print();
            fp.ShowDialog();
        }

        private void update_thongtin_Click(object sender, EventArgs e)
        {
            Form_Update_ThongTin tt = new Form_Update_ThongTin();
            tt.ShowDialog();
        }






        private void Form_Update_Diem_Load(object sender, EventArgs e)
        {
            ham.connect(conn);
            ham.HienThiDLDG(dataGridView1, "SELECT D.MaHocSinh, H.HoTen AS HoTenHocSinh, D.MaMon, GV.HoTen AS HoTenGiaoVien, HK.TenHocKy, D.DiemMieng, D.Diem15Phut, D.Diem1Tiet," +
                " D.DiemThi FROM Diem D JOIN HocSinh H ON D.MaHocSinh = H.MaHocSinh JOIN HocKy HK ON D.MaHocKy = HK.MaHocKy JOIN GiaoVien GV ON D.MaMon = GV.MaMon;", conn);
            ham.HienThiDLComb(cb_gv, "SELECT MAGIAOVIEN, HoTen FROM GIAOVIEN", conn, "HoTen", "MAGIAOVIEN");
            ham.HienThiDLComb(cb_hoc_ky, "SELECT MAHOCKY, TENHOCKY FROM HOCKY", conn, "TENHOCKY", "MAHOCKY");
            ham.HienThiDLComb(cb_mon, "SELECT MaMonHoc, TenMonHoc FROM MonHoc", conn, "TenMonHoc", "MaMonHoc");
            ham.HienThiDLComb(cb_loai_diem, "SELECT MALOAIDiem, TENLOAIDiem FROM LoaiDiem", conn, "TENLOAIDiem", "MALOAIDiem");

           
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string ma_lon_nhat = "select Max (SUBSTRING(MaDiem,3,3)) from DIEM";
            SqlCommand comd = new SqlCommand(ma_lon_nhat, conn);
            SqlDataReader reader = comd.ExecuteReader();

            if (reader.Read())
            {
                int max = Convert.ToInt16(reader.GetValue(0).ToString()) + 1;
                if (max < 10)
                {
                    txt_ma_diem.Text = "MD00" + max;
                }
                else
                {
                    txt_ma_diem.Text = "MD0" + max;
                }
                txt_ma_diem.Enabled = false;
            }
            string maDiem = txt_ma_diem.Text;
            string maHocSinh = txt_ma_hs.Text;
            string maMon = cb_mon.SelectedValue.ToString();
            string maGiaoVien = cb_gv.SelectedValue.ToString();
            string maHocKy = cb_hoc_ky.SelectedValue.ToString();
            string loaiDiem = cb_loai_diem.SelectedValue.ToString();
            string diem = txt_diem.Text;


            string query = "INSERT INTO MATHANG VALUES ('" + maDiem + "','" + maHocSinh + "'," + maMon + ",'" + maGiaoVien + "','" + maHocKy + "')";
            string query2 = "UPDATE Diem SET '"+ loaiDiem + "' = "+ diem + "'";

            ham.capnhat(query, conn);
            ham.capnhat(query2, conn);
            ham.HienThiDLDG(dataGridView1, "SELECT D.MaHocSinh, H.HoTen AS HoTenHocSinh, D.MaMon, GV.HoTen AS HoTenGiaoVien, HK.TenHocKy, D.DiemMieng, D.Diem15Phut, D.Diem1Tiet," +
                " D.DiemThi FROM Diem D JOIN HocSinh H ON D.MaHocSinh = H.MaHocSinh JOIN HocKy HK ON D.MaHocKy = HK.MaHocKy JOIN GiaoVien GV ON D.MaMon = GV.MaMon;", conn);
        }
    }
}
      
