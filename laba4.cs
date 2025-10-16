using System;

class Program
{
    const double StartX = 10.3;
    const double dX = 0.7;
    static double Function(double x)
    {
        double x1 = 2.76 * x;
        double x2 = 0.5 * x;
        return Math.Sqrt((x2 * x2 + x1 / x2) / (16 * x2 * x1));
    }
    static void Main()
    {
        double[] arr = new double[10];
        double x = StartX;
        for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
        {
            arr[i] = Function(x);
            x += dX;
        }
        Array.Sort(arr);
        Array.Reverse(arr);
        Console.WriteLine("Вiдсортованi за спаданням значення масиву:");
        for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            Console.WriteLine("arr[{0:00}] = {1:0.0000}", i, arr[i]);
        double aMin = arr[arr.GetUpperBound(0)];
        double aMax = arr[arr.GetLowerBound(0)];
        double aAvg = 0;
        for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            aAvg += arr[i];
        aAvg = aAvg / arr.GetLength(0);
        Console.WriteLine("Мiнiмальне значення масиву: {0:0.0000}", aMin);
        Console.WriteLine("Максимальне значення масиву: {0:0.0000}", aMax);
        Console.WriteLine("Середнє значення масиву: {0:0.0000}", aAvg);
        Console.ReadKey(true);
    }
}