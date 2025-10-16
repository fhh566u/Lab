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

    static double IntegrateTrapezoid(double a, double b, int n)
    {
        double dx = (b - a) / n;
        double sum = 0.5 * (Function(a) + Function(b));
        for (int i = 1; i < n; i++)
        {
            double x = a + i * dx;
            sum += Function(x);
        }
        return sum * dx;
    }

    static void Main()
    {
        Console.Write("Введіть початок відрізку a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введіть кінець відрізку b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Введіть кількість ділянок n (ціле > 0): ");
        int n = int.Parse(Console.ReadLine());
        double result = IntegrateTrapezoid(a, b, n);
        Console.WriteLine("Інтеграл функції на відрізку [{0}, {1}] ≈ {2:F6}", a, b, result);
        Console.ReadLine();
    }
}