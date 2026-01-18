Console.Write("Введите натуральное число 'n': ");
int n = int.Parse(Console.ReadLine());

long sumOfSquares = 0;

for (int i = 1; i <= n; i++)
{
    sumOfSquares += (long)i * i;
}

Console.WriteLine($"Сумма квадратов от 1 до {n} включительно: {sumOfSquares}\n");
