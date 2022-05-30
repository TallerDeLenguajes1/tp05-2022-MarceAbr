// Ejercicio 4

string frase, frase2, frase3, fraseConcatenada, subcadena;
Console.WriteLine("Escriba una frase: ");
frase = Console.ReadLine();

int longitudCadena = frase.Length;
Console.WriteLine("La longitud de la cadena es: " + longitudCadena);

Console.WriteLine("\nmEscriba una segunda frase: ");
frase2 = Console.ReadLine();

fraseConcatenada = frase + " " + frase2;
Console.WriteLine("\nLa frase concatenada es: ");
Console.WriteLine(fraseConcatenada);

Console.WriteLine("\nIndique la longitud de la subcadena: ");
int num = int.Parse(Console.ReadLine());
subcadena = fraseConcatenada.Substring(0,num);
Console.WriteLine("La subcadena es: ");
Console.WriteLine(subcadena);

// foreach (char item in fraseConcatenada)
// {
//     Console.WriteLine(item);
// }

char letra;
Console.WriteLine("\nIndique una letra para buscar en la cadena: ");
letra = char.Parse(Console.ReadLine());
Console.WriteLine("La letra '" + letra + "' se repite " + ocurrencias(fraseConcatenada, letra) + " veces");

Console.WriteLine("\nCadena en mayusculas: " + fraseConcatenada.ToUpper());
Console.WriteLine("Cadena en minusculas: " + fraseConcatenada.ToLower());

Console.WriteLine("\nIngrese una tercera frase: ");
frase3 = Console.ReadLine();

// ------------------------ FUNCIONES ------------------------

int ocurrencias(string cadena, char letra)
{
    int cantidad = 0;
    foreach (char item in cadena)
    {
        if(item == letra)
        {
            cantidad++;
        }
    }
    return cantidad;
}