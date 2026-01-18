const double CM_PER_INCH = 2.54; 
Console.WriteLine("Дюймы     См");
Console.WriteLine("\n");

for (int inches = 10; inches <= 22; inches++)
{
    double centimeters = inches * CM_PER_INCH;
    Console.WriteLine($"{inches,-10}{centimeters,8:F2}");
}