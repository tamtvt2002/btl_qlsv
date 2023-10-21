using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.BLL
{
    class HocphanBLL
    {
        DAL.HocphanDAL dalhp;
        public HocphanBLL()
        {
            dalhp = new DAL.HocphanDAL();
        }
        public DataTable LoadData()
        {
            return dalhp.LoadData();
        }
        public bool SuaHocphan(DTO.HocphanDTO dtohp)
        {
            return dalhp.SuaHocphan(dtohp);
        }
        public bool ThemHocphan(DTO.HocphanDTO dtohp)
        {
            return dalhp.ThemHocphan(dtohp);
        }
    }
}
