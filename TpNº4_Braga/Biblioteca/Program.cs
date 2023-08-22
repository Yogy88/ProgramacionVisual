using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
1. Crea una clase Libro que modele la información que se mantiene en una biblioteca sobre cada
libro: título, autor(crear la clase Autor), ISBN, páginas, edición, editorial, lugar(ciudad y país) y
fecha de edición.
a) Se deberá realizar un formulario(con los controles necesarios) que permita el ingreso de los
datos del objeto.
b) Se deberán aplicar validaciones sobre los datos ingresados,
a. Ningún campo puede ser vacío
b.El campo “Cantidad de Páginas” debe ser numérico
c. La fecha de edición Debe ser menor a la fecha actual
c) Por cada libro ingresado se debe insertar el registro en una base de datos sobre la tabla 
“Libro” la cual debe tener:
a.ID Primary Key
b.Los mismos campos mencionados en el ejercicio respedanto sus tipos de datos
d) Por cada libro ingresado se debe actualizar una grilla donde esta muestre la información de
cada libro con las siguientes columnas:
 Título
Edición
Autor
ISBN
Cantidad de Páginas
Edición
Editorial
Ciudad y País
Fecha de Edición
Importante: cada vez que se agrega un nuevo libro, los controles deben volver a su estado original para
permitir, de una manera sencilla para el usuario, la carga de nuevos datos.
e) Al seleccionar un libro del listado se puede:
a.Eliminar: se debe eliminar el registro de la base
b.Actualizar: se deberán actualizar los datos del libro en todos sus campos
*/

namespace Biblioteca
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CargaLibros());
        }
    }
}
