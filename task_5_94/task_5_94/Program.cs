Console.Write("Введите натуральное число 'n': ");

int n = int.Parse(Console.ReadLine());

if (n < 1)
{
    Console.WriteLine("N должно быть натуральным числом (N >= 1).");
    return;
}

int upperBound = (int)Math.Floor(Math.Sqrt(n));

Console.WriteLine($"\nНатуральные числа, квадрат которых не превышает {n}:");

for (int k = 1; k <= upperBound; k++)
{
    Console.Write($"{k} ");
}

Console.WriteLine("\n");