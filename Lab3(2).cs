using System;

class Program
{
    static double Function(double x)
    {
        double x1 = 2.0 * x;
        double x2 = 5.0 * x;
        double arg = Math.Exp(x2 / x1);
        double val = Math.Abs(Math.Cos(arg));
        return val / (4.0 + x2);
    }

    static void Main()
    {
    StartOfCalculations:
        Console.Write("Введiть початок вiдрiзку iнтегрування a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введiть кiнець вiдрiзку iнтегрування b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Введiть кiлькiсть дiлянок n: ");
        int n = int.Parse(Console.ReadLine());

        double dx = (b - a) / n;
        double Intgrl = 0;
        double x1, x2, y1, y2;

        for (int i = 0; i < n; i++)
        {
            x1 = a + i * dx;
            x2 = x1 + dx;
            y1 = Function(x1);
            y2 = Function(x2);
            Intgrl += (y1 + y2) / 2 * dx;
        }

        Console.WriteLine("Iнтеграл функцiї на вiдрiзку [{0}, {1}] становить {2:0.0000}", a, b, Intgrl);
        Console.Write("Повторити розрахунок (y - так)? ");

        ConsoleKeyInfo pressedKey = Console.ReadKey();
        Console.WriteLine();
        if (pressedKey.Key == ConsoleKey.Y)
        {
            Console.WriteLine();
            goto StartOfCalculations;
        }
    }
}
