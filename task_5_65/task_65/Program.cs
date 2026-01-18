Console.Write("Введите натуральное число 'n': ");
int n = int.Parse(Console.ReadLine());

int sumOfOdds = 0;
for (int i = 1; i <= n; i++)
{
    int oddNumber = 2 * i - 1;
    sumOfOdds += oddNumber;
}

Console.WriteLine($"\nКвадрат числа {n} (рассчитанный суммой нечетных чисел) равен: **{sumOfOdds}**\n");
