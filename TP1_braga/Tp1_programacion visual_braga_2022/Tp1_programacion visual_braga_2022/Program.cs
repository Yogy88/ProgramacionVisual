using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Tp1_Braga_Matias
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leer 20 números enteros positivos, indicar cuál es el mayor y en qué orden fue leído(a
            //que elemento pertenece).Mostrar el vector completo.

            int[] enteros = new int[20];
            int mayor = 0;
            int[] posicion = new int[20];
            int p = 0;
            Console.WriteLine("Ingrese los 20 numeros a almacenar");

            for (int i = 0; i < 20; i++)
            {

                //para ingresar las 20 posiciones

                Console.WriteLine("Posicion " + i + " =");

                enteros[i] = Convert.ToInt32(Console.ReadLine());

                //compara si es mayor


                if (mayor < enteros[i])
                {
                    mayor = enteros[i];
                    p++;

                    posicion[p] = i;



                    Console.WriteLine("hasta ahora el mayor!");

                }


            }



            Console.WriteLine("Vector Completo");
            for (int i = 0; i < 20; i++)
            {

                Console.WriteLine("La posicion " + i + " = " + enteros[i]);


            }



            Console.WriteLine("Mayor segun se ingreso uno mayor");
            for (int i = 0; i < 20; i++)
            {
                if (posicion[i] != 0)
                {
                    Console.WriteLine("La posicion " + posicion[i]);
                }

            }

            // muestra mayor

            Console.WriteLine("El mayor es = " + mayor);

            Console.ReadKey();
        }
    }
}

