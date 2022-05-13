using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algoritmosPlanificacion
{
    class Lista
    {
        public Nodo _primero = new Nodo();
        Nodo _ultimo = new Nodo();

        public Nodo primero()
        {
            return _primero;
        }

        public Nodo ultimo()
        {
            return _ultimo;
        }

        public Lista()
        {
            _primero = null;
            _ultimo = null;
        }
        /*
         Lista doble =
         
         NULL <- -> [Tarea 1 {1}{13}{4} ] <- -> [Tarea 2 {2}{21}{2} ] ---
         
         */
        public void InsertarNodo(Nodo unNodo)
        {
            //Nodo nuevo = new Nodo();

            //Console.Write("Id nodo: ");

            //este se leera des teclado
            //nuevo.Id = int.Parse(Console.ReadLine());

            //Lista vacia?
            if(_primero == null)
            {
                _primero = unNodo;

                _primero.Siguiente = null;
                _primero.Atras = null;

                _ultimo = _primero;
            }
            else
            {
                //ultimo de la lista -> nuevo elemento.
                _ultimo.Siguiente = unNodo;

                //actualizacion de siguiente del nuevo valor
                unNodo.Siguiente = null;
                unNodo.Atras = _ultimo;

                //Actualización de último
                _ultimo = unNodo;
            }

            //Console.Write("\n Nuevo nodo ingresado con exito");
        }

        /*
         * a considerar para
         * RECORRER LISTA 
        */
        public void desplegarListaDoble(Nodo unNodo)
        {
            //Nodo actual = new Nodo();

            unNodo = _primero;


            //imprime
            while(unNodo != null)
            {
                //Console.WriteLine(" "+ unNodo.Id);
                unNodo = unNodo.Siguiente;
            }            
        }

        public void desplegarListaInverso(Nodo unNodo)
        {
            //Nodo actual = new Nodo();
            unNodo = _ultimo;

            while(unNodo != null)
            {
                //Console.WriteLine(" " + unNodo.Id);
                unNodo = unNodo.Atras;
            }
        }

        //Encontrar un nodo dentro de la lista doble
        public void buscarNodoLista(Nodo unNodo, int id)
        {
            //Nodo actual = new Nodo();
            unNodo = _ultimo;

            bool encontrado = false;

            int idNodoBuscar = id;


            while (unNodo != null && encontrado == false)
            {
                if(unNodo.Id == idNodoBuscar)
                {
                    //Console.WriteLine("\n Nodo con el dato ({0}) encontrado \n" + actual.Id);
                    MessageBox.Show("El nodo ({0}) se ha encontrado" + unNodo.Id);
                }
                unNodo = unNodo.Atras;
            }
            if (!encontrado)
            {
                MessageBox.Show("El nodo no ha sido encontrado");
            }
        }
    }
}
