using System;

namespace sums
{
    class CalcSum
    {
        static void Main(string[] args)
        {
            Console.Title = "Sumas Calc";

            string resp = "";

            do
            {
                Console.WriteLine("+ Vamo a sumar");

                Console.WriteLine("Mete los numeros compa");
                Console.Write("num1: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("num2: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("El resultado de la suma es:");
                int R = num1 + num2;
                Console.WriteLine("{0} + {1} = {2}", num1, num2, R);

                Console.Write("¿Desea Continuar? s/n: ");
                resp = Console.ReadLine();
            } while (resp == "s" || resp == "S");
        }
    }
}