namespace Shared
{
    public class MyMath
    {
        public static double Factorial(int n)
        {
            // Inicializa el resultado como 1 (ya que el factorial de 0 es 1)
            double factorial = 1;
            // Multiplica factorial por cada entero desde 2 hasta n
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            // Devuelve el valor del factorial calculado
            return factorial;
        }

        public static bool IsPrime(int n)
        {
            // Recorre todos los números enteros desde 2 hasta la raíz cuadrada de n
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                // Si n es divisible por i, entonces n no es primo y retorna falso
                if (n % i == 0) return false;
            }
            // Si no se encontró ningún divisor, n es primo y retorna verdadero
            return true;
        }
    }
}