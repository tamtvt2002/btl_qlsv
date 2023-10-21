using BigProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.DAL
{
    class GiangvienDAL : Interface.InterfaceGiangvien
    {
        DAL.DBConnectionSQL dbc = new DBConnectionSQL();
        SqlCommand cmd;
        public DataTable LoadData()
        {
            DataTable dt = new DataTable("Giangvien");
            try
            {
                SqlConnection conn = dbc.Connect();
                conn.Open();
                cmd = new SqlCommand("Exec sp_AllGiangvien ", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }
            catch { }
            return dt;
        }
        public DataTable timkiemGiangvien(string timkiem)
        {
            DataTable dt = new DataTable("Giangvien");
            try
            {
                SqlConnection conn = dbc.Connect();
                conn.Open();
                cmd = new SqlCommand("sp_SearchGiangvien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Magiangvien", timkiem);
                cmd.Parameters.AddWithValue("@Tengiangvien", timkiem);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }
            catch { }
            return dt;
        }
        public bool Suagiangvien(GiangvienDTO gv)
        {
            SqlConnection conn = dbc.Connect();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_UpdateGiangvien ", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Tenhocphan", gv.Tenhocphan);
                cmd.Parameters.AddWithValue("@Tengiangvien", gv.Hoten);
                cmd.Parameters.AddWithValue("@Ngaysinh", gv.Ngaysinh);
                cmd.Parameters.AddWithValue("@Gioitinh", gv.Gioitinh);
                cmd.Parameters.AddWithValue("@Quequan", gv.Quequan);
                cmd.Parameters.AddWithValue("@Email", gv.Email);
                cmd.Parameters.AddWithValue("@Sodienthoai", gv.Sodienthoai);
                cmd.Parameters.AddWithValue("@Picture", gv.Picture);
                cmd.Parameters.AddWithValue("@Magiangvien", gv.Magiangvien);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool Themgiangvien(GiangvienDTO gv)
        {
            SqlConnection conn = dbc.Connect();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_AddGiangvien ", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Tenhocphan", gv.Tenhocphan);
                cmd.Parameters.AddWithValue("@Magiangvien", gv.Magiangvien);
                cmd.Parameters.AddWithValue("@Tengiangvien", gv.Hoten);
                cmd.Parameters.AddWithValue("@Ngaysinh", gv.Ngaysinh);
                cmd.Parameters.AddWithValue("@Gioitinh", gv.Gioitinh);
                cmd.Parameters.AddWithValue("@Quequan", gv.Quequan);
                cmd.Parameters.AddWithValue("@Email", gv.Email);
                cmd.Parameters.AddWithValue("@Sodienthoai", gv.Sodienthoai);
                cmd.Parameters.AddWithValue("@Picture", gv.Picture);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool Xoagiangvien(GiangvienDTO gv)
        {
            SqlConnection conn = dbc.Connect();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_DeleteGiangvien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Magiangvien", gv.Magiangvien);
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
