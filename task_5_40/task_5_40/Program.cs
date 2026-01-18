Console.Write("Введите 9-значное число: ");
long number = long.Parse(Console.ReadLine());
long originalNumber = number; 

int sumOfDigits = 0;
while (number > 0)
{
    long digit = number % 10;
    sumOfDigits += (int)digit;
    number /= 10;
}

Console.WriteLine($"Сумма цифр числа {originalNumber}: {sumOfDigits}\n");