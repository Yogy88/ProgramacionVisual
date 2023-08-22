using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_braga
{
    class Cafetera
    {
        int contenido;
        int capacidadmaxima;


        public Cafetera() //Constructor predeterminado: establece la capacidad máxima en 1000 (c.c.) y la actual en cero(cafetera vacía).
        {
            contenido = 0;
            capacidadmaxima = 1000;

        }

        public void LlenarCafetera() //LlenarCafetera() : hace que la cantidad actual sea igual a la capacidad e informa por pantalla la cantidad de café disponible para consumo
        {
            contenido = capacidadmaxima;
            Console.WriteLine(" La cantidad disponible para consumo es de " + contenido + " cc.");


        }

        public int ServirTaza() // ServirTaza(int) : simula la acción de servir una taza(100 cc), muestra por pantalla “Café servido” y la cantidad de café disponible para consumo.
        {
            if (contenido != 0)
            {
                contenido = contenido - 100;
                Console.WriteLine("Cafe Servido");
                Console.WriteLine("Cafe restante para consumo = " + contenido + " cc");

            }
            else
            {
                Console.WriteLine("No hay mas cafe, la taza no fue servida");
                Console.WriteLine("Debe llenar la cafetera para poder servir la taza nuevamente");

            }

            return contenido;
        }

        public void VaciarCafetera() // VaciarCafetera() : pone la cantidad de café actual en cero e informa por pantalla “Sin café, por favor rellenar”
        {

            contenido = 0;
            Console.WriteLine("Sin cafe, por favor rellenar");

        }
    }
}
