namespace Practicas_Logica_CSharp.Dia01;

public class Dia01
{
    public static bool EsSubsecuenciaPalindroma(List<int> numeros)
    {
        
        if (numeros == null)
        {
            throw new ArgumentNullException(nameof(numeros), "La lista no puede ser nula.");
        }
        if (numeros.Count <= 1) return true; 

        // 2. Inicializamos los dos punteros
        int izquierda = 0;
        int derecha = numeros.Count - 1;

        // 3. El bucle se ejecuta hasta que los punteros se crucen en el centro
        while (izquierda < derecha)
        {
            // Si los elementos en ambos extremos no coinciden, no es un palíndromo
            if (numeros[izquierda] != numeros[derecha])
            {
                return false;
            }

            // Movemos los punteros hacia el centro
            izquierda++;
            derecha--;
        }

        // Si el bucle termina sin encontrar diferencias, es un palíndromo válido
        return true;
    }

    public static void Ejecutar()
    {
        
        Console.WriteLine("DÍA 01: Verificador de Palíndromos");

        // Casos de prueba para verificar que funcione correctamente
        List<int> casoExito = new List<int> { 1, 2, 3, 2, 1 };
        List<int> casoError = new List<int> { 1, 2, 3, 4, 5 };

        Console.WriteLine($"Prueba 1 ¿Es palíndromo?: {EsSubsecuenciaPalindroma(casoExito)}");
        Console.WriteLine($"Prueba 2 ¿Es palíndromo?: {EsSubsecuenciaPalindroma(casoError)}");

    }
}