Console.WriteLine("Значения синуса:");
Console.WriteLine("\n");

for (int angle = 2; angle <= 15; angle++)
{
    double sinValue = Math.Sin(angle);
    Console.WriteLine($"{sinValue:F4}");
}