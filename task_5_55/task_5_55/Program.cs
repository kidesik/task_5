long sumOfSquares = 0;
for (int i = 1; i <= 10; i++)
{
    sumOfSquares += (long)i * i;
}

Console.WriteLine($"Сумма ряда квадратов от 1 до 10: **{sumOfSquares}**\n");