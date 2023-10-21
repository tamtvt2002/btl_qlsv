using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.DAL
{
    class LopDAL : Interface.InterfaceLop
    {
        DAL.DBConnectionSQL dbc = new DBConnectionSQL();
        SqlCommand cmd;

        public DataTable LoadData()
        {
            DataTable dt = new DataTable("Lop");
            try
            {
                SqlConnection conn = dbc.Connect();
                conn.Open();
                cmd = new SqlCommand("Exec sp_AllLop ", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }
            catch { }
            return dt;
        }

        public bool SuaLop(DTO.LopDTO dtolop)
        {
            SqlConnection conn = dbc.Connect();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_UpdateLop ", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Malop", dtolop.Malop);
                cmd.Parameters.AddWithValue("@Tenlop", dtolop.Tenlop);
                cmd.Parameters.AddWithValue("@Course", dtolop.Course);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool ThemLop(DTO.LopDTO dtolop)
        {
            SqlConnection conn = dbc.Connect();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_AddLop", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Malop", dtolop.Malop);
                cmd.Parameters.AddWithValue("@Tenlop", dtolop.Tenlop);
                cmd.Parameters.AddWithValue("@Course", dtolop.Course);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
