Console.Write("Введите натуральное число 'n': ");
int n = int.Parse(Console.ReadLine());

long sumOfSquares = 0;

for (int i = n; i <= 2 * n; i++)
{
    sumOfSquares += (long)i * i;
}

Console.WriteLine($"Сумма квадратов от {n} до {2 * n} включительно: {sumOfSquares}\n");
