Console.Write("Введите вещественное число 'x': ");
double x = double.Parse(Console.ReadLine());

Console.Write("Введите натуральное число 'n' (от 2 до 9): ");
int n = int.Parse(Console.ReadLine());
double totalSum = 1.0;
double currentTerm = 1.0;
for (int i = 1; i <= n; i++)
{
    currentTerm = currentTerm * x / i;
    totalSum += currentTerm;
}

Console.WriteLine($"\nСумма ряда для x = {x} и n = {n} равна: **{totalSum:F6}**\n");
