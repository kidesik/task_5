{
    for (int i = 20; i <= 35; i++)
    {
        Console.WriteLine(i);
    }
}
{
    Console.Write("Введите целое число a (<= 50): ");
    int a = Convert.ToInt32(Console.ReadLine());

    for (int i = a; i <= 50; i++)
    {
        int square = i * i;
        Console.WriteLine(square);
    }
}
{
    Console.Write("Введите целое число b (>= 10): ");
    int b = Convert.ToInt32(Console.ReadLine());

    for (int i = 10; i <= b; i++)
    {
        
        int cube = i * i * i;
        Console.WriteLine(cube);
    }
}
{
    Console.Write("Введите целое число a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите целое число b (больше a): ");
    int b = Convert.ToInt32(Console.ReadLine());

    for (int i = a; i <= b; i++)
    {
        Console.WriteLine(i);
    }
}