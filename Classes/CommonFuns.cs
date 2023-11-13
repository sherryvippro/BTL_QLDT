using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace BaiTapLon.Classes
{
    internal class CommonFuns
    {
        ConnectData data=new ConnectData();
        /* public string SinhMaTuDong(string TenBang, string MaBatDau, string TruongMa)
         {
             int id = 0;
             bool dung = false;
             string ma = "";
             DataTable dm = new DataTable();
             while (dung == false)
             {
                 dm = dataBase.ReadData("Select * from " + TenBang + " where " + TruongMa + "='" + MaBatDau +
                     id.ToString() + "'");
                 if (dm.Rows.Count == 0)
                 {
                     dung = true;
                 }
                 else
                 {
                     id++;
                     dung = false;
                 }
             }
             ma = MaBatDau + id.ToString();
             return ma;
         }*/
        public string SinhMaTuDong(string TenBang, string TruongMa, string MaBatDau)
        {
            string ma = "";

            // Tìm hóa đơn có mã cao nhất trong cơ sở dữ liệu
            DataTable dm = data.ReadData("SELECT MAX(" + TruongMa + ") FROM " + TenBang);

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
