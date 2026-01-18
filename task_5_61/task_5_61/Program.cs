Console.Write("Введите натуральное число 'x': ");
int x = int.Parse(Console.ReadLine());

Console.Write("Введите натуральное число 'y': ");
int y = int.Parse(Console.ReadLine());

long productFor = 0;
for (int i = 0; i < y; i++)
{
    productFor += x;
}

Console.WriteLine($"\nПроизведение {x} * {y} (рассчитано циклом FOR): **{productFor}**\n");
