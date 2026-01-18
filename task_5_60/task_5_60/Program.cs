Console.Write("Введите вещественное число 'a': ");
double a = double.Parse(Console.ReadLine());

Console.Write("Введите целое число 'n': ");
int n = int.Parse(Console.ReadLine());

double product = 0.0;
int count = Math.Abs(n);
for (int i = 0; i < count; i++)
{
    product += a;
}
if (n < 0)
{
    product = -product;
}

Console.WriteLine($"\nПроизведение {a} * {n} (рассчитано сложением): **{product:F4}**\n");
    