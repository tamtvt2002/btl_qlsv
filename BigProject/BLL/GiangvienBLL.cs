using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.BLL
{
    class GiangvienBLL
    {
        DAL.GiangvienDAL dalgv = new DAL.GiangvienDAL();
        public DataTable LoadData()
        {
            return dalgv.LoadData();
        }
        public DataTable timkiemGiangvien(string timkiem)
        {
            return dalgv.timkiemGiangvien(timkiem);
        }
        public bool Themgiangvien(DTO.GiangvienDTO gv)
        {
            return dalgv.Themgiangvien(gv);
        }
        public bool Suagiangvien(DTO.GiangvienDTO gv)
        {
            return dalgv.Suagiangvien(gv);
        }
        public bool Xoagiangvien(DTO.GiangvienDTO gv)
        {
            return dalgv.Xoagiangvien(gv);
        }
    }
}
