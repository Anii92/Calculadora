using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        private enum Opciones
        {
            Suma,
            Resta,
            Multiplicacion,
            Division,
            Salir
        };

        private static void MostrarOpciones()
        {
            Console.WriteLine("Selecciona una opción:");
            Console.WriteLine("0. Sumar");
            Console.WriteLine("1. Restar");
            Console.WriteLine("2. Multiplicar");
            Console.WriteLine("3. Dividir");
            Console.WriteLine("4. Salir");
        }

        private static void MostrarOpcionesOperacionNumerica(bool primerNumero)
        {
            if (primerNumero)
            {
                Console.WriteLine("Porfavor, introduce el primer número");
            }
            else
            {
                Console.WriteLine("Porfavor, introduce el segundo número");
            }
        }

        static void Main(string[] args)
        {
            ICalculadora iCalculadora = new Calculadora();
            bool exit = false;
            while (!exit)
            {
                MostrarOpciones();
                ConsoleKeyInfo opcion = Console.ReadKey();
                Console.WriteLine();
                Opciones tryParseResult;
                string aux = (opcion.KeyChar).ToString();
                Enum.TryParse<Opciones>(aux, out tryParseResult);
                switch (tryParseResult)
                {
                    case Opciones.Suma:
                        MostrarOpcionesOperacionNumerica(true);
                        ConsoleKeyInfo opcionSum1 = Console.ReadKey();
                        Console.WriteLine();
                        MostrarOpcionesOperacionNumerica(false);
                        ConsoleKeyInfo opcionSum2 = Console.ReadKey();
                        Console.WriteLine();
                        int resultadoSuma = iCalculadora.Suma((int)Char.GetNumericValue(opcionSum1.KeyChar), (int)Char.GetNumericValue(opcionSum2.KeyChar));
                        Console.Write("El resultado es " + resultadoSuma.ToString());
                        Console.WriteLine();
                        break;
                    case Opciones.Resta:
                        MostrarOpcionesOperacionNumerica(true);
                        ConsoleKeyInfo opcionResta1 = Console.ReadKey();
                        Console.WriteLine();
                        MostrarOpcionesOperacionNumerica(false);
                        ConsoleKeyInfo opcionResta2 = Console.ReadKey();
                        Console.WriteLine();
                        int resultadoResta = iCalculadora.Suma((int)Char.GetNumericValue(opcionResta1.KeyChar), (int)Char.GetNumericValue(opcionResta2.KeyChar));
                        Console.Write("El resultado es " + resultadoResta.ToString());
                        Console.WriteLine();
                        break;
                    case Opciones.Multiplicacion:
                        MostrarOpcionesOperacionNumerica(true);
                        ConsoleKeyInfo opcionMultiplicacion1 = Console.ReadKey();
                        Console.WriteLine();
                        MostrarOpcionesOperacionNumerica(false);
                        ConsoleKeyInfo opcionMultiplicacion2 = Console.ReadKey();
                        Console.WriteLine();
                        int resultadoMultiplicacion = iCalculadora.Suma((int)Char.GetNumericValue(opcionMultiplicacion1.KeyChar), (int)Char.GetNumericValue(opcionMultiplicacion2.KeyChar));
                        Console.Write("El resultado es " + resultadoMultiplicacion.ToString());
                        Console.WriteLine();
                        break;
                    case Opciones.Division:
                        MostrarOpcionesOperacionNumerica(true);
                        ConsoleKeyInfo opcionDivision1 = Console.ReadKey();
                        Console.WriteLine();
                        MostrarOpcionesOperacionNumerica(false);
                        ConsoleKeyInfo opcionDivision2 = Console.ReadKey();
                        Console.WriteLine();
                        int resultadoDivision = iCalculadora.Suma((int)Char.GetNumericValue(opcionDivision1.KeyChar), (int)Char.GetNumericValue(opcionDivision2.KeyChar));
                        Console.Write("El resultado es " + resultadoDivision.ToString());
                        Console.WriteLine();
                        break;
                    case Opciones.Salir:
                        exit = true;
                        break;
                }
            }
        }
    }
}

