List<int> foundNumbers = new List<int>();

for (int i = 10; i <= 99; i++)
{
    int tensDigit = i / 10; 
    int unitsDigit = i % 10; 

    int sumOfSquares = (tensDigit * tensDigit) + (unitsDigit * unitsDigit);

    if (sumOfSquares % 13 == 0)
    {
        foundNumbers.Add(i);
    }
}

Console.WriteLine("\nНайденные числа: **" + string.Join(", ", foundNumbers) + "**");
List<int> foundNumbers_b = new List<int>();

for (int i = 10; i <= 99; i++)
{
    int tensDigit = i / 10; 
    int unitsDigit = i % 10; 

    int sumOfDigits = tensDigit + unitsDigit;

    int calculatedValue = sumOfDigits + (sumOfDigits * sumOfDigits);

    if (calculatedValue == i)
    {
        foundNumbers_b.Add(i);
    }
}

Console.WriteLine("\nНайденные числа: **" + string.Join(", ", foundNumbers_b) + "**");
