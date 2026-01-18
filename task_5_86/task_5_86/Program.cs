long sum = 0;
List<int> foundNumbers = new List<int>();

for (int i = 31; i < 100; i++)
{
    int lastDigit = i % 10;

    if (i % 3 == 0 && (lastDigit == 2 || lastDigit == 4 || lastDigit == 8))
    {
        sum += i;
        foundNumbers.Add(i);
    }
}

Console.WriteLine($"\nНайденные числа: **{string.Join(", ", foundNumbers)}**");
Console.WriteLine($"Сумма этих чисел равна: **{sum}**\n");