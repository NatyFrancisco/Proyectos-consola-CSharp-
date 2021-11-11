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
            //Cargar un arreglo de 10 posiciones con los 10 primeros elementos de la serie de Fibonacci y mostrarlos en pantalla.

            int[]fibonacci = new  int[10];
            fibonacci[1] = 1;
            fibonacci[1] = 1;
            for(int  i = 2 ; i < 10; ++i )
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            Console.WriteLine(" Los primeros 10 elementos de la serie de Fibonacci son: ");
            for(int  i = 0 ; i < 10; ++i )
            {
                
                Console.WriteLine(fibonacci[i]++);
                
            }
            Console.ReadLine();
        }
    }
}
