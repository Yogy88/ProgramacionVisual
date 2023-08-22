using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Libro
    {

        public String Título { get; set; }

        public String Autor { get; set; }

        public int ISBN { get; set; }

        public int Cantidad_de_Páginas { get; set; }

        public int Edicion { get; set; }

        public String Editorial { get; set; }

        public String Lugar { get; set; }

        public DateTime FechaEdicion { get; set; }

    }
}
