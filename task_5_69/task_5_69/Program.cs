Console.Write("Введите натуральное число 'n' (от 2 до 10): ");
int n = int.Parse(Console.ReadLine());
double totalSum = 1.0; 
long currentFactorial = 1;

for (int i = 1; i <= n; i++)
{
    currentFactorial *= i;
    totalSum += 1.0 / currentFactorial;
}

Console.WriteLine($"\nСумма ряда для n = {n} равна: **{totalSum:F6}**\n");
