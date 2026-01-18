double initialArea = 100.0; 
double initialYield = 20.0; 
double areaGrowthRate = 1.05; 
double yieldGrowthRate = 1.02; 
List<double> areas = new List<double> { initialArea };
List<double> yields = new List<double> { initialYield };
List<double> harvests = new List<double>(); 
for (int i = 1; i <= 8; i++)
{
    double currentHarvest = areas.Last() * yields.Last();
    harvests.Add(currentHarvest);

    if (i < 8)
    {
        double nextArea = areas.Last() * areaGrowthRate;
        double nextYield = yields.Last() * yieldGrowthRate;
        areas.Add(nextArea);
        yields.Add(nextYield);
    }
}

Console.WriteLine("\nа) Урожайность за второй, третий, ..., восьмой год:");

for (int i = 1; i < yields.Count; i++)
{
    Console.WriteLine($"   Год {i + 1}: **{yields[i]:F2}** ц/га");
}

Console.WriteLine("\nб) Площадь участка в четвертый, пятый, ..., седьмой год:");

for (int i = 3; i < 7; i++)
{
    Console.WriteLine($"   Год {i + 1}: **{areas[i]:F2}** га");
}

Console.WriteLine("\nв) Какой урожай будет собран за первые шесть лет:");
double totalHarvestSixYears = harvests.Take(6).Sum();
Console.WriteLine($"   Суммарный урожай: **{totalHarvestSixYears:F2}** ц");
