int initialCells = 1;
int timeInterval = 3; 
int endTime = 24;     

Console.WriteLine($"\nНачальное количество клеток: {initialCells}");
Console.WriteLine("Количество клеток по истечении времени:");

int currentCells = initialCells;

for (int t = timeInterval; t <= endTime; t += timeInterval)
{
    currentCells *= 2;

    Console.WriteLine($"Через {t} часов: **{currentCells}** клеток");
}