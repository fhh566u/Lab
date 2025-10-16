using System;

namespace Lab02
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введiть початкове значення X1min: ");
            double x1Min = double.Parse(Console.ReadLine());

            Console.Write("Введiть кiнцеве значення X1max: ");
            double x1Max = double.Parse(Console.ReadLine());

            Console.Write("Введiть прирiст dX1: ");
            double dx1 = double.Parse(Console.ReadLine());

            Console.Write("Введiть початкове значення X2min: ");
            double x2Min = double.Parse(Console.ReadLine());

            Console.Write("Введiть кiнцеве значення X2max: ");
            double x2Max = double.Parse(Console.ReadLine());

            Console.Write("Введiть прирiст dX2: ");
            double dx2 = double.Parse(Console.ReadLine());

            if (dx1 <= 0 || dx2 <= 0)
            {
                Console.WriteLine("Помилка: кроки dx1 та dx2 повинні бути > 0.");
                Console.ReadKey();
                return;
            }

            double x1 = x1Min;
            while (x1 <= x1Max)
            {
                double x2 = x2Min;
                while (x2 <= x2Max)
                {
                    if (Math.Abs(x2) < 1e-12 || Math.Abs(x1) < 1e-12)
                    {
                        Console.WriteLine("x1 = {0:e}\tx2 = {1:e}\t y = {2}", x1, x2, "undefined");
                    }
                    else
                    {
                        double numerator = Math.Pow(x2, 2) + x1 / x2;
                        double denominator = 16.0 * x2 * x1;
                        double fraction = numerator / denominator;

                        if (fraction < 0.0)
                        {
                            Console.WriteLine("x1 = {0:e}\tx2 = {1:e}\t y = {2}", x1, x2, "nan");
                        }
                        else
                        {
                            double y = Math.Sqrt(fraction);
                            Console.WriteLine("x1 = {0:e}\tx2 = {1:e}\t y = {2:e}", x1, x2, y);
                        }
                    }

                    x2 += dx2;
                }

                x1 += dx1;
            }

            Console.ReadKey();
        }
    }
}