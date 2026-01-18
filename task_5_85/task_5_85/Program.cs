Console.Write("Введите начальное целое число 'a': ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите конечное целое число 'b': ");
int b = int.Parse(Console.ReadLine());

int start = Math.Min(a, b);
int end = Math.Max(a, b);

long sum = 0;

Console.WriteLine($"\nПоложительные числа от {start} до {end}, кратные 4:");

for (int i = start; i <= end; i++)
{
    if (i > 0 && i % 4 == 0)
    {
        Console.Write($"{i} ");
        sum += i;
    }
}

Console.WriteLine($"\n\nСумма этих чисел равна: **{sum}**\n");