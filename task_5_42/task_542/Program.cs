{
    int N = 100;
    double position = 0.0;
    int sign = 1;

    for (int i = 1; i <= N; i++)
    {
        position += (double)sign / i;
        sign *= -1;
    }

    Console.WriteLine($"а) Расстояние от дома после {N}-го этапа: {position:F6} км");
}
{
    double totalDistance = 0.0;

    for (int i = 1; i <= N; i++)
    {
        totalDistance += 1.0 / i;
    }

    Console.WriteLine($"б) Общий путь после {N}-го этапа: {totalDistance:F6} км");
}