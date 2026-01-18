Console.WriteLine("Подходящие числа:");

for (int i = 10; i <= 99; i++)
{
    int lastDigit = i % 10;

    if (lastDigit == 3 || lastDigit == 7)
    {
        Console.Write($"{i} ");
    }
}