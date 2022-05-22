// Ejercicio 1 - Invertir
int numero, ultimoDig, invertido = 0;
Console.WriteLine("Digite un numero para invertir: ");
numero = int.Parse(Console.ReadLine());

while (numero > 0)
{    
    ultimoDig = numero % 10;
    invertido = invertido * 10 + ultimoDig;
    numero = numero/10;
}
Console.WriteLine("El numero es: " + invertido);