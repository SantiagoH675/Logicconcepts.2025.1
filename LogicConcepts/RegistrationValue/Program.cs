using Shared;
var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{
    var credits = ConsoleExtension.GetInt        ("Numeros de creditos.........: ");
    var creditValue = ConsoleExtension.GetDecimal("Valor credito...............: ");
    var stratum = ConsoleExtension.GetInt        ("Estrato del estudiante......: ");

    var registrationValue = CalculateregistrationValue(credits, creditValue, stratum);
    var subsidy = CalculateSubsidy(stratum);

    Console.WriteLine($"Costo de la matricula.......:{registrationValue,20:C2}");
    Console.WriteLine($"Costo de la matricula.......:{subsidy,20:C2}");
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Desea continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over");
decimal CalculateSubsidy(int stratum)
{
    if (stratum == 1)
    {
        return 200000m;
    }
    if (stratum == 2)
    {
        return 100000m;
    }
    return 0;
}

decimal CalculateregistrationValue(int credits, decimal creditValue, int stratum)
{
    decimal value;
    if (credits <= 20)
    {
        value = credits * creditValue;
    }
    else
    {
        value = 20 * creditValue + (credits - 20) * creditValue * 2;
    }
    if (stratum == 1)
    {
        return value * 0.2m;
    }
    if (stratum == 2)
    {
        return value * 0.5m;
    }
    if (stratum == 3)
    {
        return value * 0.7m;
    }
    return value;
}
