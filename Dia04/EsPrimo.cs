namespace Practicas_Logica_CSharp.Dia04;

//Escribe un programa que se encargue de comprobar si un número es o no primo.
//Hecho esto, imprime los números primos entre 1 y 100.
public class Dia04
{
    public static bool EsPrimo(int numero)
    {
        if (numero < 2) return false;
        if (numero == 2) return true;
        if (numero % 2 == 0) return false;
    
        for (int i = 3; i * i <= numero; i+=2)
        {
            if (numero % i == 0) return false;
        }
        return true;
    }
    public static void Ejecutar()
    {
        Console.WriteLine(" DIA 04: Verificador de numeros primos (1 - 100)");

        for (int i = 1; i <= 100; i++)
        {
            if (EsPrimo(i))
            {
            Console.WriteLine($"-{i}"); 
            }
        }
    }
}