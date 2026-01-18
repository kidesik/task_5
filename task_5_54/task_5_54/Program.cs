Console.Write("Введите вещественное число 'a': ");
double a = double.Parse(Console.ReadLine());

Console.Write("Введите натуральное число 'n': ");
int n = int.Parse(Console.ReadLine());

double currentPower = 1.0;

Console.WriteLine($"\nВычисленные степени числа {a} до {n}-й включительно:");

for (int i = 1; i <= n; i++)
{
    currentPower *= a;
    Console.WriteLine($"a^{i} = **{currentPower:F4}**");
}