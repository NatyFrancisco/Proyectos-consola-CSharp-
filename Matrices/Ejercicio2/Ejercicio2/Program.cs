using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //- Leer una matriz 3x4 entera y determinar en qué posiciones exactas se encuentran los números pares

            int[,] numero = new int[3, 4];

            //Mensaje que indica que hace el programa
            Console.WriteLine("Leer una matriz 3x4 entera y determinar en qué posiciones exactas se encuentran los números pares");
            Console.WriteLine();

            //Leer los numeros
            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 4; b++)
                {
                    Console.WriteLine("Introduce el numero de la fila " + (a + 1) + " columna " + (b + 1) + ":");
                    numero[a, b] = int.Parse(Console.ReadLine());
                }
            }

           
            
            //Mensajes de salida
            Console.WriteLine();
            Console.Write("Los numeros pares son: ");
            Console.WriteLine();
            Console.WriteLine();

            //Declaracion de variables
            int numFila = 0;
            int numColumna = 0;
            int numPares = 0;

            //Bucle para determinar los numeros pares 
            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 4; b++)
                {
                    if (numero[a, b] % 2 == 0)
                    {

                        numFila = a;
                        numFila++;
                        numColumna = b;
                        numColumna++;
                        numPares = numero[a, b];

                       
                        Console.WriteLine("Numero {0} --> Fila {1} y columna: {2}", numPares, numFila, numColumna);
                    }
                    else
                    {
                        Console.WriteLine("No hay numero par.");
                    }
                }
                Console.WriteLine();

            }

            Console.ReadLine();

           

        }
    }
}
