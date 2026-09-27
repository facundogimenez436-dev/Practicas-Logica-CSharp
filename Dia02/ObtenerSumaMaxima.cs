namespace Practicas_Logica_CSharp.Dia02;

public class Dia02
{
    public static int ObtenerSumaMaxima(int[] numeros)
    {
        if (numeros == null || numeros.Length == 0 )
        {
            throw new ArgumentException("El arreglo no puede ser nulo o estar vacion");
        }
        int sumaActual = numeros[0];
        int sumaMaxima = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            // ¿Conviene empezar un nuevo subarreglo en numeros[i] o sumar al que traemos?
            int sumaConActual = sumaActual + numeros[i];

            if (numeros[i] > sumaConActual)
            {
                sumaActual = numeros[i];
            }
            else
            {
                sumaActual = sumaConActual;
            }

            // Actualizamos la suma maxima si la actual supero la anterior
            if (sumaActual > sumaMaxima)
            {
                sumaMaxima = sumaActual;
            }
        }
        return sumaMaxima;
    }
    public static void Ejecutar()
    {
        Console.WriteLine("DÍA 02: Verificador de Suma Maxima");

        int[] prueba = [-2, 1, -3, 4, -1, 2, 1, -5, 4];

        Console.WriteLine($"suma maxima: {ObtenerSumaMaxima(prueba)}");
    }
}