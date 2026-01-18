Console.Write("Введите натуральное число 'n': ");
int n = int.Parse(Console.ReadLine());
double currentA = 1.0; 
Console.WriteLine($"\nЧлены последовательности до a{n}:");

if (n >= 1)
{
    Console.WriteLine($"a1 = {currentA:F6}");
}
for (int k = 2; k <= n; k++)
{
    currentA += 1.0 / k;

    Console.WriteLine($"a{k} = {currentA:F6}");
}

Console.WriteLine($"\nПоследний вычисленный член (a{n}): **{currentA:F6}**");
