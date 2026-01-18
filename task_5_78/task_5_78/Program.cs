List<int> foundNumbers = new List<int>();

for (int i = 100; i <= 999; i++)
{
    bool condition1 = (i % 47 == 43);

    bool condition2 = (i % 43 == 45);

    if (condition1 && condition2)
    {
        foundNumbers.Add(i);
    }
}

if (foundNumbers.Count > 0)
{
    Console.WriteLine("\nНайденные числа: **" + string.Join(", ", foundNumbers) + "**");
}
else
{
    Console.WriteLine("\nПодходящих трехзначных чисел не найдено.");
}