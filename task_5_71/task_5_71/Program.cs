double totalSum = 0.0;

for (int i = 1; i <= 50; i++)
{
    double rootValue = Math.Sqrt(i);
    totalSum += rootValue;
}

Console.WriteLine($"\nСумма ряда равна: **{totalSum:F6}**\n");