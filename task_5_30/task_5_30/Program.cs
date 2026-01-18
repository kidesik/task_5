long sumOfCubesA = 0;
for (int i = 25; i <= 40; i++)
{
    sumOfCubesA += (long)Math.Pow(i, 3);
}
Console.WriteLine($"Сумма кубов от 25 до 40: {sumOfCubesA}\n");

Console.Write("Введите целое число 'a' (0 <= a <= 50): ");
int a_b_30 = int.Parse(Console.ReadLine());
long sumOfSquaresB = 0;
for (int i = a_b_30; i <= 50; i++)
{
    sumOfSquaresB += (long)Math.Pow(i, 2);
}
Console.WriteLine($"Сумма квадратов от {a_b_30} до 50: {sumOfSquaresB}\n");

Console.Write("Введите целое число 'n' (1 <= n <= 100): ");
int n_c = int.Parse(Console.ReadLine());
long sumOfSquaresC = 0;
for (int i = 1; i <= n_c; i++)
{
    sumOfSquaresC += (long)Math.Pow(i, 2);
}
Console.WriteLine($"Сумма квадратов от 1 до {n_c}: {sumOfSquaresC}\n");

Console.Write("Введите целое число 'a': ");
int a_d_30 = int.Parse(Console.ReadLine());
Console.Write("Введите целое число 'b' (b >= a): ");
int b_d_30 = int.Parse(Console.ReadLine());
long sumOfSquaresD = 0;
for (int i = a_d_30; i <= b_d_30; i++)
{
    sumOfSquaresD += (long)Math.Pow(i, 2);
}
Console.WriteLine($"Сумма квадратов от {a_d_30} до {b_d_30}: {sumOfSquaresD}\n");
    