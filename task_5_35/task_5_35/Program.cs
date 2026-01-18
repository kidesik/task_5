Console.Write("Введите целое число 'n' (n >= 2): ");
int n = int.Parse(Console.ReadLine());

long sumOfProducts = 0;

for (int i = 1; i < n; i++)
{
    sumOfProducts += (long)i * (i + 1);
}

Console.WriteLine($"Сумма ряда для n = {n}: {sumOfProducts}\n");