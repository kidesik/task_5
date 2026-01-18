Console.Write("Введите натуральное число N: ");
long number = long.Parse(Console.ReadLine());

Console.Write("Введите количество последних цифр k: ");
int k = int.Parse(Console.ReadLine());

long sumOfDigits = 0;
long productOfDigits = 1;

for (int i = 0; i < k; i++)
{
    long digit = number % 10;
    sumOfDigits += digit;
    productOfDigits *= digit;
    number /= 10;
}

Console.WriteLine($"\nСумма последних {k} цифр: **{sumOfDigits}**");
Console.WriteLine($"Произведение последних {k} цифр: **{productOfDigits}**\n");