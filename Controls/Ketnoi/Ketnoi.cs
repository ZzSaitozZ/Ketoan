using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ketoan.Controls.Ketnoi
{
   public class Ketnoi
    {
         SqlConnection conn = null;
            SqlDataReader rdr = null;

        //     conn = new SqlConnection("Server=.;DataBase=ketoan;Integrated Security=True")"Server=Ha;DataBase=ketoan;User ID=sa;password=123";
        string ketnoi = "Server =Ha; DataBase = EWON; Integrated Security = True";
           public SqlConnection connection()
        {
            conn = new SqlConnection(ketnoi);

            return conn;
        }
        public SqlDataReader showDMNV()
        {
            conn = connection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("InsertUpdateDeleteDMNV", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manhanvien", SqlDbType.NVarChar).Value = DBNull.Value;
            cmd.Parameters.AddWithValue("@mabophan", SqlDbType.NVarChar).Value = DBNull.Value;
            cmd.Parameters.AddWithValue("@ngaysinh", SqlDbType.NVarChar).Value = DBNull.Value;
            cmd.Parameters.AddWithValue("@socmnd", SqlDbType.NVarChar).Value = DBNull.Value;
            cmd.Parameters.AddWithValue("@dienthoai", SqlDbType.NVarChar).Value = DBNull.Value;
            cmd.Parameters.AddWithValue("@diachi", SqlDbType.NVarChar).Value = DBNull.Value;
            cmd.Parameters.AddWithValue("@email", SqlDbType.NVarChar).Value = DBNull.Value;
            cmd.Parameters.AddWithValue("@chucvu", SqlDbType.NVarChar).Value = DBNull.Value;
            cmd.Parameters.AddWithValue("@StatementType", SqlDbType.NVarChar).Value = "Select";


            rdr = cmd.ExecuteReader();
           // conn.Close();

            return rdr;
        }






    }
}
