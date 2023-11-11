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
        string strConnect = "Data Source=DuongHang;Initial Catalog=QLDT;User ID=sa; Password=123";
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
    }
}
