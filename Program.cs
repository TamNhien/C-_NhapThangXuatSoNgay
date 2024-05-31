using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap month: ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Nhap year: ");
        int year = int.Parse(Console.ReadLine());

        int day = month switch
        {
            1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
            4 or 6 or 9 or 11 => 30,
            2 => (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) ? 29 : 28,
            _ => -1
            
        };
        Console.WriteLine(day == -1 ? "Thang khong hop le" : $"Thang {month} nam {year} co {day} ngay");
    }
}