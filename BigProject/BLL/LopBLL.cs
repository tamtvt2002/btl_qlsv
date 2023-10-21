using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.BLL
{
    class LopBLL
    {
        DAL.LopDAL dallop;
        public LopBLL()
        {
            dallop = new DAL.LopDAL();
        }
        public DataTable LoadData()
        {
            return dallop.LoadData();
        }
        public bool SuaLop(DTO.LopDTO dtolop)
        {
            return dallop.SuaLop(dtolop);
        }
        public bool ThemLop(DTO.LopDTO dtolop)
        {
            return dallop.ThemLop(dtolop);
        }
    }
}
