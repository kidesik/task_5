using System;
class Program
{
    static void Main()
    {
        long sumA = 0;
        for (int i = 200; i <= 600; i++)
        {
            sumA += i;
        }
        Console.WriteLine($"Сумма чисел от 200 до 600: {sumA}\n");
        Console.Write("Введите целое число 'a' (a <= 400): ");
        int a_b = int.Parse(Console.ReadLine());
        long sumB = 0;
        for (int i = a_b; i <= 400; i++)
        {
            sumB += i;
        }
        Console.WriteLine($"Сумма чисел от {a_b} до 400: {sumB}\n");
        Console.Write("Введите целое число 'b' (b >= -15): ");
        int b_c = int.Parse(Console.ReadLine());
        long sumC = 0;
        for (int i = 15; i <= b_c; i++)
        {
            sumC += i;
        }
        Console.WriteLine($"Сумма чисел от 15 до {b_c}: {sumC}\n");
        Console.Write("Введите целое число 'a': ");
        int a_d = int.Parse(Console.ReadLine());
        Console.Write("Введите целое число 'b' (b >= a): ");
        int b_d = int.Parse(Console.ReadLine());
        long sumD = 0;
        for (int i = a_d; i <= b_d; i++)
        {
            sumD += i;
        }
        Console.WriteLine($"Сумма чисел от {a_d} до {b_d}: {sumD}\n");
    }
}