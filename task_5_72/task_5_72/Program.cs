Console.Write("Введите натуральное число 'n': ");

int n = int.Parse(Console.ReadLine());

double sumA = 0.0;
double currentDenominatorA = 0.0;
for (int i = 1; i <= n; i++)
{
    currentDenominatorA += Math.Sin(i);
    sumA += 1.0 / currentDenominatorA;
}

double sumB = Math.Sqrt(2.0);
for (int i = 1; i < n; i++)
{
    sumB = Math.Sqrt(2.0 + sumB);
}

double sumC = 0.0;
double currentCosDenomC = 0.0;
double currentSinDenomC = 0.0;
for (int i = 1; i <= n; i++)
{
    currentCosDenomC += Math.Cos(i);
    currentSinDenomC += Math.Sin(2 * i);
    sumC += currentCosDenomC / currentSinDenomC;
}

double sumD = 0.0;
for (int i = 1; i <= n; i++)
{
    sumD += Math.Sqrt(3.0 * i);
}

Console.WriteLine($"\nРезультаты для n = {n}:");
Console.WriteLine($"  а) Результат: **{sumA:F6}**");
Console.WriteLine($"  б) Результат: **{sumB:F6}**");
Console.WriteLine($"  в) Результат: **{sumC:F6}**");
Console.WriteLine($"  г) Результат: **{sumD:F6}**");