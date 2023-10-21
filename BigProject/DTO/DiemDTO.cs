using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.DTO
{
    class DiemDTO:AbstractDiem
    {
        public int Masinhvien { get; set; }
        public string Tenhocphan { get; set; }
        public float Diemchuyencan { get; set; }
        public float Diemgiuaky { get; set; }
        public float Diemcuoiky { get; set; }
        public DiemDTO() { }
        public DiemDTO(int _masinhvien, string _tenhocphan, float _diemchuyencan, float _diemgiuaky, float _diemcuoiky)
        {
            this.Masinhvien = _masinhvien;
            this.Tenhocphan = _tenhocphan;
            this.Diemchuyencan = _diemchuyencan;
            this.Diemgiuaky = _diemgiuaky;
            this.Diemcuoiky = _diemcuoiky;
        }
        public override float Thangdiem10()
        {
            return (float)(this.Diemchuyencan * 0.1 + this.Diemgiuaky * 0.2 + this.Diemcuoiky * 0.7);
        }

        public override float Thangdiem4()
        {
            return (float)(Thangdiem10() * 0.4);
        }

        public override string Thangdiemchu()
        {
            string diemchu;
            if (Thangdiem10() < 4)
                diemchu = "F";
            else if (Thangdiem10() >= 4 && Thangdiem10() < 5)
                diemchu = "D";
            else if (Thangdiem10() >= 5 && Thangdiem10() < 6f)
                diemchu = "D+";
            else if (Thangdiem10() >= 6 && Thangdiem10() < 6.5f)
                diemchu = "C";
            else if (Thangdiem10() >= 6.5f && Thangdiem10() < 7)
                diemchu = "C+";
            else if (Thangdiem10() >= 7 && Thangdiem10() < 8)
                diemchu = "B";
            else if (Thangdiem10() >= 8 && Thangdiem10() < 8.5f)
                diemchu = "B+";
            else if (Thangdiem10() >= 8.5f && Thangdiem10() < 9)
                diemchu = "A";
            else
                diemchu = "A+";
            return diemchu;
        }
    }
}
