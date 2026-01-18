long f1 = 1; 
long f2 = 1; 
long current;
Console.WriteLine("Члены последовательности от F3 до F10:");
for (int i = 3; i <= 10; i++)
{
    current = f1 + f2;
    Console.WriteLine($"F{i} = {current}");
    f1 = f2;
    f2 = current;
}

Console.WriteLine("\nВсе члены успешно рассчитаны и выведены.");