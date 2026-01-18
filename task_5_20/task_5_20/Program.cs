Console.WriteLine("Значения корня:");
Console.WriteLine("\n");

for (int i = 1; i <= 9; i++)
{
    double x = i * 0.1;
    double sqrtValue = Math.Sqrt(x);
    Console.WriteLine($"sqrt({x:F1}) = {sqrtValue:F4}");
}