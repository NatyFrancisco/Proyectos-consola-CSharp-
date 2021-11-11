using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //- Leer una matriz 4x3 entera, calcular la suma de los elementos de cada fila y determinar cuál es la fila que tiene la mayor suma.

            int[,] numeros = new int[4, 3];

            //Lee los numeros
            for (int i =0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Introduce el numero de la fila " + (i + 1) + " columna " + (j + 1) + ":");
                    numeros[i, j] = int.Parse(Console.ReadLine());

                }
            }

            //Calcular la suma de cada fila

            int[] sumaFilas = new int[4];

            for (int i=0; i<4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sumaFilas[i] = sumaFilas[i] + numeros[i, j];
                    
                }
                Console.WriteLine("");
            }

            //Imprime la matriz

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(numeros[i, j] + "");
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }

            //Determina la suma mayor
            int sumaMayor = 0;
            int posicionMayor = 0;
            for (int i =0; i<sumaFilas.Length; i++)
            {
                if (sumaFilas[i] > sumaMayor)
                {
                   sumaMayor = sumaFilas[i];
                    posicionMayor = i;
                }
            }

            Console.WriteLine("La fila con la mayor suma es la numero " + (posicionMayor + 1));
            Console.ReadLine();
        }
    }
}
