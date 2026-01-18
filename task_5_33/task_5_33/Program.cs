double sum = 0;
for (int i = 3; i <= 10; i++)
{
    sum += (double)i / (i + 1);
}

Console.WriteLine($"Сумма ряда: {sum:F4}\n");