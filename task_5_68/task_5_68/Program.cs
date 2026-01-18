Console.Write("Введите натуральное число 'n' (от 2 до 9): ");
int n = int.Parse(Console.ReadLine());

long totalSum = 0;
long currentFactorial = 1;
for (int i = 1; i <= n; i++)
    currentFactorial *= i;
    totalSum += currentFactorial;
}

Console.WriteLine($"\nСумма ряда факториалов для n = {n} равна: **{totalSum}**\n");
