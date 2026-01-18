List<int> foundNumbers = new List<int>();

for (int i = 1000; i <= 9999; i++)
{
    bool condition1 = (i % 133 == 125);

    bool condition2 = (i % 134 == 111);

    if (condition1 && condition2)
    {
        foundNumbers.Add(i);
    }
}

if (foundNumbers.Count > 0)
{
    Console.WriteLine("\nНайденные четырехзначные числа: **" + string.Join(", ", foundNumbers) + "**");
}
else
{
    Console.WriteLine("\nПодходящих четырехзначных чисел не найдено.");
}