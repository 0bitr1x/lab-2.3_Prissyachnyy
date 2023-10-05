//lab№2.3/сборник задач/разветляющиеся алгоритмы/операторы выбора/средний уровень/вариант 14
using System;

Console.Write("Введите x: ");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());
switch (n)
{
    case 1:
    {
        double a = 0.5; double b = 4.5; double z = Math.Exp(a * x); double y = 0;
        if (x <= 5 * a) { y = (2.5 * Math.Pow(b, 2)) + (a * x) - (4.5 * Math.Cos(x * z)); }
        else if (x > b) { y = Math.Pow(Math.Pow(a, 2) - 5.4 * x, 3) + Math.Log(x * z); }
        else if (5 * a < x && x <= b) { y = Math.Sqrt(6.5 * Math.Pow(b, 2) + (a - Math.Pow(x, 3) * z)); }
        Console.WriteLine($"итог: {y:F2}");
    }
        break;
    case 2:
        {
        double a = 0.5; double b = 3.7; double z = Math.Exp((2 * a) * x); double y = 0;
        if (x <= 5 * a) { y = (2.5 * Math.Pow(b, 2)) + (a * x) - (4.5 * Math.Cos(x * z)); }
        else if (x > b) { y = Math.Pow(Math.Pow(a, 2) - 5.4 * x, 3) + Math.Log(x * z); }
        else if (5 * a < x && x <= b) { y = Math.Sqrt(6.5 * Math.Pow(b, 2) + (a - Math.Pow(x, 3) * z)); }
        Console.WriteLine($"итог: {y:F2}");
    }
        break;
    case 3:
    {
        double a = 0.5; double b = 2.7; double z = Math.Exp((2.5 * a) * x); double y = 0;
            if (x <= 5 * a) { y = (2.5 * Math.Pow(b, 2)) + (a * x) - (4.5 * Math.Cos(x * z)); }
        else if (x > b) { y = Math.Pow(Math.Pow(a, 2) - 5.4 * x, 3) + Math.Log(x * z); }
        else if (5 * a < x && x <= b) { y = Math.Sqrt(6.5 * Math.Pow(b, 2) + (a - Math.Pow(x, 3) * z)); }
        Console.WriteLine($"итог: {y:F2}");
    }
        break;
    default: break;
}



