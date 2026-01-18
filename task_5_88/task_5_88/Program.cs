Console.Write("Введите желаемую сумму цифр 's' (от 1 до 26): ");

int s = int.Parse(Console.ReadLine());

if (s <= 0 || s >= 27)
{
    Console.WriteLine("Значение S должно быть в интервале от 1 до 26.");
    return;
}

int count = 0;

for (int i = 100; i <= 999; i++)
{
    int sumOfDigits = 0;
    int temp = i; 
    while (temp > 0)
    {
        sumOfDigits += temp % 10; 
        temp /= 10;               
    }

    if (sumOfDigits == s)
    {
        count++;
    }
}

Console.WriteLine($"\nКоличество чисел с суммой цифр, равной {s}: **{count}**\n");
