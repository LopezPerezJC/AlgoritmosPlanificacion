using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmosPlanificacion
{
    class Nodo
    {
        public int Id { get; set; }
        public int Tamanio { get; set; }
        public int Prioridad { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo Atras { get; set; }
    }
}
