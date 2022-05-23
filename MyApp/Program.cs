//Ejercicio 2 - Calculadora
int numero1, numero2, resultado = 0, continuar, valor;

do
{
    Console.WriteLine("Indique la operacion que desea realizar: 1-SUMA / 2-RESTA / 3-MULTIPLICACION / 4-DIVISION: ");
    valor = int.Parse(Console.ReadLine());
    Console.WriteLine("Ahora indique el primer numero de la operacion: ");
    numero1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ahora indique el segundo numero de la operacion: ");
    numero2 = int.Parse(Console.ReadLine());

    switch (valor)
    {
        case 1:
            resultado = numero1 + numero2;
            break;
        case 2:
            resultado = numero1 - numero2;
            break;
        case 3:
            resultado = numero1 * numero2;
            break;
        case 4:
            resultado = numero1 / numero2;
            break;
    }

    Console.WriteLine("El resultado de la operacion es: " + resultado);
    Console.WriteLine("Desea realizar otra operacion? 1-SI / 0-NO");
    continuar = int.Parse(Console.ReadLine());
    Console.WriteLine("\n");
} while (continuar > 0);