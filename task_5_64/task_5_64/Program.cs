Console.Write("Введите семизначное число: ");
long originalNumber = long.Parse(Console.ReadLine());
long tempNumber = originalNumber;
long reversedNumber = 0;
while (tempNumber > 0)
{ long digit = tempNumber % 10;
    reversedNumber = (reversedNumber * 10) + digit;
    tempNumber /= 10;
}

Console.WriteLine($"\nИсходное число: {originalNumber}");
Console.WriteLine($"Число, полученное при прочтении справа налево: **{reversedNumber}**\n");
