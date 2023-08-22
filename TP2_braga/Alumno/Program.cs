using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
Utilizando Visual Studio como IDE, generar una Solución con un proyecto del tipo Winform y realizar los  siguientes ejercicios: 
1.Crea una clase Alumno que modele la información que se mantiene en una institución  educativa.  
Sobre cada alumno se deberá tener en cuenta las siguientes propiedades:  
Nombre, Apellido, DNI, Legajo, Carrera, Año de Inscripción.  
a) Se deberá realizar un formulario (con los controles necesarios) que permita el ingreso de los  datos del objeto, este se agregue a un arrayList. 
b) Por cada alumno ingresado el sistema deberá realizar las siguientes acciones: 
1.Cada control debe volver a su estado original para permitir la carga de nuevos datos.
2. Almacenar cada alumno creado en un listado de alumnos 
3. Actualizar un control Label que informe la cantidad de alumnos ingresados.
*/

namespace Alumno
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
            Application.Run(new CargaAlumnos());

            


        }
    }
}
