int count = 0;
List<int> foundNumbers = new List<int>(); 
for (int i = 100; i <= 999; i++)
{
    if (i % 7 == 0)
    {
        int sumOfDigits = 0;
        int temp = i;
        while (temp > 0)
        {
            sumOfDigits += temp % 10;
            temp /= 10;
        }

        if (sumOfDigits % 7 == 0)
        {
            count++;
            foundNumbers.Add(i);
        }
    }
}

Console.WriteLine($"\nНайденные числа: {string.Join(", ", foundNumbers)}");
Console.WriteLine($"\nОбщее количество чисел, удовлетворяющих условиям: **{count}**\n");
