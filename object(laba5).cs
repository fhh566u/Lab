using System;

namespace Laba5;
class Program
{
    static void Main()
    {
        Television tv = new Television();

        Console.Write("Марка телевізора: ");
        tv.Brand = Console.ReadLine();

        Console.Write("Модель: ");
        tv.Model = Console.ReadLine();

        Console.Write("Діагональ (дюйми): ");
        tv.Diagonal = double.Parse(Console.ReadLine());

        Console.Write("Тип екрана (LED, OLED, QLED): ");
        tv.Type = Console.ReadLine();

        Console.Write("Ціна (грн): ");
        tv.Price = double.Parse(Console.ReadLine());

        Console.Write("Чи має Smart TV? (y/n): ");
        tv.SmartTV = Console.ReadKey().Key == ConsoleKey.Y;
        Console.WriteLine();

        Console.Write("Кількість HDMI портів: ");
        tv.HDMI = int.Parse(Console.ReadLine());

        tv.ShowInfo();
        Console.ReadKey();
    }
}