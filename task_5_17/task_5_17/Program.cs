Console.WriteLine("  x |    t   |     y");
Console.WriteLine("\n");

for (int x = 4; x <= 28; x++)
{
    double t = x + 3;
    double y = 3 * t * t + 4.87 * t - 3;
    Console.WriteLine($"{x,3} | {t,6:F1} | {y,9:F4}");
}