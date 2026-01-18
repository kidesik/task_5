decimal initialDeposit = 1000m; 
decimal rate = 0.02m;           
int totalMonths = 12;

decimal currentAmount = initialDeposit;
Console.WriteLine($"\nНачальный вклад: {currentAmount:C2}\n");

Console.WriteLine("а) Прирост суммы вклада за каждый месяц (1-й по 10-й):");

Dictionary<int, decimal> amountsByMonth = new Dictionary<int, decimal>();

for (int month = 1; month <= totalMonths; month++)
{
    decimal monthlyIncrease = currentAmount * rate;

    if (month <= 10)
    {
        Console.WriteLine($"   Месяц {month}: Прирост **{monthlyIncrease:C2}**");
    }

    currentAmount += monthlyIncrease;

    if (month == 3 || month == 4 || month == 12)
    {
        amountsByMonth[month] = currentAmount;
    }
}

Console.WriteLine("\nб) Сумма вклада через три, четыре, двенадцать месяцев:");
Console.WriteLine($"   Через 3 месяца: **{amountsByMonth[3]:C2}**");
Console.WriteLine($"   Через 4 месяца: **{amountsByMonth[4]:C2}**");
Console.WriteLine($"   Через 12 месяцев: **{amountsByMonth[12]:C2}**");