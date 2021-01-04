using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Quanlisinhvien;

namespace Quanlisinhvien
{
    class Nhap
    {
        public void NhapSinhvien(ArrayList arrayList)
        {
            
            arrayList.Add(new Sinhvien(TenSinhvien(), MaSinhvien(), MaLop(), Chuyennganh(), Quequan(), Socancuoc(), Namsinh()));
        }
        //string tensinhvien,string masinhvien,int malop,string chuyennganh,string quequan,string socancuoc,int namsinh
        public string TenSinhvien()
        {
            Console.Write("Nhập tên sinh viên: ");
            string ten = Console.ReadLine();
            return ten;
        }
        public string MaSinhvien()
        {
            Console.Write("Nhập mã sinh viên: ");
            string ten = Console.ReadLine();
            return ten;
        }
        public int MaLop()
        {
            Console.Write("Nhập mã lớp: ");
            int gia = int.Parse(Console.ReadLine());
            return gia;
        }
        public string Chuyennganh()
        {
            Console.Write("Nhập chuyên ngành : ");
            string ten = Console.ReadLine();
            return ten;
        }
        public string Quequan()
        {
            Console.Write("Nhập quê quán : ");
            string ten = Console.ReadLine();
            return ten;
        }
        public string Socancuoc()
        {
            Console.Write("Nhập số căn cước: ");
            string ten = Console.ReadLine();
            return ten;
        }
        public int Namsinh()
        {
            Console.WriteLine("Nhập năm sinh: ");
            int sl = int.Parse(Console.ReadLine());
            return sl;
        }
    }
}
