Console.Write("Введите целое число n (от 1 до 9): ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nТаблица умножения на {n}:");
for (int i = 1; i <= 9; i++)
{
    int result = i * n;
    Console.WriteLine($"{i} x {n} = {result}");
}