using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.DAL
{
    class SinhvienDAL : Interface.InterfaceSinhvien
    {
        DAL.DBConnectionSQL dbc = new DBConnectionSQL();
        SqlCommand cmd;
        public DataTable LoadData()
        {
            DataTable dt = new DataTable("Sinhvien");
            try
            {
                SqlConnection conn = dbc.Connect();
                conn.Open();
                cmd = new SqlCommand("Exec sp_AllSinhvien ", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }
            catch { }
            return dt;
        }
        public DataTable timkiemSinhvien(string timkiem)
        {
            DataTable dt = new DataTable("Sinhvien");
            try
            {
                SqlConnection conn = dbc.Connect();
                conn.Open();
                cmd = new SqlCommand("sp_SearchSinhvien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Masinhvien", timkiem);
                cmd.Parameters.AddWithValue("@Tensinhvien", timkiem);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }
            catch { }
            return dt;
        }
        public DataTable TimkiemSvtheoMalop(string malop)
        {
            DataTable dt = new DataTable();
            try
            {
                DAL.DBConnectionSQL dbc = new DAL.DBConnectionSQL();
                SqlConnection conn = dbc.Connect();
                conn.Open();
                cmd = new SqlCommand("sp_SearchSvFromMalop", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Malop", malop);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch { }
            return dt;
        }
        public bool Suasinhvien(DTO.SinhvienDTO sv)
        {
            SqlConnection conn = dbc.Connect();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_UpdateSinhvien ", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Malop", sv.Malop);
                cmd.Parameters.AddWithValue("@Tensinhvien", sv.Hoten);
                cmd.Parameters.AddWithValue("@Ngaysinh", sv.Ngaysinh);
                cmd.Parameters.AddWithValue("@Gioitinh", sv.Gioitinh);
                cmd.Parameters.AddWithValue("@Quequan", sv.Quequan);
                cmd.Parameters.AddWithValue("@Email", sv.Email);
                cmd.Parameters.AddWithValue("@Sodienthoai", sv.Sodienthoai);
                cmd.Parameters.AddWithValue("@Picture", sv.Picture);
                cmd.Parameters.AddWithValue("@Masinhvien", sv.Masinhvien);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool Themsinhvien(DTO.SinhvienDTO sv)
        {
            SqlConnection conn = dbc.Connect();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_AddSinhvien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Malop", sv.Malop);
                cmd.Parameters.AddWithValue("@Masinhvien", sv.Masinhvien);
                cmd.Parameters.AddWithValue("@Tensinhvien", sv.Hoten);
                cmd.Parameters.AddWithValue("@Ngaysinh", sv.Ngaysinh);
                cmd.Parameters.AddWithValue("@Gioitinh", sv.Gioitinh);
                cmd.Parameters.AddWithValue("@Quequan", sv.Quequan);
                cmd.Parameters.AddWithValue("@Email", sv.Email);
                cmd.Parameters.AddWithValue("@Sodienthoai", sv.Sodienthoai);
                cmd.Parameters.AddWithValue("@Picture", sv.Picture);
                
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool Xoasinhvien(DTO.SinhvienDTO sv)
        {
            SqlConnection conn = dbc.Connect();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_DeleteSinhvien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Masinhvien", sv.Masinhvien);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public DataTable ReportSinhvienFromLop(string malop)
        {
            DataTable dt = new DataTable();
            try
            {
                DAL.DBConnectionSQL dbc = new DAL.DBConnectionSQL();
                SqlConnection conn = dbc.Connect();
                conn.Open();
                cmd = new SqlCommand("sp_ReportSvFromMalop", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Malop", malop);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch { }
            return dt;
        }
    }
}
