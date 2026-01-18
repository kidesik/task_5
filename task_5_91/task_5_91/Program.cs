Console.Write("Введите натуральное число 'n': ");
int n = int.Parse(Console.ReadLine());

List<int> allDivisors = new List<int>();
long sumOfDivisors = 0;
long sumOfEvenDivisors = 0;
int countOfEvenDivisors = 0;
int countOfOddDivisors = 0;

for (int i = 1; i * i <= n; i++)
{
    if (n % i == 0)
    {
        allDivisors.Add(i);
        sumOfDivisors += i;
        if (i % 2 == 0)
        {
            sumOfEvenDivisors += i;
            countOfEvenDivisors++;
        }
        else
        {
            countOfOddDivisors++;
        }

        if (i * i != n)
        {
            int pairedDivisor = n / i;
            allDivisors.Add(pairedDivisor);
            sumOfDivisors += pairedDivisor;
            if (pairedDivisor % 2 == 0)
            {
                sumOfEvenDivisors += pairedDivisor;
                countOfEvenDivisors++;
            }
            else
            {
                countOfOddDivisors++;
            }
        }
    }
}

allDivisors.Sort();

Console.WriteLine($"\nРезультаты для числа N = {n}:");

Console.WriteLine($"  а) Все делители: **{string.Join(", ", allDivisors)}**");
Console.WriteLine($"  б) Сумма его делителей: **{sumOfDivisors}**");
Console.WriteLine($"  в) Сумма его четных делителей: **{sumOfEvenDivisors}**");
Console.WriteLine($"  г) Количество его делителей: **{allDivisors.Count}**");
Console.WriteLine($"  д) Количество его нечетных делителей: **{countOfOddDivisors}**");
Console.WriteLine($"  е) Общее количество делителей (**{allDivisors.Count}**). Из них четных: **{countOfEvenDivisors}**.");

Console.Write("\nВведите число 'd' для подпункта (ж): ");
int d = int.Parse(Console.ReadLine());
int countGreaterThanD = allDivisors.Count(divisor => divisor > d);
Console.WriteLine($"  ж) Количество делителей, больших {d}: **{countGreaterThanD}**");
