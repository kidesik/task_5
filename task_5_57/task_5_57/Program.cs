double a_y = 3.0;
double b_y = 4.0;
int numIntervals = 10000;
double h_y = (b_y - a_y) / numIntervals;
double approximateArea = 0.0;
Func<double, double> widthFunction = y => 2.0 * Math.Sqrt((y - 3) / 0.3);
for (int i = 0; i < numIntervals; i++)
{
    double y0 = a_y + i * h_y;
    double y1 = a_y + (i + 1) * h_y;

    double width0 = widthFunction(y0);
    double width1 = widthFunction(y1);
    approximateArea += h_y * (width0 + width1) / 2.0;
}

Console.WriteLine($"\nПриближенная площадь фигуры, ограниченной y=3 и y=4: **{approximateArea:F6}**");
