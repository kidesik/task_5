Console.Write("Введите стоимость 1 кг сыра в рублях: ");

double pricePerKg = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Масса, г | Стоимость, руб.");
Console.WriteLine("\n");

for (int grams = 50; grams <= 1000; grams += 50)
{
    double cost = (grams / 1000.0) * pricePerKg;
    Console.WriteLine($"{grams,-9} | {cost,15:F2}");
}