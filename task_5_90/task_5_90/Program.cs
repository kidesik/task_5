Console.Write("Введите натуральное число 'n': ");

int n = int.Parse(Console.ReadLine());
long sum = 0;
long f1 = 1; 
long f2 = 1; 

if (n >= 1) sum += f1;
if (n >= 2) sum += f2;

for (int i = 3; i <= n; i++)
{
    long current = f1 + f2;
    sum += current;

    f1 = f2;
    f2 = current;
}

bool isEven = (sum % 2 == 0);
string parity = isEven ? "четное" : "нечетное";

Console.WriteLine($"\nСумма первых {n} членов последовательности Фибоначчи: {sum}");
Console.WriteLine($"Сумма является **{parity}** числом.\n");