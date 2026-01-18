double currentValue = Math.Pow(20, 2) - Math.Pow(19, 2);
for (int i = 18; i >= 1; i--)
{
    currentValue = Math.Pow(currentValue, 2) - Math.Pow(i, 2);
}
double finalResult = Math.Pow(currentValue, 2);

Console.WriteLine($"\nФинальное значение выражения: **{finalResult}**");
