double a = 0.0;
double b = Math.PI;
int numIntervals = 10000;
double h = (b - a) / numIntervals;
double approximateArea = 0.0;
for (int i = 0; i < numIntervals; i++)
{ double x0 = a + i * h;
    double x1 = a + (i + 1) * h;
    double y0 = Math.Sin(x0);
    double y1 = Math.Sin(x1);
    approximateArea += h * (y0 + y1) / 2.0;
}

Console.WriteLine($"\nПриближенная площадь арки синусоиды (от 0 до Pi) при {numIntervals} интервалах: **{approximateArea:F6}**");
Console.WriteLine($"Точное значение площади равно 2.0. Полученное приближение достаточно точное.");
