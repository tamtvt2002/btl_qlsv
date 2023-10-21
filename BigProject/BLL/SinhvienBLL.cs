using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.BLL
{
    class SinhvienBLL
    {
        DAL.SinhvienDAL dalsv;
        public SinhvienBLL()
        {
            dalsv = new DAL.SinhvienDAL();
        }
        public DataTable LoadData()
        {
            return dalsv.LoadData();
        }
        public DataTable timkiemSinhvien(string timkiem)
        {
            return dalsv.timkiemSinhvien(timkiem);
        }
        public DataTable TimkiemSvtheoMalop(string malop)
        {
            return dalsv.TimkiemSvtheoMalop(malop);
        }
        public bool Themsinhvien(DTO.SinhvienDTO sv)
        {
            return dalsv.Themsinhvien(sv);
        }
        public bool Suasinhvien(DTO.SinhvienDTO sv)
        {
            return dalsv.Suasinhvien(sv);
        }
        public bool Xoasinhvien(DTO.SinhvienDTO sv)
        {
            return dalsv.Xoasinhvien(sv);
        }
        public DataTable ReportSinhvienFromLop(string malop)
        {
            return dalsv.ReportSinhvienFromLop(malop);
        }
    }
}
