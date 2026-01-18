Console.WriteLine("Значения синуса:");
Console.WriteLine("\n");

for (int i = 1; i <= 15; i++)
{
    double x = i * 0.1;
    double sinValue = Math.Sin(x);
    Console.WriteLine($"sin({x:F1}) = {sinValue:F4}");
}