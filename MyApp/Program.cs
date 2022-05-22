// Ejercicio 1 - Invertir
int numero, resto, invertido = 0;
Console.WriteLine("Digite un numero para invertir: ");
numero = int.Parse(Console.ReadLine());

while (numero >= 1)
{    
    resto = numero % 10;
    numero /= 10;
    if (invertido == 0)
    {
        invertido = (resto * 10);
    } else {
        if (numero > 0)
        {
            invertido = (invertido + resto) * 10;
        } else {
            invertido = invertido + resto;
        }
    }
}
Console.WriteLine("El numero es: " + invertido);