double unitPrice = 20.4;
Console.WriteLine("Кол-во шт | Стоимость, руб.");
Console.WriteLine("\n");

for (int quantity = 2; quantity <= 20; quantity++)
{
    double totalCost = quantity * unitPrice;
    Console.WriteLine($"{quantity,-9} | {totalCost,15:F2}");
}