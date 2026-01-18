Console.Write("Введите натуральное число 'n' (n >= 4): ");
int n = int.Parse(Console.ReadLine());

double v_prev3 = 0.0; 
double v_prev2 = 0.0; 
double v_prev1 = 1.5; 
double currentV = 0.0;
for (int i = 4; i <= n; i++)
{
    double numerator = ((i - 1) * v_prev1) - v_prev2 + v_prev3;
    double denominator = (double)(i * i + 1);
    currentV = numerator / denominator;
    v_prev3 = v_prev2;
    v_prev2 = v_prev1;
    v_prev1 = currentV;
}

double result = (n == 4) ? currentV : v_prev1;

Console.WriteLine($"\n{n}-й член последовательности v{n}: **{result:F6}**");