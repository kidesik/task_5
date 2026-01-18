const double RHO_0 = 1.29;
const double Z = 1.25e-4; 
Console.WriteLine("Высота h, м | Плотность ρ, кг/м³");
Console.WriteLine("\n");

for (int h = 0; h <= 1000; h += 100)
{
    double rho = RHO_0 * Math.Exp(-h * Z);
    Console.WriteLine($"{h,-12}| {rho,20:F5}");
}