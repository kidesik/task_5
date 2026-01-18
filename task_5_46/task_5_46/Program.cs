Console.Write("Введите натуральное число 'n' (для вывода первых n членов): ");
int n = int.Parse(Console.ReadLine());

if (n <= 0)
{
    Console.WriteLine("N должно быть натуральным числом.");
    return;
}


long num_prev2 = 1; 
long den_prev2 = 1; 
long num_prev1 = 2; 
long den_prev1 = 1; 

Console.WriteLine($"\nб) Первые {n} членов последовательности:");

if (n >= 1) Console.WriteLine($"Член 1: {num_prev2}/{den_prev2}");
if (n >= 2) Console.WriteLine($"Член 2: {num_prev1}/{den_prev1}");

long currentNum = 0;
long currentDen = 0;
for (int i = 3; i <= n; i++)
{
    currentNum = num_prev1 + num_prev2;
    currentDen = den_prev1 + den_prev2;

    Console.WriteLine($"Член {i}: {currentNum}/{currentDen} (Примерно: {(double)currentNum / currentDen:F4})");

    num_prev2 = num_prev1;
    den_prev2 = den_prev1;
    num_prev1 = currentNum;
    den_prev1 = currentDen;
}

string kthTermFraction = $"{currentNum}/{currentDen}";
if (n < 3) kthTermFraction = (n == 1) ? "1/1" : "2/1";

Console.WriteLine($"\nа) {n}-й (k-й) член этой последовательности: **{kthTermFraction}**");