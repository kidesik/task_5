double x = 2.0;
double sum = 0.0;
int sign = 1;

for (int i = 0; i <= 10; i++) { 
    double termValue = (i + 1) * Math.Pow(x, i);
    sum += sign * termValue;
    sign *= -1;
}
Console.WriteLine($"Сумма ряда при x = {x}: {sum:F4}\n");