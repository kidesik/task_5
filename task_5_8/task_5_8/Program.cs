const double KG_PER_POUND = 0.453; 
Console.WriteLine("Фунты     Кг");
Console.WriteLine("\n");

for (int pounds = 1; pounds <= 10; pounds++)
{
    double kilograms = pounds * KG_PER_POUND;
    Console.WriteLine($"{pounds,-10}{kilograms,8:F3}");
}