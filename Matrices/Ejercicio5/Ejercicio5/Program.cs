using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //- Leer una matriz 5x3 entera y determinar en qué columna está el mayor número que comienza con el dígito 4.

            Console.Clear();
            Console.WriteLine("Leer una matriz 5x3 entera y determinar en qué columna está el mayor número que comienza con el dígito 4.");
            Console.WriteLine("");

            int fils = 5;
            int cols = 3;
            int mayor = 0;
            string posicion = "ninguna";
            List<string[]> valores = new List<string[]>();

            for (int x = 1; x <= fils; x++)
            {
                Console.WriteLine("");
                Console.WriteLine("Ingrese la fila " + x);
           
                Console.Write("Digite los {0} valores separados por , (coma): ", cols);
                string opt = Console.ReadLine();
                valores.Add(opt.Split(','));
            }
            Console.WriteLine("");
            Console.WriteLine("La matriz que ingresaste es: ");
            Console.WriteLine("");

            for (int x = 0; x < valores.Count; x++)
            {
                string[] fila = valores[x];

                for (int y = 0; y < fila.Length; y++)
                {
                    int tmp = int.Parse(fila[y]);
                    char primero = fila[y][0];

                    if (tmp > mayor && primero == '4')
                    {
                        mayor = tmp;
                        posicion = "" + (y + 1);


                    }
                }
                Console.WriteLine(string.Join("\t", fila));
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("El mayor es {0} y esta en la columna {1} ", mayor, posicion);

            Console.ReadKey();
        }
    }
}
