using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            //-Leer una matriz 4x4 de tipo entero y determinar en qué fila y en qué columna se encuentra el número mayor.

            int[,] numero = new int[4, 4];

            //Leer los numeros
            for (int a = 0; a < 4; a++)
            {
                for (int b = 0; b < 4; b++)
                {
                    Console.WriteLine("Introduce el numero de la fila " + (a + 1) + " columna " + (b + 1) + ":");
                    numero[a, b] = int.Parse(Console.ReadLine());
                }
            }

            //Determina el numero mayor
           
            int numMayor = 0;
            int mayorMatriz = numero[0, 0];
            for (int a = 0; a < 4; a++)
            {
                for (int b = 0; b < 4; b++)
                {
                    if (numero[a, b] > numMayor)
                    {

                        mayorMatriz = numero[a, b];
                        numMayor = mayorMatriz;

                    }
                }

               
            }

            //Determina numero mayor de la fila y de la columna
            int mayorFila = 0;
            int mayorColumna = 0;
            for (int a = 0; a < 4; a++)
            {
                for (int b = 0; b < 4; b++)
                {

                    if (numero[a, b] == mayorMatriz)
                    {
                        mayorFila = a;
                        mayorFila++;
                        mayorColumna = b;
                        mayorColumna++;
                    }


                } 
            }

            Console.WriteLine("El numero mayor esta en la fila " + mayorFila + " y en la columna " + mayorColumna);
            Console.ReadLine();

           

        }
    }
}
