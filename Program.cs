using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("CALCULADORA");
        Console.WriteLine("______________");

        while (true)
        {
            Console.WriteLine("Seleccione una operación:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");



            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Operacion(Sum, "+");
                    break;
                case "2":
                    Operacion(Resta, "-");
                    break;
                case "3":
                    Operacion(Multpl, "*");
                    break;
                case "4":
                    Operacion(Division, "/");
                    break;
                case "5":
                    Console.WriteLine("Gracias");
                    return;
                default:
                    Console.WriteLine("Opción incorrecta. Intente de nuevo.");
                    break;
            }
        }
    }

    static void Operacion(Func<double, double, double> operacion, string operador)
    {
        double num1, num2;

        while (true)
        {
            try
            {
                Console.Write("Ingrese el primer número: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                break; // Si la conversión es exitosa, salimos del bucle.
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Ingrese un número válido. Intente de nuevo.");
            }
        }

        double resultado = operacion(num1, num2);

        Console.WriteLine($"El resultado de {num1} {operador} {num2} es: {resultado}");
    }

    static double Sum(double a, double b) => a + b;

    static double Resta(double a, double b) => a - b;

    static double Multpl(double a, double b) => a * b;

    static double Division(double a, double b)
    {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            Console.WriteLine("Error: No se puede dividir por cero.");
            return 0;
        }
    }
}