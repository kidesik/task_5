double initialRun = 10.0; 
double increaseFactor = 1.1; 
int totalDaysForA = 10;
int totalDaysForB = 7;

double currentRun = initialRun;
double totalDistanceB = 0.0;

Console.WriteLine("\nа) Пробег лыжника за второй, третий,..., десятый день:");

for (int day = 1; day <= totalDaysForA; day++)
{
    if (day > 1)
    {
        currentRun *= increaseFactor;
        Console.WriteLine($"   День {day}: **{currentRun:F2}** км");
    }

    if (day <= totalDaysForB)
    {
        totalDistanceB += currentRun;
    }
}

Console.WriteLine("\nб) Какой суммарный путь он пробежал за первые 7 дней тренировок:");
Console.WriteLine($"   Суммарный путь за 7 дней: **{totalDistanceB:F2}** км");