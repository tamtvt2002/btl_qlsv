using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.DTO
{
    class GiangvienDTO:ThongtincanhanDTO
    {
        public string Tenhocphan { get; set; }
        public int Magiangvien { get; set; }
        public GiangvienDTO() { }
        public GiangvienDTO(string _tenhocphan, int _magiangvien, string _hoten, DateTime _ngaysinh, string _gioitinh, string _quequan, string _email, string _sodienthoai, byte[] _picture)
            : base(_hoten, _ngaysinh, _gioitinh, _quequan, _email, _sodienthoai, _picture)
        {
            this.Tenhocphan = _tenhocphan;
            this.Magiangvien = _magiangvien;
        }
    }
}
