using System;
using Lab06Lib;

namespace Lab06App
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введіть кількість телевізорів: ");
            int n = int.Parse(Console.ReadLine());

            Television[] arrTVs = new Television[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nТелевізор №{i + 1}:");

                Television tv = new Television();

                Console.Write("Марка: ");
                tv.Brand = Console.ReadLine();

                Console.Write("Модель: ");
                tv.Model = Console.ReadLine();

                Console.Write("Діагональ (дюйми): ");
                tv.Diagonal = double.Parse(Console.ReadLine());

                Console.Write("Тип (LED, OLED, QLED): ");
                tv.Type = Console.ReadLine();

                Console.Write("Ціна (грн): ");
                tv.Price = double.Parse(Console.ReadLine());

                Console.Write("Чи має Smart TV? (y/n): ");
                tv.SmartTV = Console.ReadKey().Key == ConsoleKey.Y;
                Console.WriteLine();

                Console.Write("Кількість HDMI портів: ");
                tv.HDMI = int.Parse(Console.ReadLine());

                arrTVs[i] = tv;
            }

            Console.WriteLine("\n\n--- Інформація про всі телевізори ---");
            foreach (Television tv in arrTVs)
            {
                tv.ShowInfo();
            }

            Console.ReadKey();
        }
    }
}