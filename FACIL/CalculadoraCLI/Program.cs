using System;

namespace CalculadoraCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la Calculadora CLI");
            Console.WriteLine("Introduce dos números:");

            // Leer los números del usuario
            Console.Write("Número 1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Número 2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Selecciona una operación:");
            Console.WriteLine("1. Sumar (+)");
            Console.WriteLine("2. Restar (-)");
            Console.WriteLine("3. Multiplicar (*)");
            Console.WriteLine("4. Dividir (/)");

            Console.Write("Opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            double resultado = 0;

            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
                    break;
                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
                    break;
                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine($"Resultado: {num1} * {num2} = {resultado}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"Resultado: {num1} / {num2} = {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}