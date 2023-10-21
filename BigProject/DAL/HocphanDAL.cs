using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.DAL
{
    class HocphanDAL : Interface.InterfaceHocphan
    {
        DAL.DBConnectionSQL dbc = new DBConnectionSQL();
        SqlCommand cmd;
        
        public DataTable LoadData()
        {
            DataTable dt = new DataTable("Hocphan");
            try
            {
                SqlConnection conn = dbc.Connect();
                conn.Open();
                cmd = new SqlCommand("Exec sp_AllHocphan ", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }
            catch { }
            return dt;
        }

        public bool SuaHocphan(DTO.HocphanDTO dtohp)
        {
            SqlConnection conn = dbc.Connect();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_UpdateHocphan ", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mahocphan", dtohp.Mahocphan);
                cmd.Parameters.AddWithValue("@Tenhocphan", dtohp.Tenhocphan);
                cmd.Parameters.AddWithValue("@Sotinchi", dtohp.Sotinchi);
                cmd.Parameters.AddWithValue("@Kyhoc", dtohp.Kyhoc);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool ThemHocphan(DTO.HocphanDTO dtohp)
        {
            SqlConnection conn = dbc.Connect();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_AddHocphan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mahocphan", dtohp.Mahocphan);
                cmd.Parameters.AddWithValue("@Tenhocphan", dtohp.Tenhocphan);
                cmd.Parameters.AddWithValue("@Sotinchi", dtohp.Sotinchi);
                cmd.Parameters.AddWithValue("@Kyhoc", dtohp.Kyhoc);
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
