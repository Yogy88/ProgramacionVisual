using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercisio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dados dos vectores A y B de 30 elementos enteros, generar un vector C que contenga la
            //suma de los elementos de A y B.

            int[] a = new int[30];


            Console.WriteLine("Ingrese los 30 numeros a almacenar del vector 'A'");

            for (int i = 0; i < 30; i++)
            {


                Console.WriteLine("Posicion " + i + " =");

                a[i] = Convert.ToInt32(Console.ReadLine());

            }

            int[] b = new int[30];


            Console.WriteLine("Ingrese los 30 numeros a almacenar del vector 'B'");

            for (int i = 0; i < 30; i++)
            {


                Console.WriteLine("Posicion " + i + " =");

                b[i] = Convert.ToInt32(Console.ReadLine());

            }

            int[] c = new int[30];

            for (int i = 0; i < 30; i++)
            {

                c[i] = a[i] + b[i];

                Console.WriteLine("La suma de los vectores en la posicion = " + i + "del vector 'C' es igual a = " + c[i]);


            }

        }
    }
}

