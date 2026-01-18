List<int> automorphicNumbers = new List<int>();

for (int i = 100; i <= 999; i++)
{
    long square = (long)i * i;

    int lastThreeDigits = (int)(square % 1000);

    if (lastThreeDigits == i)
    {
        automorphicNumbers.Add(i);
    }
}

Console.WriteLine("\nНайденные числа: **" + string.Join(", ", automorphicNumbers) + "**");
List<int> specialNumbers = new List<int>();

for (int i = 100; i <= 999; i++)
{
    if (i % 7 == 0)
    {
        int sumOfDigits = i.ToString().Select(digit => int.Parse(digit.ToString())).Sum();

        if (sumOfDigits % 7 == 0)
        {
            specialNumbers.Add(i);
        }
    }
}

Console.WriteLine("\nНайденные числа: **" + string.Join(", ", specialNumbers) + "**");
