long sum529A = 0;
int count529A = 0;
for (int i = 1; i <= 750; i++)
{
    sum529A += i;
    count529A++;
}
double averageA = (double)sum529A / count529A;
Console.WriteLine($"Среднее арифметическое от 1 до 750: {averageA:F2}\n");

Console.Write("Введите целое число 'b' (b >= 150): ");
int b_b = int.Parse(Console.ReadLine());
long sum529B = 0;
int count529B = 0;
for (int i = 150; i <= b_b; i++)
{
    sum529B += i;
    count529B++;
}
double averageB = (double)sum529B / count529B;
Console.WriteLine($"Среднее арифметическое от 150 до {b_b}: {averageB:F2}\n");

Console.Write("Введите целое число 'a' (a <= 200): ");
int a_c = int.Parse(Console.ReadLine());
long sum529C = 0;
int count529C = 0;
for (int i = a_c; i <= 200; i++)
{
    sum529C += i;
    count529C++;
}
double averageC = (double)sum529C / count529C;
Console.WriteLine($"Среднее арифметическое от {a_c} до 200: {averageC:F2}\n");

Console.Write("Введите целое число 'a': ");
int a_d = int.Parse(Console.ReadLine());
Console.Write("Введите целое число 'b' (b > a): ");
int b_d = int.Parse(Console.ReadLine());
long sum529D = 0;
int count529D = 0;
for (int i = a_d; i <= b_d; i++)
{
    sum529D += i;
    count529D++;
}
double averageD = (double)sum529D / count529D;
Console.WriteLine($"Среднее арифметическое от {a_d} до {b_d}: {averageD:F2}\n");
