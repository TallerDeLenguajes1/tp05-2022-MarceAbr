//Ejercicio 2 - Calculadora V2
int continuar2, valor2;
double numero3, numero4, numero5, resutado2;
do
{
    Console.WriteLine("\nIndique la operacion que desea realizar: 1-VALOR ABS / 2-POTENCIA / 3-RAIZ / 4-SENO / 5-COS / 6-PARTE ENTERA: ");
    valor2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ahora indique el numero de la operacion: ");
    numero3 = double.Parse(Console.ReadLine());

    switch (valor2)
    {
        case 1:
            resutado2 = Math.Abs(numero3);
            Console.WriteLine("El valor absoluto del numero es: " + resutado2);
            break;
        case 2:
            Console.WriteLine("El cuadrado del numero es: " + Math.Pow(numero3,2));
            break;
        case 3:
            Console.WriteLine("La raiz cuadrada del numero es: " + Math.Sqrt(numero3));
            break;
        case 4:
            Console.WriteLine("El seno del numero es: " + Math.Sin(numero3));
            break;
        case 5:
            Console.WriteLine("El coseno del numero es: " + Math.Cos(numero3));
            break;
        case 6:
            Console.WriteLine("La parte entera del numero es: " + Math.Truncate(numero3));
            break;
    }
    Console.WriteLine("Desea realizar otra operacion? 1-SI / 0-NO");
    continuar2 = int.Parse(Console.ReadLine());
} while (continuar2 > 0);

Console.WriteLine("\nIndique 2 numeros para comprobar el mayor y menor");
Console.WriteLine("\nIndique el primer numero: ");
numero4 = double.Parse(Console.ReadLine());
Console.WriteLine("Indique el segundo numero: ");
numero3 = double.Parse(Console.ReadLine());

Console.WriteLine("\nIndique lo que desea: 1-MAYOR / 2-MENOR: ");
valor2 = int.Parse(Console.ReadLine());

if (valor2 == 1)
{
    Console.WriteLine("El mayor entre ambos numeros es: " + max(numero4, numero3));
} else {
    Console.WriteLine("El mayor entre ambos numeros es: " + min(numero4, numero3));
}

double max(double num1, double num2)
{
    if(num1>=num2){
        return num1;
    } else {
        return num2;
    }
}

double min(double num1, double num2)
{
    if(num1<=num2){
        return num1;
    } else {
        return num2;
    }
}