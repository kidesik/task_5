Console.Write("Введите натуральное число 'n': ");
int n = int.Parse(Console.ReadLine());

long sumOfOdds = 0;
int startOddNumber = n * (n - 1) + 1;
for (int i = 0; i < n; i++)
{
    int currentOddNumber = startOddNumber + (i * 2);
    sumOfOdds += currentOddNumber;
}

Console.WriteLine($"\nКуб числа {n} (рассчитанный суммой нечетных чисел) равен: **{sumOfOdds}**\n");
