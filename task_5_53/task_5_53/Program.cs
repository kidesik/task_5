long sum = 0;
long currentPowerOfTwo = 4;
for (int i = 0; i < 9; i++)
{
    sum += currentPowerOfTwo;
    currentPowerOfTwo *= 2;
}

Console.WriteLine($"Сумма ряда: **{sum}**\n");