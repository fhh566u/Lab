using System;

namespace Laba5;
class Television
{
    public string Brand;
    public string Model;
    public double Diagonal;
    public string Type;
    public double Price;
    public bool SmartTV;
    public int HDMI;

    public double PricePerInch()
    {
        return Price / Diagonal;
    }

    public void ShowInfo()
    {
        Console.WriteLine("\n--- Інформація про телевізор ---");
        Console.WriteLine($"Марка: {Brand}");
        Console.WriteLine($"Модель: {Model}");
        Console.WriteLine($"Діагональ: {Diagonal} дюймів");
        Console.WriteLine($"Тип: {Type}");
        Console.WriteLine($"Ціна: {Price} грн");
        Console.WriteLine(SmartTV ? "Має Smart TV" : "Без Smart TV");
        Console.WriteLine($"Кількість HDMI портів: {HDMI}");
        Console.WriteLine($"Ціна за 1 дюйм: {PricePerInch():0.00} грн");
    }
}