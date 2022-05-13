using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmosPlanificacion
{
	public class Tareas
	{
		public int Id;
		public int Tamanio;
		public int Prioridad;

		public Tareas(int identificador, int tamanio, int prioridad)
		{
			this.Id = identificador;
			this.Tamanio = tamanio;
			this.Prioridad = prioridad;
		}

		public override string ToString()
		{
			return "[" + Id + "," + Tamanio + "," + Prioridad + "]";
		}

		public List<Tareas> OrdenarListaSRT(List<Tareas> lista)
        {
			List<Tareas> listaOrdenado = lista.OrderBy(x => x.Id).ToList();

			return listaOrdenado;
        }
	}
}
