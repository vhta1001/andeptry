using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class QLNguoiDung
    {
        public int CheckConfig()
        {
            if (Properties.Settings.Default.cnn == string.Empty)
                return 1;
            SqlConnection sqlcnn = new SqlConnection(Properties.Settings.Default.cnn);
            try
            {
                if (sqlcnn.State == System.Data.ConnectionState.Closed)
                    sqlcnn.Open();
                return 0;
            }
            catch
            {
                return 0;
            }
        }
        public int checkUser(string pUser, string pPassword)
        {
            SqlDataAdapter da_user = new SqlDataAdapter("select * from qlnguoidung where tenddangnhap = '" + pUser + " and matkhau ='" + pPassword + "'", Properties.Settings.Default.cnn);
            DataTable data_user = new DataTable();
            da_user.Fill(data_user);
            if (data_user.Rows.Count == 0)
                return 1;
            else if()
            
        }
    }
}
