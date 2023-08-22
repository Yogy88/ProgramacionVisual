using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercisio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar el algoritmo que nos permita introducir 10 números por teclado y nos informe,
            //por cada uno, si es positivo o negativo.

            int[] enteros = new int[10];

            Console.WriteLine("Ingrese los 10 numeros a almacenar");

            for (int i = 0; i < 20; i++)
            {



                Console.WriteLine("Posicion " + i + " =");

                enteros[i] = Convert.ToInt32(Console.ReadLine());




                if (enteros[i] > 0)
                {
                    Console.WriteLine("Numero positivo");
                }

                if (enteros[i] < 0)
                {
                    Console.WriteLine("Numero negativo");
                }


            }




            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("La posicion = " + i + " tiene el entero =" + enteros[i]);

            }
        }
    }
}
