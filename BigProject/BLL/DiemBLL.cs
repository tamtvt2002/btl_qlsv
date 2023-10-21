using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.BLL
{
    class DiemBLL
    {
        DAL.DiemDAL daldiem = new DAL.DiemDAL();
        public DataTable LoadData()
        {
            return daldiem.LoadData();
        }
        public DataTable timkiemDiemSV(string timkiem)
        {
            return daldiem.timkiemDiemSV(timkiem);
        }
        public bool Suadiem(DTO.DiemDTO dtodiem)
        {
            return daldiem.Suadiem(dtodiem);
        }
        public bool Themdiem(DTO.DiemDTO dtodiem)
        {
            return daldiem.Themdiem(dtodiem);
        }
        public bool Xoadiem(DTO.DiemDTO dtodiem)
        {
            return daldiem.Xoadiem(dtodiem);
        }
        public DataTable ReportBangdiem(string timkiem)
        {
            return daldiem.ReportBangdiem(timkiem);
        }
        public DataTable CRBangdiemLopVaHocphan(string malop, string tenhocphan)
        {
            return daldiem.CRBangdiemLopVaHocphan(malop, tenhocphan);
        }
    }
}
