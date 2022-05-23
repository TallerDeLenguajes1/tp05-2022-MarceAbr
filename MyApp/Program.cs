//Ejercicio 2 - Calculadora V2
int continuar, valor;
double numero1, numero2, numero3, resutado;
do
{
    Console.WriteLine("\nIndique la operacion que desea realizar: 1-VALOR ABS / 2-POTENCIA / 3-RAIZ / 4-SENO / 5-COS / 6-PARTE ENTERA: ");
    valor = int.Parse(Console.ReadLine());
    Console.WriteLine("Ahora indique el numero de la operacion: ");
    numero1 = double.Parse(Console.ReadLine());

    switch (valor)
    {
        case 1:
            resutado = Math.Abs(numero1);
            Console.WriteLine("El valor absoluto del numero es: " + resutado);
            break;
        case 2:
            Console.WriteLine("El cuadrado del numero es: " + Math.Pow(numero1,2));
            break;
        case 3:
            Console.WriteLine("La raiz cuadrada del numero es: " + Math.Sqrt(numero1));
            break;
        case 4:
            Console.WriteLine("El seno del numero es: " + Math.Sin(numero1));
            break;
        case 5:
            Console.WriteLine("El coseno del numero es: " + Math.Cos(numero1));
            break;
        case 6:
            Console.WriteLine("La parte entera del numero es: " + Math.Truncate(numero1));
            break;
    }
    Console.WriteLine("Desea realizar otra operacion? 1-SI / 0-NO");
    continuar = int.Parse(Console.ReadLine());
} while (continuar > 0);

Console.WriteLine("\nIndique 2 numeros para comprobar el mayor y menor");
Console.WriteLine("\nIndique el primer numero: ");
numero2 = double.Parse(Console.ReadLine());
Console.WriteLine("Indique el segundo numero: ");
numero3 = double.Parse(Console.ReadLine());

Console.WriteLine("\nIndique lo que desea: 1-MAYOR / 2-MENOR: ");
valor = int.Parse(Console.ReadLine());

if (valor == 1)
{
    Console.WriteLine("El mayor entre ambos numeros es: " + max(numero2, numero3));
} else {
    Console.WriteLine("El mayor entre ambos numeros es: " + min(numero2, numero3));
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