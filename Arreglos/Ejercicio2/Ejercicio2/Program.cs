using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leer 10 números enteros, almacenarlos en un arreglo y determinar si el promedio entero de dichos números es un número primo.


            int[] enteros = new int[10];
            int promedio = 0;
            int contadorDivisor = 0;

            for (int i = 0; i < enteros.Length; i++)
            {
                Console.WriteLine("Introduce el numero " + (i + 1) + ":");
                enteros[i] = int.Parse(Console.ReadLine());

                promedio = promedio + enteros[i];
            }

            promedio = promedio / enteros.Length;

            for (int i = 1; i <= promedio; i++)
            {

                if (promedio % i == 0)
                {
                    contadorDivisor++;
                }
            }
                if (contadorDivisor ==2)
                {

                    Console.WriteLine("El promedio es " + promedio + " y  es primo.");
                    Console.ReadLine();
                }


                else
                {
                    Console.WriteLine("El promedio es " + promedio + " y  no es primo.");
                    Console.ReadLine();
                }





            
            }
            }

        
}
