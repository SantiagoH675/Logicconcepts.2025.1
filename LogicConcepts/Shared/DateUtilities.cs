namespace Shared
{
    public class DateUtilities
    {
        public static bool IsLeapYear(int year)
        {
            // Verifica si el año es divisible por 4 (regla básica para años bisiestos)
            if (year % 4 == 0)
            {
                // Si es divisible por 4, verifica si también es divisible por 100 (años de siglo)
                if (year % 100 == 0)
                {
                    // Si es divisible por 100, verifica si también es divisible por 400 (excepción para años de siglo)
                    if (year % 400 == 0)
                    {
                        // Los años divisibles por 400 son bisiestos
                        return true;
                    }
                    // Los años divisibles por 100 pero no por 400 no son bisiestos
                    return false;
                }
                // Los años divisibles por 4 pero no por 100 son bisiestos
                return true;
            }
            // Los años que no son divisibles por 4 no son bisiestos
            return false;
        }
    }
}