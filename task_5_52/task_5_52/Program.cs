int numSpheres = 12;
double wallThicknessCM = 0.5;
double initialInnerRadiusCM = 5.0;
double totalVolumeCM3 = 0.0;

for (int k = 1; k <= numSpheres; k++)
{
    double innerRadius = initialInnerRadiusCM + (k - 1) * wallThicknessCM;
    double outerRadius = innerRadius + wallThicknessCM;

    double volume_k = (4.0 / 3.0) * Math.PI * (Math.Pow(outerRadius, 3) - Math.Pow(innerRadius, 3));

    totalVolumeCM3 += volume_k;
}
double totalVolumeLiters = totalVolumeCM3 / 1000.0;

Console.WriteLine($"Суммарный объем в литрах: {totalVolumeLiters:F3} л");