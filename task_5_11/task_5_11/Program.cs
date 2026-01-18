const double EARTH_RADIUS = 6350.0; 
Console.WriteLine("Высота h, км | Расстояние d, км");
Console.WriteLine("\n");

for (int h = 1; h <= 10; h++)
{
    double distance = Math.Sqrt(2 * EARTH_RADIUS * h + h * h);
    Console.WriteLine($"{h,-12}| {distance,20:F3}");
}