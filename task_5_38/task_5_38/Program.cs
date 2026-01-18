double x = 2.0;
double sum = 0.0;

for (int i = 1; i <= 11; i += 2)
{
    double term = Math.Pow(x, i) / i;
    sum += term;
}

Console.WriteLine($"Сумма ряда при x = {x}: {sum:F4}\n");