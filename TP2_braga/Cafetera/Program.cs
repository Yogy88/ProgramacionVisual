using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Utilizando Visual Studio como IDE, generar una Solución con un proyecto del tipo Consola y
//realizar los siguientes ejercicios:

//1. Desarrolla una clase Cafetera con atributos CapacidadMaxima(la cantidad máxima de café que
//puede contener la cafetera) y CantidadActual(la cantidad actual de café que hay en la cafetera
//para consumo). Implementa, al menos, los siguientes métodos:
//a) Constructor predeterminado: establece la capacidad máxima en 1000 (c.c.) y la actual en
//cero(cafetera vacía).
//b) LlenarCafetera() : hace que la cantidad actual sea igual a la capacidad e informa por pantalla
//la cantidad de café disponible para consumo.
//c) ServirTaza(int) : simula la acción de servir una taza(100 cc), muestra por pantalla “Café
//servido” y la cantidad de café disponible para consumo.
//d) VaciarCafetera() : pone la cantidad de café actual en cero e informa por pantalla “Sin café,
// por favor rellenar”
namespace TP2_braga
{
    class Program
    {
        static void Main(string[] args)
        {

            Cafetera Bonafide = new Cafetera();

            Console.WriteLine("Bienvenido a la cafeteria");


            Bonafide.LlenarCafetera();

            Bonafide.ServirTaza();

            Bonafide.VaciarCafetera();

            Bonafide.ServirTaza();

            Console.ReadKey();
        }
    }

}