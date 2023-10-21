using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.Interface
{
    interface InterfaceDiem
    {
        DataTable LoadData();
        bool Themdiem(DTO.DiemDTO dtodiem);
        bool Suadiem(DTO.DiemDTO dtodiem);
        bool Xoadiem(DTO.DiemDTO dtodiem);
    }
}
