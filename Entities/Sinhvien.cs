using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlisinhvien
{
    class Sinhvien
    {
        private string tensinhvien;
        private string masinhvien;
        private int malop;
        private string chuyennganh;
        private string quequan;
        private string socancuoc;
        private int namsinh;
        public Sinhvien(string tensinhvien,string masinhvien,int malop,string chuyennganh,string quequan,string socancuoc,int namsinh)
        {
            this.tensinhvien = tensinhvien;
            this.masinhvien = masinhvien;
            this.malop = malop;
            this.chuyennganh = chuyennganh;
            this.quequan = quequan;
            this.socancuoc = socancuoc;
            this.namsinh= namsinh;
        }
        public string Tensinhvien { get => tensinhvien; set => tensinhvien = value; }
        public string Masinhvien { get => masinhvien; set => masinhvien = value; }
        public int Malop { get => malop; set => malop = value; }
        public string Chuyennganh { get => chuyennganh; set => chuyennganh = value; }
        public string Quequan { get => quequan; set => quequan = value; }
        public string Socancuoc { get => socancuoc; set => socancuoc = value; }
        public int Namsinh { get => namsinh; set => namsinh = value; }

        override
            public String ToString()
        {
            return Tensinhvien + ";" + Masinhvien + ";" + Malop + ";" + Chuyennganh + ";" + Quequan +  ";" + Socancuoc + ";" + Namsinh;
        }
        public Sinhvien()
        {

        }

    }
}
