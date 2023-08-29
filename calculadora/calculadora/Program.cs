int number_1 = 0;
int number_2 = 0;
int opcion = 0;
int resultado = 0;

Console.WriteLine("*********************************************");
Console.WriteLine("Bienvenido a la calculadora en C#");
Console.WriteLine("*********************************************");

Console.WriteLine("Ingrese el primer digito: ");
number_1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo digito: ");
number_2 = int.Parse(Console.ReadLine());


Console.WriteLine("******************************************");
Console.WriteLine("Seleccione una opcion aritmetica......");
Console.WriteLine("******************************************");

Console.WriteLine("1. Suma");
Console.WriteLine("2. Resta");
Console.WriteLine("3. Division");
Console.WriteLine("4. Multiplicacion");
opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        resultado = number_1 + number_2;
        Console.WriteLine("El resultado es: " + resultado);
        break;
    case 2:
        resultado = number_1 - number_2;
        Console.WriteLine("El resultado es: " + resultado);
        break;
    case 3:
        resultado = number_1 / number_2;
        Console.WriteLine("El resultado es: " + resultado);
        break;
    case 4:
        resultado = number_1 * number_2;
        Console.WriteLine("El resultado es: " + resultado);
        break;
}

Console.Write("presiona para continuar . . . ");
Console.ReadKey(true);

