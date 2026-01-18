Console.Write("Введите натуральное число 'n': ");
int n = int.Parse(Console.ReadLine());

double sum = 0.0;

for (int i = 1; i <= n; i++)
{
    sum += 1.0 / i;
}
Console.WriteLine($"Сумма ряда для n = {n}: {sum:F4}\n"); 
