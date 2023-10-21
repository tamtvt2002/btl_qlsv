 using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.Interface
{
    interface InterfaceHocphan
    {
        DataTable LoadData();
        bool ThemHocphan(DTO.HocphanDTO dtohp);
        bool SuaHocphan(DTO.HocphanDTO dtohp);
    }
}
