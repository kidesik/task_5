Console.Write("Введите вещественное число 'a': ");
double a = double.Parse(Console.ReadLine());

Console.Write("Введите целое число 'n' (степень): ");
int n = int.Parse(Console.ReadLine());

double result = 1.0;
int absoluteN = Math.Abs(n);
for (int i = 0; i < absoluteN; i++)
{
    if (n >= 0)
    {
        result *= a;
    }
    else
    {
        result /= a;
    }
}
Console.WriteLine($"\nРезультат вычисления {a}^{n}: **{result:F6}**\n");
