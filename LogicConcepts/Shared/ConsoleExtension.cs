namespace Shared
{
    public class ConsoleExtension
    {
        // Solicita al usuario un número entero y lo devuelve. Si la entrada no es válida, retorna 0.
        public static int GetInt(string message)
        {
            Console.Write(message); // Muestra el mensaje al usuario.
            var numberString = Console.ReadLine(); // Lee la entrada del usuario como string.
            if (int.TryParse(numberString, out int numberInt)) // Intenta convertir la entrada a int.
            {
                return numberInt; // Si es válido, retorna el número.
            }

            return 0; // Si no es válido, retorna 0.
        }

        // Solicita al usuario un número flotante y lo devuelve. Si la entrada no es válida, retorna 0.
        public static float GetFloat(string message)
        {
            Console.Write(message); // Muestra el mensaje al usuario.
            var numberString = Console.ReadLine(); // Lee la entrada del usuario como string.
            if (float.TryParse(numberString, out float numberFloat)) // Intenta convertir la entrada a float.
            {
                return numberFloat; // Si es válido, retorna el número.
            }

            return 0; // Si no es válido, retorna 0.
        }

        // Solicita al usuario un número double y lo devuelve. Si la entrada no es válida, retorna 0.
        public static double GetDouble(string message)
        {
            Console.Write(message); // Muestra el mensaje al usuario.
            var numberString = Console.ReadLine(); // Lee la entrada del usuario como string.
            if (double.TryParse(numberString, out double numberDouble)) // Intenta convertir la entrada a double.
            {
                return numberDouble; // Si es válido, retorna el número.
            }

            return 0; // Si no es válido, retorna 0.
        }

        // Solicita al usuario un número decimal y lo devuelve. Si la entrada no es válida, retorna 0.
        public static decimal GetDecimal(string message)
        {
            Console.Write(message); // Muestra el mensaje al usuario.
            var numberString = Console.ReadLine(); // Lee la entrada del usuario como string.
            if (decimal.TryParse(numberString, out decimal numberDecimal)) // Intenta convertir la entrada a decimal.
            {
                return numberDecimal; // Si es válido, retorna el número.
            }

            return 0; // Si no es válido, retorna 0.
        }

        // Solicita al usuario una cadena de texto y la devuelve.
        public static string? GetString(string message)
        {
            Console.Write(message); // Muestra el mensaje al usuario.
            var text = Console.ReadLine(); // Lee la entrada del usuario como string.
            return text; // Retorna la cadena ingresada (puede ser null).
        }

        // Solicita al usuario una opción válida de una lista y la devuelve. Si no es válida, retorna null.
        public static string? GetValidOptions(string message, List<string> options)
        {
            Console.Write(message); // Muestra el mensaje al usuario.
            var answer = Console.ReadLine(); // Lee la entrada del usuario como string.
            if (options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase))) // Verifica si la respuesta está en la lista de opciones (ignorando mayúsculas/minúsculas).
            {
                return answer; // Si es válida, retorna la respuesta.
            }
            return null; // Si no es válida, retorna null.
        }

    }
}