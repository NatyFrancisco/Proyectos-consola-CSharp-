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

            // Leer 10 enteros, almacenarlos en un arreglo y determinar en que posición del arreglo esta el mayor numero primo leido

            int[] numero = new int[10];


            //largo al array de primos
            int contadorPrimos = 0;



            //entrada y comprobar numeros primos para el contador
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Introduce el numero " + (i + 1) + ":");
                numero[i] = int.Parse(Console.ReadLine());
                int contadorDivisor = 0;

                for (int j =1; j<= numero[i]; j++)
                {
                    if (numero[i] % j == 0)
                    {
                        contadorDivisor++;
                    }
                }

                if (contadorDivisor == 2)
                {
                    contadorPrimos++;
                }

            }


            int posicionPrimos = 0;

            int[] numerosPrimos = new int[contadorPrimos];

            //Determina los numeros primos. Va desde uno hasta el numero primo (Si el numero es de dos divisores es primo)

            for (int i=0; i<numero.Length; i++)
            {
                int contadorDivisor = 0;

                for (int j = 1; j <= numero[i]; j++)
                {
                    if (numero[i] % j == 0)
                    {
                        contadorDivisor++;
                    }
                }

                if (contadorDivisor == 2)
                {
                    //Almacena los numeros primos
                    numerosPrimos[posicionPrimos] = numero[i];
                    //Toma la posicion automaticamente
                    posicionPrimos++;
                }


            }


            int posicion = 0;
           int numeroPrimoMayor = 0;

            //Cual es el # primo mayor
            for (int i = 0; i < numerosPrimos.Length; i++)
            {

                if (numerosPrimos[i] > numeroPrimoMayor)
                {
                    numeroPrimoMayor = numerosPrimos[i];

                    posicion = i;

                    
                }
                
            }

            
            for (int i=0; i<numero.Length; i++)
            {

                //Recorre todos los numeros primos para asignar la posicion original del array
                if (numero[i] == numeroPrimoMayor)
                {
                    posicion = i;
                }
            }

            Console.WriteLine("El numero primo mayor esta en la posicion: " + posicion);
            Console.ReadLine();
        }
            
        
            






        }



}

   


















       
        




    
    

