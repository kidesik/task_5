double sum = 0.0;
double currentTerm = 1.0; 
for (int i = 0; i <= 8; i++)
{
    sum += currentTerm;
    currentTerm /= 3.0;
}
Console.WriteLine($"Сумма ряда: {sum:F6}\n"); 
