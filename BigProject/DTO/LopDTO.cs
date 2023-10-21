using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.DTO
{
    class LopDTO
    {
        public string Malop { get; set; }
        public string Tenlop { get; set; }
        public string Course { get; set; }
        public LopDTO() { }
        public LopDTO(string _malop, string _tenlop, string _course)
        {
            this.Malop = _malop;
            this.Tenlop = _tenlop;
            this.Course = _course;
        }
    }
}
