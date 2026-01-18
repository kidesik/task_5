long productA = 1;
for (int i = 7; i <= 14; i++)
{
    productA *= i;
}
Console.WriteLine($"Произведение чисел от 7 до 14: {productA}\n");
Console.Write("Введите целое число 'a' (1 <= a <= 15): ");
int a_b = int.Parse(Console.ReadLine());
long productB = 1;
for (int i = a_b; i <= 15; i++)
{
    productB *= i;
}
Console.WriteLine($"Произведение чисел от {a_b} до 15: {productB}\n");
Console.Write("Введите целое число 'b' (1 <= b <= 10): ");
int b_c = int.Parse(Console.ReadLine());
long productC = 1;
for (int i = 1; i <= b_c; i++)
{
    productC *= i;
}
Console.WriteLine($"Произведение чисел от 1 до {b_c}: {productC}\n");
Console.Write("Введите целое число 'a': ");
int a_d = int.Parse(Console.ReadLine());
Console.Write("Введите целое число 'b' (b >= a): ");
int b_d = int.Parse(Console.ReadLine());
long productD = 1;
for (int i = a_d; i <= b_d; i++)
{
    productD *= i;
}
Console.WriteLine($"Произведение чисел от {a_d} до {b_d}: {productD}\n");
