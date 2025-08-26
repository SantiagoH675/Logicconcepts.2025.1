﻿using Shared;
var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{
    var name = ConsoleExtension.GetString          ("Ingrese nombre........................ : ");
    var workHours = ConsoleExtension.GetFloat      ("Ingrese el numero de horas trabajadas..: ");
    var hourValue = ConsoleExtension.GetDecimal    ("Ingrese el valor hora..................: ");
    var salaryMinimun = ConsoleExtension.GetDecimal("Ingrese el salario minimo mensual......: ");

    var salary = (decimal)workHours * hourValue;
    if (salary < salaryMinimun)
    {
        Console.WriteLine($"Nombre ................................: {name}");
        Console.WriteLine($"Salario ...............................: {salaryMinimun:C2}");
    }
    else
    {
        Console.WriteLine($"Nombre.................................: {name}");
        Console.WriteLine($"Salario................................: {salary:C2}");
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Desea continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Game Over");