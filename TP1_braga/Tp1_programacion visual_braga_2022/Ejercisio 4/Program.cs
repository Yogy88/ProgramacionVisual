using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercisio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar el algoritmo que nos permita introducir 10 números por teclado y nos informe,
            //por cada uno, si es par o impar. Como información adicional, nos debe indicar el total de
            //números pares y el total de números impares

            int[] enteros = new int[10];
            int pares = 0;
            int impares = 0;


            Console.WriteLine("Ingrese los 10 numeros a almacenar");

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Posicion " + i + " =");

                enteros[i] = Convert.ToInt32(Console.ReadLine());




                if (enteros[i] % 2 == 0)
                {
                    Console.WriteLine("Numero par");
                    pares++;
                }
                else
                {
                    Console.WriteLine("Numero impar");
                    impares++;
                }


            }




            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("La posicion = " + i + " tiene el entero =" + enteros[i]);

            }

            Console.WriteLine("Hay " + pares + "numeros pares");
            Console.WriteLine("Hay " + impares + "numeros impares");

        }
    }
}

