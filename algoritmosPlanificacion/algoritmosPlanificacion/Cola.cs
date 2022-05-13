using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmosPlanificacion
{
    class Cola
    {
        Nodo _inicio; //<- variable interna


        //Inserta un elemento al final
        public void Encolar(Nodo unNodo)
        {
            //Si el inicio es nulo se agrega el primer elemento
            if(_inicio == null)
            {
                _inicio = unNodo;
            }
            else
            {
                Nodo aux = BuscarUltimo(_inicio);
                aux.Siguiente = unNodo;
            }
        }

        //recorrido
        private Nodo BuscarUltimo(Nodo unNodo)
        {
            if(unNodo.Siguiente == null)
            {
                return unNodo;
            }
            else
            {
                return BuscarUltimo(unNodo.Siguiente);
            }
        }


        //Saca el elemento del Inicio en la cola
        public void Desencolar()
        {
            _inicio = _inicio.Siguiente;
        }


        //Devuelve el Nodo de inicio <- Proceso Inicio
        public Nodo Inicio
        {
            get
            {
                return _inicio;
            }
        }

        public bool Vacia()
        {
            return (_inicio == null);
        }
    }
}
