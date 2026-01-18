Console.Write("Введите стоимость 1 кг конфет в рублях: ");

double pricePerKg = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Масса, г | Стоимость, руб.");
Console.WriteLine("\n");
for (int grams = 100; grams <= 2000; grams += 100)
{
    double cost = (grams / 1000.0) * pricePerKg;
    Console.WriteLine($"{grams,-9} | {cost,15:F2}");
}