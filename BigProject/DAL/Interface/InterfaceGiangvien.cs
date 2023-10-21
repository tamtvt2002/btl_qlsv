using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.Interface
{
    interface InterfaceGiangvien
    {
        DataTable LoadData();
        bool Themgiangvien(DTO.GiangvienDTO gv);
        bool Suagiangvien(DTO.GiangvienDTO gv);
        bool Xoagiangvien(DTO.GiangvienDTO gv);
    }
}
