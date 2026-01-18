Console.Write("Введите натуральное число N (больше 1): ");

int n = int.Parse(Console.ReadLine());

if (n <= 1)
{
    Console.WriteLine($"\nЧисло {n} по определению не является совершенным.");
    return;
}

long sumOfProperDivisors = 0;
for (int i = 1; i * i <= n; i++)
{
    if (n % i == 0)
    {
        if (i != n)
        {
            sumOfProperDivisors += i;
        }

        int pairedDivisor = n / i;

        if (i * i != n && pairedDivisor != n)
        {
            sumOfProperDivisors += pairedDivisor;
        }
    }
}

Console.WriteLine($"\nСумма собственных делителей числа {n} равна {sumOfProperDivisors}.");

if (sumOfProperDivisors == n)
{
    Console.WriteLine($"Число {n} является **совершенным**.");
}
else
{
    Console.WriteLine($"Число {n} не является **совершенным**.");
}