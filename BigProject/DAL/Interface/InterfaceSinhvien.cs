using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.Interface
{
    interface InterfaceSinhvien
    {
        DataTable LoadData();
        bool Themsinhvien(DTO.SinhvienDTO sv);
        bool Suasinhvien(DTO.SinhvienDTO sv);
        bool Xoasinhvien(DTO.SinhvienDTO sv);
    }
}
