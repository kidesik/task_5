double poleLength = 4.5; 
double initialDistance = 3.0; 
double step = 0.2; 
double maxDistance = poleLength; 

Console.WriteLine($"\nУгол между палкой и полом в зависимости от расстояния от стены:");
Console.WriteLine($"Расстояние (м) | Угол (градусы)");


for (double dist = initialDistance; dist <= maxDistance; dist += step)
{
    double angleRadians = Math.Acos(dist / poleLength);

    double angleDegrees = angleRadians * (180.0 / Math.PI);

    Console.WriteLine($"   {dist:F2}        |    **{angleDegrees:F2}**");

    if (dist + step > maxDistance && dist < maxDistance)
    {
        double finalAngleRad = Math.Acos(maxDistance / poleLength);
        double finalAngleDeg = finalAngleRad * (180.0 / Math.PI);
        Console.WriteLine($"   {maxDistance:F2}        |    **{finalAngleDeg:F2}**");
        break;
    }
}