Console.Write("Введите натуральное число 'n': ");
int n = int.Parse(Console.ReadLine());

double sum = 0.0;

double sign = 1.0;

for (int i = 1; i <= n; i++)
{
    sum += sign * (1.0 / i);
    sign *= -1.0;
}

Console.WriteLine($"Сумма ряда для n = {n}: {sum:F6}\n");