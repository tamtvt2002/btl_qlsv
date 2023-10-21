using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.DTO
{
    class ThongtincanhanDTO
    {
        public string Hoten { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string Gioitinh { get; set; }
        public string Quequan { get; set; }
        public string Email { get; set; }
        public string Sodienthoai { get; set; }
        public byte[] Picture { get; set; }
        public ThongtincanhanDTO() { }
        public ThongtincanhanDTO(string _hoten, DateTime _ngaysinh, string _gioitinh, string _quequan, string _email, string _sodienthoai, byte[] _picture)
        {
            this.Hoten = _hoten;
            this.Ngaysinh = _ngaysinh;
            this.Gioitinh = _gioitinh;
            this.Quequan = _quequan;
            this.Email = _email;
            this.Sodienthoai = _sodienthoai;
            this.Picture = _picture;
        }
    }
}
