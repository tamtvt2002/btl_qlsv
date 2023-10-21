using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.DTO
{
    class SinhvienDTO:ThongtincanhanDTO
    {
        public string Malop { get; set; }
        public int Masinhvien { get; set; }
        public SinhvienDTO() { }
        public SinhvienDTO(string _malop, int _masinhvien, string _hoten, DateTime _ngaysinh, string _gioitinh, string _quequan, string _email, string _sodienthoai, byte[] _picture) 
            : base(_hoten, _ngaysinh, _gioitinh, _quequan, _email, _sodienthoai, _picture)
        {
            this.Malop = _malop;
            this.Masinhvien = _masinhvien;
        }
    }
}
