
namespace Calculadora
{
    class RaioUtils
    {
        public static double Pi = 3.14;
        public static double CalcularCircunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        public static double CalcularVolume(double raio)
        {
            return 4.0 / 3.0 * Pi * raio * raio * raio;
        }
    } 
}