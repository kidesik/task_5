int count = 0;

for (int i = 100; i <= 500; i++)
{
    int sumOfDigits = 0;
    int temp = i; 
    while (temp > 0)
    {
        sumOfDigits += temp % 10; 
        temp /= 10;               
    }

    if (sumOfDigits == 15)
    {
        count++;
    }
}

Console.WriteLine($"\nКоличество чисел с суммой цифр, равной 15: **{count}**\n");
