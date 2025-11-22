using System;
using System.Collections.Generic;
using System.Linq;

namespace DoHuyAn_BTVN_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> danhSachHocSinh = new List<Student>
            {
                new Student(1, "An", 16),
                new Student(2, "Bình", 17),
                new Student(3, "Ánh", 15),
                new Student(4, "Cường", 18),
                new Student(5, "Đào", 19),
                new Student(6, "Hương", 17),
                new Student(7, "Anh Tú", 16)
            };

            // a
            Console.WriteLine("a. Danh sach toan bo hoc sinh:");
            foreach (var hs in danhSachHocSinh)
            {
                Console.WriteLine($"{hs.Id} - {hs.Name} - {hs.Age}");
            }

            // b
            var tuoi1518 = danhSachHocSinh.Where(hs => hs.Age >= 15 && hs.Age <= 18).ToList();
            Console.WriteLine("\nb. Hoc sinh co tuoi tu 15 den 18:");
            foreach (var hs in tuoi1518)
            {
                Console.WriteLine($"{hs.Id} - {hs.Name} - {hs.Age}");
            }

           //c
            var tenA = danhSachHocSinh.Where(hs => hs.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();
            Console.WriteLine("\nc. Hoc sinh co ten bat dau bang chu 'A':");
            foreach (var hs in tenA)
            {
                Console.WriteLine($"{hs.Id} - {hs.Name} - {hs.Age}");
            }

            // d
            int tongTuoi = danhSachHocSinh.Sum(hs => hs.Age);
            Console.WriteLine($"\nd. Tong tuoi cua tat ca hoc sinh: {tongTuoi}");

            // e
            int tuoiLonNhat = danhSachHocSinh.Max(hs => hs.Age);
            var hsLonNhat = danhSachHocSinh.Where(hs => hs.Age == tuoiLonNhat).ToList();
            Console.WriteLine("\ne. Hoc sinh co tuoi lon nhat:");
            foreach (var hs in hsLonNhat)
            {
                Console.WriteLine($"{hs.Id} - {hs.Name} - {hs.Age}");
            }

            // f
            var sapXepTuoi = danhSachHocSinh.OrderBy(hs => hs.Age).ToList();
            Console.WriteLine("\nf. Danh sach hoc sinh theo tuoi tang dan:");
            foreach (var hs in sapXepTuoi)
            {
                Console.WriteLine($"{hs.Id} - {hs.Name} - {hs.Age}");
            }
        }
    }
}