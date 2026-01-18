Console.Write("Введите натуральное число 'n' (n >= 3): ");
int n = int.Parse(Console.ReadLine());
long prev1 = 1; 
long prev2 = 1; 
long current = 0;

Console.WriteLine($"\nб) Первые {n} членов последовательности Фибоначчи:");

if (n >= 1) Console.Write(prev1);
if (n >= 2) Console.Write($", {prev2}");
for (int i = 3; i <= n; i++)
{
    current = prev1 + prev2;
    Console.Write($", {current}");
    prev1 = prev2;
    prev2 = current;
}

Console.WriteLine($"\n\nа) {n}-й член последовательности Фибоначчи: **{prev2}**");
