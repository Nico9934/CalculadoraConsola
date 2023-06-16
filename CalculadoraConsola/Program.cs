using System;

namespace CalculadoraConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = "";
          
            while (opcion != "S")
            {
                Console.Clear();

                // Funcion para imprimir la calculadora
                imprimirMenu();
                
                opcion = leerOpcion(opcion);


                if (opcion != "S" && (opcion == "A") || (opcion == "B") || (opcion == "C") || (opcion == "D"))
                {
                    Console.WriteLine("\nIngrese primer valor:");
                    float valor1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nIngrese segundo valor:");
                    float valor2 = Convert.ToInt32(Console.ReadLine());

                    calcular(opcion, valor1, valor2);
                    Console.WriteLine("\nPresione una tecla para realizar otra operación");
                    Console.ReadKey();
                }
                else if (opcion == "S")
                {   
                    Console.WriteLine("\nGracias por utilizar la calculadora");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\nValor incorrecto. Presione ENTER para volver al menu");
                    Console.ReadKey();
                }
            }
            Console.ReadKey();
        }


        static void imprimirMenu()
        {
            Console.WriteLine("Calculadora Basica...\n");
            Console.WriteLine("Operaciones posibles:\n");
            Console.WriteLine("\tA - Sumar\n\tB - Restar\n\tC - Multiplicar\n\tD - Dividir\n\tS - Salir\n");
        }
        static string leerOpcion(string opcion)
        {
            Console.Write("Opción: ");
            opcion = Console.ReadLine().ToUpper();
            return opcion;
        }

        static void calcular(string opcion, float valor1, float valor2)
        {
            string operacion = "";
            float resultado = 0; 

            if (opcion == "A")
            {
                operacion = "sumar ";
                resultado = suma(valor1, valor2);
                Console.WriteLine("El resultado de " + operacion + "los valores es:" + resultado);
            }
            else if (opcion == "B")
            {
                operacion = "restar ";
                resultado = resta(valor1, valor2);
                Console.WriteLine("El resultado de " + operacion + "los valores es:" + resultado);
            }
            else if (opcion == "C")
            {
                operacion = "multiplicar ";
                resultado = multiplicar(valor1, valor2);
                Console.WriteLine("El resultado de " + operacion + "los valores es:" + resultado);
            }
            else if (opcion == "D")
            {
                operacion = "dividir ";
                resultado = dividir(valor1, valor2);
                Console.WriteLine("El resultado de " + operacion + "los valores es:" + resultado);
            }
        }
        static float suma(float valor1, float valor2)
        {
            return (valor1 + valor2);
        }
        static float resta(float valor1, float valor2)
        { 
            return (valor1 - valor2);
        }
        static float multiplicar(float valor1, float valor2)
        { 
            return (valor1 + valor2);
        }
        static float dividir(float valor1, float valor2)
        { 
            return (valor1 / valor2);
        } 
    }
}
