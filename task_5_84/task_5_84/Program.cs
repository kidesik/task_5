long sum = 0; 
for (int i = 100; i <= 998; i += 2)
{
    sum += i;
}

Console.WriteLine($"\nСумма всех четных трехзначных чисел равна: **{sum}**\n");
