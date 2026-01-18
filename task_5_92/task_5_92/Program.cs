Console.Write("Введите натуральное число N (больше 1): ");

int n = int.Parse(Console.ReadLine());

if (n <= 1)
{
    Console.WriteLine($"\nЧисло {n} по определению не является простым (или составным).");
    return;
}

bool isPrime = true;

int limit = (int)Math.Sqrt(n);

for (int i = 2; i <= limit; i++)
{
   
    if (n % i == 0)
    {
        isPrime = false; 
        break;           
    }
}

if (isPrime)
{
    Console.WriteLine($"\nЧисло {n} является **простым**.");
}
else
{
    Console.WriteLine($"\nЧисло {n} является **составным**.");
}