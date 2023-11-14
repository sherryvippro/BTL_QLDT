using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon
{
    internal class DatabaseProcess
    {
		string strConnect = "Data Source=DuongHang;DataBase=QLDT;User ID=sa;Password=123;Integrated Security=false";

		SqlConnection conn = null;
        public void OpenConn()
        {
            conn = new SqlConnection(strConnect);
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
        }
        public void CloseConn()
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
                conn.Dispose();
            }
        }
        public DataTable Select(string sql)
        {
            DataTable TableReader = new DataTable();
            OpenConn();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(TableReader);
            CloseConn();
            return TableReader;
        }
        public void Update(string sql)
        {
            OpenConn();
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.ExecuteNonQuery();
            CloseConn();
        }
        public string SinhMaTuDong(string TenBang, string TruongMa, string MaBatDau)
        {
            string ma = "";

            // Tìm hóa đơn có mã cao nhất trong cơ sở dữ liệu
            DataTable dm = Select("SELECT MAX(" + TruongMa + ") FROM " + TenBang);

            if (dm.Rows.Count > 0 && !string.IsNullOrEmpty(dm.Rows[0][0].ToString()))
            {
                // Lấy mã cao nhất hiện tại
                string maCaoNhat = dm.Rows[0][0].ToString();

                // Tách phần số từ mã hiện tại và tăng giá trị lên 1
                int soHienTai = int.Parse(maCaoNhat.Substring(MaBatDau.Length));
                soHienTai++;

                // Tạo mã mới dựa trên số vừa tăng và định dạng mẫu
                ma = MaBatDau + soHienTai.ToString("00");
            }
            else
            {
                // Nếu không tìm thấy hóa đơn nào, tạo mã mới bắt đầu từ "HDB1"
                ma = MaBatDau + "01";
            }

            return ma;
        }
    }
}
