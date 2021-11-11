using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leer una matriz 4x4 entera y determinar en qué posiciones están los enteros terminados en 0

            int[,] numero = new int[4, 4];


            //Mensaje que indica que hace el programa
            Console.WriteLine("Leer una matriz 4x4 entera y determinar en qué posiciones están los enteros terminados en 0");
            Console.WriteLine();

            //Leer los numeros
            for (int a = 0; a < 4; a++)
            {
                for (int b = 0; b < 4; b++)
                {
                    Console.WriteLine("Introduce el numero de la fila " + (a + 1) + " columna " + (b + 1) + ":");
                    numero[a, b] = int.Parse(Console.ReadLine());
                }
            }


            //Mensajes de salida
            Console.WriteLine();
            Console.Write("Los numeros que terminan en cero son: ");
            Console.WriteLine();
            Console.WriteLine();

            //Declaracion de variables
            int numFila = 0;
            int numColumna = 0;
            int numCero = 0;

            //Bucle para determinar los numeros que terminan en cero
            
          
            for (int a = 0; a < 4; a++)
            {
                for (int b = 0; b < 4; b++)
                {
                    if (numero[a, b] % 2==0 && numero[a,b] % 5 ==0)
                    {
                        numFila = a;
                        numFila++;
                        numColumna = b;
                        numColumna++;
                        numCero = numero[a, b];


                        Console.WriteLine("Numero {0} --> Fila {1} y columna: {2}", numCero, numFila, numColumna);
                    }
                    else
                    {
                        Console.WriteLine("Este numero no termina en 0.");
                    }
                }
                Console.WriteLine();

            }

            Console.ReadLine();

        }
    }
}
