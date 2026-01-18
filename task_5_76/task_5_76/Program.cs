Console.Write("Введите начальное целое число 'a': ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите конечное целое число 'b': ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите делитель 'c': ");
int c = int.Parse(Console.ReadLine());
int start = Math.Min(a, b);
int end = Math.Max(a, b);

Console.WriteLine($"\nЧисла от {start} до {end}, кратные {c}:");
for (int i = start; i <= end; i++)
{
    if(c != 0 && i % c == 0)
            {
        Console.Write($"{i} ");
    }
}

Console.WriteLine("\n");