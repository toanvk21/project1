using Microsoft.VisualBasic;
using Quanlisinhvien;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;
using System.Text;

namespace Quanlisinhvien
{
    class Chucnang
    {
       
        static DocGhifile docGhifile = new DocGhifile();
        //string tensinhvien,string masinhvien,int malop,string chuyennganh,string quequan,string socancuoc,int namsinh
        public void HienSinhvien(Sinhvien Sinhvien)
        {
            Console.WriteLine("{0,20}|{1,20}|{2,20}|{3,20}|{4,20}|{5,20}|{6,20}|", Sinhvien.Tensinhvien, Sinhvien.Masinhvien, Sinhvien.Malop, Sinhvien.Chuyennganh, Sinhvien.Quequan, Sinhvien.Socancuoc, Sinhvien.Namsinh);
        }
        public void HientatcaSinhvien(ArrayList arrayList)
        {
           
         
            Console.WriteLine("{0,20}|{1,20}|{2,20}|{3,20}|{4,20}|{5,20}|{6,20}|", "Họ tên", "Mã sinh viên", "Mã lớp", "Chuyên ngành", "Quê quán", "Số căn cước", "Năm sinh");
            foreach (Sinhvien Sinhvien in arrayList)
            {
                HienSinhvien(Sinhvien);
            }
        }
        public void TimSinhvien(ArrayList arrayList, string keyword)
        {
            bool kt = false;
            foreach (Sinhvien Sinhvien in arrayList)
            {
                if (Sinhvien.Tensinhvien.ToLower().Equals(keyword.ToLower()) || Sinhvien.Masinhvien.ToLower().Equals(keyword.ToLower()) || Sinhvien.Chuyennganh.ToLower().Equals(keyword.ToLower()) || Sinhvien.Quequan.ToString().ToLower().Equals(keyword.ToLower()) || Sinhvien.Socancuoc.ToLower().Equals(keyword.ToLower()))
                {
                    HienSinhvien(Sinhvien);
                    kt = true;
                }

            }
            if (kt == false) Console.WriteLine("Không tìm thấy sinh viên cần tìm!");
        }

        public class SortAZ : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                Sinhvien dt1 = x as Sinhvien;
                Sinhvien dt2 = y as Sinhvien;
                return String.Compare(dt1.Tensinhvien, dt2.Tensinhvien);
            }// nếu dt1 > dt2 thì trả về 1 , dt1 <dt 2 thì trả về -1, dt1 = dt2 trả về 0
        }
        public class SortZA : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                Sinhvien dt1 = x as Sinhvien;
                Sinhvien dt2 = y as Sinhvien;
                return String.Compare(dt2.Tensinhvien, dt1.Tensinhvien);
            }
        }
        public class Thapcao : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                Sinhvien dt1 = x as Sinhvien;
                Sinhvien dt2 = y as Sinhvien;
                if (dt1.Malop > dt2.Malop) return 1;
                else return -1;
            }
        }
        public class Caothap : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                Sinhvien dt1 = x as Sinhvien;
                Sinhvien dt2 = y as Sinhvien;
                if (dt1.Malop > dt2.Malop) return -1;
                else return 1;
            }
        }
        public void SapxepAZ(ArrayList arrayList)
        {
            arrayList.Sort(new SortAZ());
        }
        public void SapxepZA(ArrayList arrayList)
        {
            arrayList.Sort(new SortZA());
        }
        public void Sapxepthaptoicao(ArrayList arrayList)
        {
            arrayList.Sort(new Thapcao());
        }
        public void Sapxepcaotoithap(ArrayList arrayList)
        {
            arrayList.Sort(new Caothap());
        }
        public void Xoa(ArrayList arrayList,string keyword)
        {
            int dem = 0;
            foreach(Sinhvien Sinhvien in arrayList)
            {
                if (Sinhvien.Tensinhvien.ToLower().Equals(keyword.ToLower()) == false) dem++;
                else break;
            }
            arrayList.RemoveAt(dem);
        }
        public void SuathongtinSinhvien(ArrayList arrayList, string keyword)
        {
            //string tensinhvien,string masinhvien,int malop,string chuyennganh,string quequan,string socancuoc,int namsinh
            Nhap nhap = new Nhap();
            foreach(Sinhvien Sinhvien in arrayList)
            {
                if (Sinhvien.Tensinhvien.ToLower().Equals(keyword.ToLower()))
                {
                   
                    Console.WriteLine("Nhập 0 để bỏ qua");
                    string Tensinhvien = nhap.TenSinhvien();
                    if (Tensinhvien.Equals("0")==false)
                    {
                        Sinhvien.Tensinhvien = Tensinhvien;
                    }
                    string masv = nhap.MaSinhvien();
                    if (masv.Equals("0") == false)
                    {
                        Sinhvien.Masinhvien = masv;
                    }
                  
                    int Malop = nhap.MaLop();
                    if (Malop != 0)
                    {
                        Sinhvien.Malop = Malop;
                    }
                    string chuyennganh = nhap.Chuyennganh();
                    if (chuyennganh.Equals("0") == false)
                    {
                        Sinhvien.Chuyennganh = chuyennganh;
                    }
                    string que=nhap.Quequan();
                    if (que.Equals("0") == false)
                    {
                        Sinhvien.Quequan = que;
                    }
                    string cancuoc= nhap.Socancuoc();
                    if (cancuoc.Equals("0") == false)
                    {
                        Sinhvien.Socancuoc = cancuoc;
                    }
                    int namsinh= nhap.Namsinh();
                    if (namsinh.Equals(0) == false)
                    {
                        Sinhvien.Namsinh = namsinh;
                    }
                }
            }
            Console.WriteLine("Sửa thông tin thành công!");
        }
    }
}
