Console.Write("Введите натуральное число 'n': ");
int n = int.Parse(Console.ReadLine());
if (n == 0)
{
    Console.WriteLine($"Факториал {n}! равен: **1**\n");
    return;
}
long factorial = 1;
for (int i = 1; i <= n; i++)
{
    factorial *= i;
}

Console.WriteLine($"Факториал {n}! равен: **{factorial}**\n");
    