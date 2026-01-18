Console.WriteLine("  a |    t   |     z");
Console.WriteLine("\n");

for (int a = 2; a <= 17; a++)
{
    double t = 3 * a;
    double z = 4.3 * t * t - 8 * t + 13;
    Console.WriteLine($"{a,3} | {t,6:F1} | {z,9:F4}");
}