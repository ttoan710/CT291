using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace QLHS
{
    class function
    {
        public static int mau = 1;
        //public static string _backcolor_day = "DarkTurquoise";
        //public static string _backgroundcolor_day = "Gainsboro";
        public static string _backcolor_day = "DodgerBlue";
        public static string _backgroundcolor_day = "AliceBlue";
        public static string _dataGridViewcolor_day = "Info";
        public static string _backcolor_night = "LightSlateGray";
        public static string _backgroundcolor_night = "MenuText";
        public static string _dataGridViewcolor_night = "DarkGray";
        
        public void connect(SqlConnection conn)
        {
            if (conn.State != ConnectionState.Open)
            {
                string chuoiketnoi = "SERVER=asus; database=QuanLiDiem; Integrated Security=true";
                conn.ConnectionString = chuoiketnoi;
                conn.Open();
            }
        }
        public void HienThiDLDG(DataGridView dg, string sql, SqlConnection conn)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "new data");

            dg.DataSource = dataset;
            dg.DataMember = "new data";
        }

        public void HienThiDLComb(ComboBox comb, string sql, SqlConnection conn, string hienthi, string giatri)
        {
            SqlCommand comd = new SqlCommand(sql, conn);
            SqlDataReader reader = comd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);

            comb.DataSource = table;
            comb.DisplayMember = hienthi;
            comb.ValueMember = giatri;
        }
        public void capnhat(string sql, SqlConnection conn)
        {
            MessageBox.Show(sql);
            SqlCommand comd = new SqlCommand(sql, conn);
            try
            {
                comd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("your query is :" + sql + " with the error is " + e.Message);
            }
        }



    }
}
