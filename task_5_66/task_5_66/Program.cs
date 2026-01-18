long totalSum = 0;
for (int k = 1; k <= 12; k++)
{
    int currentSquare = 0;
    for (int j = 1; j <= k; j++)
    {
        int oddNumber = 2 * j - 1;
        currentSquare += oddNumber;
    }
    totalSum += currentSquare;
}

Console.WriteLine($"\nСумма 1² + 2² + ... + 12² равна: {totalSum}");