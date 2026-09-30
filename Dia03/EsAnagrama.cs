namespace Practicas_Logica_CSharp.Dia03;

//Escribe una función que reciba dos palabras (String) y retorne verdadero o falso (Bool) según sean o no anagramas.
//Un Anagrama consiste en formar una palabra reordenando TODAS
//las letras de otra palabra inicial.
// NO hace falta comprobar que ambas palabras existan.
//Dos palabras exactamente iguales no son anagrama.
public class Dia03
{
    public static bool EsAnagrama(string p1,string p2)
    {
        if(string.IsNullOrWhiteSpace(p1)|| string.IsNullOrWhiteSpace(p2))
        {
            return false;
        }
        p1 = p1.ToUpper();
        p2 = p2.ToUpper();
        
        if (p1 == p2) return false;

        if (p1.Length != p2.Length) return false;

        int[] frecuencias = new int[256];

        for (int i = 0; i < p1.Length; i++)
        {
            frecuencias[p1[i]]++; // Suma 1 a la letra de la palabra 1
            frecuencias[p2[i]]--; // Resta 1 a la letra de la palabra 2
        }

        for (int i = 0; i < frecuencias.Length; i++)
        {
            if (frecuencias[i] != 0)
            {
                return false; // Había una letra de más o de menos
            }
        }
        return true; 
    
    }
    public static void Ejecutar()
    {
        Console.WriteLine(" DIA 03: Verificador de Anagramas");

        Console.WriteLine($"'roma' y 'amor': {EsAnagrama("roma","amor")}"); // True
        Console.WriteLine($"'Roma' y 'AMOR': {EsAnagrama("Roma","AMOR")}"); // True
        Console.WriteLine($"'roma' y 'roma': {EsAnagrama("roma","roma")}"); // False 
        Console.WriteLine($"'hola' y 'chau': {EsAnagrama("hola","chau")}"); // False 
        Console.WriteLine($"'casa' y 'casas': {EsAnagrama("casa","casas")}"); //False

    }
}
