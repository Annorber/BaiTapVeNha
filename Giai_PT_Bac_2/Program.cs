using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Giai phuong trinh bac 2: ax^2 + bx + c = 0");
        Console.Write("Nhap a: ");
        if (!double.TryParse(Console.ReadLine(), out double a))
        {
            Console.WriteLine("a khong hop le");
            return;
        }
        Console.Write("Nhap b: ");
        if (!double.TryParse(Console.ReadLine(), out double b))
        {
            Console.WriteLine("b khong hop le");
            return;
        }
        Console.Write("Nhap c: ");
        if (!double.TryParse(Console.ReadLine(), out double c))
        {
            Console.WriteLine("c khong hop le");
            return;
        }
        var giai = new GiaiPTBac2(a, b, c);
        Console.WriteLine();
        Console.WriteLine(giai.Giai());
    }
}   
