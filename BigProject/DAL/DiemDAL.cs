using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.DAL
{
    class DiemDAL : Interface.InterfaceDiem
    {
        DAL.DBConnectionSQL dbc = new DBConnectionSQL();
        SqlCommand cmd;
        DTO.DiemDTO dtodiem = new DTO.DiemDTO();
        public DataTable LoadData()
        {
            DataTable dt = new DataTable("Diem");
            try
            {
                SqlConnection conn = dbc.Connect();
                conn.Open();
                cmd = new SqlCommand("Exec sp_AllDiem ", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }
            catch { }
            return dt;
        }
        public DataTable timkiemDiemSV(string timkiem)
        {
            DataTable dt = new DataTable("DiemSv");
            try
            {
                SqlConnection conn = dbc.Connect();
                conn.Open();
                cmd = new SqlCommand("sp_SearchDiem", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Masinhvien", timkiem);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }
            catch { }
            return dt;
        }
        public bool Suadiem(DTO.DiemDTO dtodiem)
        {
            SqlConnection conn = dbc.Connect();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_UpdateDiem ", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Masinhvien", dtodiem.Masinhvien);
                cmd.Parameters.AddWithValue("@Tenhocphan", dtodiem.Tenhocphan);
                cmd.Parameters.AddWithValue("@Diemchuyencan", dtodiem.Diemchuyencan);
                cmd.Parameters.AddWithValue("@Diemgiuaky", dtodiem.Diemgiuaky);
                cmd.Parameters.AddWithValue("@Diemcuoiky", dtodiem.Diemcuoiky);
                cmd.Parameters.AddWithValue("@Thangdiem10", dtodiem.Thangdiem10());
                cmd.Parameters.AddWithValue("@Thangdiem4", dtodiem.Thangdiem4());
                cmd.Parameters.AddWithValue("@Thangdiemchu", dtodiem.Thangdiemchu());
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool Themdiem(DTO.DiemDTO dtodiem)
        {
            SqlConnection conn = dbc.Connect();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_AddDiem ", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Masinhvien", dtodiem.Masinhvien);
                cmd.Parameters.AddWithValue("@Tenhocphan", dtodiem.Tenhocphan);
                cmd.Parameters.AddWithValue("@Diemchuyencan", dtodiem.Diemchuyencan);
                cmd.Parameters.AddWithValue("@Diemgiuaky", dtodiem.Diemgiuaky);
                cmd.Parameters.AddWithValue("@Diemcuoiky", dtodiem.Diemcuoiky);
                cmd.Parameters.AddWithValue("@Thangdiem10", dtodiem.Thangdiem10());
                cmd.Parameters.AddWithValue("@Thangdiem4", dtodiem.Thangdiem4());
                cmd.Parameters.AddWithValue("@Thangdiemchu", dtodiem.Thangdiemchu());
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool Xoadiem(DTO.DiemDTO dtodiem)
        {
            SqlConnection conn = dbc.Connect();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_DeleteDiem ", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Masinhvien", dtodiem.Masinhvien);
                cmd.Parameters.AddWithValue("@Tenhocphan", dtodiem.Tenhocphan);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public DataTable ReportBangdiem(string timkiem)
        {
            DataTable dt = new DataTable("DiemSv");
            try
            {
                SqlConnection conn = dbc.Connect();
                conn.Open();
                cmd = new SqlCommand("sp_ReportDiemFromSV", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Masinhvien", timkiem);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }
            catch { }
            return dt;
        }
        public DataTable CRBangdiemLopVaHocphan(string malop, string tenhocphan)
        {
            DataTable dt = new DataTable("Bangdiem");
            try
            {
                SqlConnection conn = dbc.Connect();
                conn.Open();
                cmd = new SqlCommand("sp_BangdiemLopVaHocphan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Malop", malop);
                cmd.Parameters.AddWithValue("@Tenhocphan", tenhocphan);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }
            catch { }
            return dt;
        }
    }
}
