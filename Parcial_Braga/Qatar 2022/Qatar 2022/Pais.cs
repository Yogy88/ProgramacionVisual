using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Es necesario de cada selección guardar los siguientes datos:
• País que representa
• Continente al que pertenece
• Ranking actual de la FIFA
• Cantidad de habitantes
• Si gano o no gano mundiales hasta la actualidad. En caso de marcar si, se debe habilitar un
combo para seleccionar cuantos gano.
• Si es su primer participación o no
*/
namespace Qatar_2022
{
    class Pais
    {

        public String Nombre { get; set; }
        public String Continente { get; set; }
        public int Ranquing { get; set; }
        public int habitantes { get; set; }
        public String Ganador { get; set; }
        public String Participaciones { get; set; }

        
    }
}
