Console.Write("Введите текущий курс 1 доллара США в рублях: ");
double exchangeRate = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Доллары США | Рубли");
Console.WriteLine("\n");
for (int dollars = 1; dollars <= 20; dollars++)
{
    double rubles = dollars * exchangeRate;
    Console.WriteLine($"{dollars,-12}| {rubles,10:F2}");
}