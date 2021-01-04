using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Quanlisinhvien;

namespace Quanlisinhvien
{
    class DocGhifile
    {


        public void DocfileSinhvien(ArrayList arrayList)
        {
            StreamReader streamReader = new StreamReader("sinhvien.txt");
            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                if (line == " ") break;

                arrayList.Add(new Sinhvien(line.Split(";")[0], line.Split(";")[1], int.Parse(line.Split(";")[2]), line.Split(";")[3], line.Split(";")[4], line.Split(";")[5], int.Parse(line.Split(";")[6])));

            }
            streamReader.Close();
        }
        public void GhifileSinhvien(ArrayList arrayList)
        {
            StreamWriter streamWriter = new StreamWriter("Sinhvien.txt");
            foreach (Sinhvien Sinhvien in arrayList)
            {
                streamWriter.WriteLine(Sinhvien.ToString());
            }
            streamWriter.Close();
        }
    }
}
