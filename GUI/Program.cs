using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Text;

namespace Quanlisinhvien
{
    class Program
    {
        static void MenuSort(ArrayList DTArrayList, Sinhvien SinhVien, Nhap nhap, DocGhifile docGhifile, Chucnang chucnang)
        {
            while (true)
            {
                Console.WriteLine("1.Sắp xếp từ A-Z \n2.Sắp xếp từ Z-A\n3.Sắp xếp theo năm sinh từ thấp- cao\n4.Sắp xếp theo năm sinh từ cao - thấp\nẤn phím khác để về menu chính");
                Console.Write("Chọn: ");
                string chon = Console.ReadLine();
                switch (chon)
                {
                    case "1":
                        chucnang.SapxepAZ(DTArrayList);
                        Console.WriteLine("Sắp xếp thành công ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "2":
                        chucnang.SapxepZA(DTArrayList);
                        Console.WriteLine("Sắp xếp thành công ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "3":
                        chucnang.Sapxepthaptoicao(DTArrayList);
                        Console.WriteLine("Sắp xếp thành công ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "4":
                        chucnang.Sapxepcaotoithap(DTArrayList);
                        Console.WriteLine("Sắp xếp thành công ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        MenuSinhVien(DTArrayList, SinhVien, nhap, docGhifile, chucnang);
                        break;

                }
            }

        }
        static void MenuSinhVien(ArrayList DTArrayList, Sinhvien SinhVien, Nhap nhap, DocGhifile docGhifile, Chucnang chucnang)
        {
            Console.SetCursorPosition(35, 8); Console.WriteLine("____________________________________________________");
            Console.SetCursorPosition(35, 9); Console.WriteLine("| CHƯƠNG TRÌNH QUẢN LÝ SINH VIÊN KHOA CNTT         |");
            Console.SetCursorPosition(35, 10); Console.WriteLine("|__________________________________________________|");
            Console.SetCursorPosition(35, 11); Console.WriteLine("|1. Nhập thêm sinh vien                            |");
            Console.SetCursorPosition(35, 12); Console.WriteLine("|2. Hiện thị danh sách sinh viên                   |");
            Console.SetCursorPosition(35, 13); Console.WriteLine("|3. Sửa thông tin                                  |");
            Console.SetCursorPosition(35, 14); Console.WriteLine("|4. Xóa sinh viên                                  |");
            Console.SetCursorPosition(35, 15); Console.WriteLine("|5. Sắp xếp sinh viên                              |");
            Console.SetCursorPosition(35, 16); Console.WriteLine("|6. Tìm kiếm sinh viên                             |");
            Console.SetCursorPosition(35, 17); Console.WriteLine("|7.Thoát                                           |");
            Console.SetCursorPosition(35, 18); Console.WriteLine("|__________________________________________________|");
            while (true)
            {
                Console.Write("Nhập tùy chọn: ");
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        string kt;
                        while (true)
                        {

                            nhap.NhapSinhvien(DTArrayList);
                            docGhifile.GhifileSinhvien(DTArrayList);
                            Console.WriteLine("Ấn enter để tiếp tục hoặc Ấn phím 0 để dừng nhập ");
                            kt = Console.ReadLine();
                            if (kt == "0") break;
                        }
                        Console.Clear();
                        MenuSinhVien(DTArrayList, SinhVien, nhap, docGhifile, chucnang);
                        break;
                    case 2:
                        chucnang.HientatcaSinhvien(DTArrayList);
                        Console.ReadLine();
                        Console.Clear();
                        MenuSinhVien(DTArrayList, SinhVien, nhap, docGhifile, chucnang);
                        break;
                    case 3:
                        string keyword;
                        chucnang.HientatcaSinhvien(DTArrayList);
                        do
                        {
                            Console.WriteLine("Nhập tên sinh viên cần sửa ");
                            keyword = Console.ReadLine();
                        } while (keyword.Equals(""));
                        chucnang.SuathongtinSinhvien(DTArrayList, keyword);
                        docGhifile.GhifileSinhvien(DTArrayList);
                        Console.ReadLine();
                        Console.Clear();
                        MenuSinhVien(DTArrayList, SinhVien, nhap, docGhifile, chucnang);
                        break;
                    case 4:
                        string keyworddelete;
                        chucnang.HientatcaSinhvien(DTArrayList);
                        do
                        {
                            Console.WriteLine("Nhập tên sinh viên cần xóa ");
                            keyworddelete = Console.ReadLine();
                        } while (keyworddelete.Equals(""));
                        chucnang.Xoa(DTArrayList, keyworddelete);
                        docGhifile.GhifileSinhvien(DTArrayList);
                        Console.WriteLine("Xóa sinh viên thành công");
                        Console.ReadLine();
                        Console.Clear();
                        MenuSinhVien(DTArrayList, SinhVien, nhap, docGhifile, chucnang);
                        break;
                    case 5:
                        MenuSort(DTArrayList, SinhVien, nhap, docGhifile, chucnang);
                        break;
                    case 6:
                        string keywordsearch;
                        do
                        {
                            Console.WriteLine("Nhập tên sinh viên cần tìm ");
                            keywordsearch = Console.ReadLine();
                        } while (keywordsearch.Equals(""));
                        chucnang.TimSinhvien(DTArrayList, keywordsearch);
                        Console.ReadLine();
                        Console.Clear();
                        MenuSinhVien(DTArrayList, SinhVien, nhap, docGhifile, chucnang);
                        break;
                    default:
                        Console.WriteLine("Vui lòng nhập lại ");
                        break;

                }
                if (chon == 7) break;
            }

        }

        static void Main(string[] args)
        {

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            ArrayList DTArrayList = new ArrayList();
            DocGhifile docGhifile = new DocGhifile();
            Nhap nhap = new Nhap();
           
            Sinhvien SinhVien = new Sinhvien();
            Chucnang chucnang = new Chucnang();
            docGhifile.DocfileSinhvien(DTArrayList);
         

            MenuSinhVien(DTArrayList, SinhVien, nhap, docGhifile, chucnang);

        }
    }
}
