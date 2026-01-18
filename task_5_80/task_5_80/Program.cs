Console.Write("Введите натуральное число 'n' (от 1 до 9): ");

int n = int.Parse(Console.ReadLine());

string nAsString = n.ToString();
List<int> foundNumbers = new List<int>();

for (int i = 10; i <= 99; i++)
{
    bool isDivisible = (i % n == 0);

    bool containsDigit = i.ToString().Contains(nAsString);

    if (isDivisible || containsDigit)
    {
        foundNumbers.Add(i);
    }
}

if (foundNumbers.Count > 0)
{
    Console.WriteLine($"\nНайденные двузначные числа, делящиеся на {n} или содержащие цифру {n}:");
    Console.WriteLine(string.Join(", ", foundNumbers));
}
else
{
    Console.WriteLine("\nПодходящих двузначных чисел не найдено.");
}