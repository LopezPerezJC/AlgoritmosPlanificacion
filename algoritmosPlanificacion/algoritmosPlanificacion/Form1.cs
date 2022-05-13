using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algoritmosPlanificacion
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// LISTAS A USAR
        /// </summary>
        //Cola
        Cola miCola = new Cola();

        //Pila <- ESTE NO SE USARÁ
        Pila _miPila = new Pila();

        //Lista doblemente enlazada
        Lista _ListaTareas = new Lista();

        //Listas para cada algoritmo de planificación
        Lista _listaFCFS = new Lista();
        Lista _listaSRT = new Lista();
        Lista _lista2SRT = new Lista();
        Lista _listaRR = new Lista();
        Lista _listaPrioridad = new Lista();

        //FCFS
        int POS1 = 0, POS2 = 0;

        //SRT
        int POS1SRT = 0;
        List<Tareas> listaTareasSRT = new List<Tareas>() { };
        List<Tareas> listaTareasSRTOrdenados = new List<Tareas>() { };

        //RR
        int POS1RR = 0;
        List<Tareas> listaTareasRR = new List<Tareas>() { };
        List<Tareas> listaTareasRROrdenados = new List<Tareas>() { };

        //P
        int POS1P = 0;
        List<Tareas> listaTareasP= new List<Tareas>() { };
        List<Tareas> listaTareasPOrdenados = new List<Tareas>() { };

        //Contadores
        int contadorAUX = 0;
        int numeroColor = 1;

        //Constantes
        const int tamanioCuadros = 20;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //ENCOLAR   
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Length == 0 || txtTamanio.Text.Length == 0 || txtPrioridad.Text.Length == 0)
            {
                MessageBox.Show("Los campos no pueden ir vacíos");
            }
            else
            {
                Nodo unNodoNuevo = new Nodo();

                //Convertir a entero antes de asignar
                int id = Convert.ToInt32(txtId.Text);
                int tamanio = Convert.ToInt32(txtTamanio.Text);
                int prioridad = Convert.ToInt32(txtPrioridad.Text);

                unNodoNuevo.Id = id;
                unNodoNuevo.Tamanio = tamanio;
                unNodoNuevo.Prioridad = prioridad;

                miCola.Encolar(unNodoNuevo);
                contadorAUX += 1;

                txtNumeroTareas.Text = contadorAUX.ToString();

                MostrarCola();

                txtId.Text = "";
                txtTamanio.Text = "";
                txtPrioridad.Text = "";
            }
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            if (miCola.Vacia())
            {
                MessageBox.Show("La cola esta vacía");
            }
            else
            {
                miCola.Desencolar();
                MostrarCola();
            }
        }

        private void MostrarCola()
        {
            lstIdTarea.Items.Clear();
            lstTamanioTarea.Items.Clear();
            lstPrioridadTarea.Items.Clear();

            MostrarNodoEnPantalla(miCola.Inicio);
        }

        private void MostrarNodoEnPantalla(Nodo unNodo)
        {
            if (unNodo != null)
            {
                lstIdTarea.Items.Add(unNodo.Id);
                lstTamanioTarea.Items.Add(unNodo.Tamanio);
                lstPrioridadTarea.Items.Add(unNodo.Prioridad);

                if (unNodo.Siguiente != null)
                {
                    //Recorrido recursivo
                    MostrarNodoEnPantalla(unNodo.Siguiente);
                }
            }
        }

        //LISTA
        private void btnAgregarTareaLista_Click(object sender, EventArgs e)
        {
            Nodo UnNuevoNodo = new Nodo();

            //Convertir a entero antes de asignar
            int id = Convert.ToInt32(txtId.Text);
            int tamanio = Convert.ToInt32(txtTamanio.Text);
            int prioridad = Convert.ToInt32(txtPrioridad.Text);

            UnNuevoNodo.Id = id;
            UnNuevoNodo.Tamanio = tamanio;
            UnNuevoNodo.Prioridad = prioridad;

            //agregar tarea a la lista
            _ListaTareas.InsertarNodo(UnNuevoNodo);

            //_ListaTareas.desplegarListaDoble(UnNuevoNodo);

            mostrarLista();
        }

        void mostrarLista()
        {
            listBoxLista.Items.Clear();

            if(_ListaTareas != null)
            {
                mostrarTareasLista(_ListaTareas.primero());
            }
        }
        //mostrartareasfuncionOtro
        void mostrarTareasLista(Nodo unNodo)
        {
            listBoxLista.Items.Add(unNodo.Id);
            listBoxLista.Items.Add(unNodo.Tamanio);
            listBoxLista.Items.Add(unNodo.Prioridad);

            if (unNodo.Siguiente != null)
            {   //llamar recursivamente mientras no este vacía
                mostrarTareasLista(unNodo.Siguiente);
            }
        }

        //Iniciar procesos
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            /// Iniciar el proceso de copia
            copiarCola(miCola.Inicio);

            /// Algoritmo SRT
            copiarColaListaSRT(miCola.Inicio);

            /// Algoritmo RR
            copiarColaListaRR(miCola.Inicio);

            /// Algoritmo P
            copiarColaListaP(miCola.Inicio);

        }


        //***********************************************************************************************
        //***********************************************************************************************

        //*************
        // ALGORITMO 1
        //*************
        private void copiarCola(Nodo unNodo)
        {
            Nodo unaTareaNueva = new Nodo();

            if (unNodo != null)
            {
                while (unNodo != null)
                {
                    int idTem = unNodo.Id;
                    int tamanioTem = unNodo.Tamanio;
                    int prioridadTem = unNodo.Prioridad;

                    unaTareaNueva.Id = idTem;
                    unaTareaNueva.Tamanio = tamanioTem;
                    unaTareaNueva.Prioridad = prioridadTem;

                    _listaFCFS.InsertarNodo(unaTareaNueva);

                    //mostrarTareasCopiadas a lista
                    mostrarTareasListaNuevo();

                    //actualizar despues de haber llamado a la funcion de pintar, por que si no, esta apuntando a un objeto nulo
                    unNodo = unNodo.Siguiente;

                    pintarTareasListaFCFS();
                }
            }
            else
            {
                MessageBox.Show("No hay nada que copiar");
            }
        }

        void mostrarTareasListaNuevo()
        {
            if (_listaFCFS != null)
            {
                mostrarTareasCopiadasLista(_listaFCFS.primero());

            }
        }

        int contadorUniversal = 0;
        void mostrarTareasCopiadasLista(Nodo unNodo)
        {
            listaTareasCopiadas.Items.Add(unNodo.Id);
            listaTareasCopiadas.Items.Add(unNodo.Tamanio);
            listaTareasCopiadas.Items.Add(unNodo.Prioridad);

            if (unNodo.Siguiente != null)
            {
                unNodo = unNodo.Siguiente;
                mostrarTareasCopiadasLista(unNodo);
                contadorUniversal += 1;
            }
        }

        void pintarTareasListaFCFS()
        {
            if (_listaFCFS != null)
            {
                pintarCuadros(_listaFCFS.primero());
            }
        }

        void pintarCuadros(Nodo unNodo)
        {
            if (unNodo != null)
            {
                int contadorProcesos = 0, tamanioTarea = unNodo.Tamanio;

                while (contadorProcesos < tamanioTarea)
                {
                    dibujoDiagramas(POS1, POS2);

                    if (tamanioTarea == 1)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Green);
                        rellenarCuadroDiagrama(POS1, POS2, brocha);
                    }
                    if (tamanioTarea == 2)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Orange);
                        rellenarCuadroDiagrama(POS1, POS2, brocha);
                    }
                    if (tamanioTarea == 3)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Red);
                        rellenarCuadroDiagrama(POS1, POS2, brocha);
                    }
                    if (tamanioTarea == 4)
                    {
                        SolidBrush brocha = new SolidBrush(Color.DarkMagenta);
                        rellenarCuadroDiagrama(POS1, POS2, brocha);
                    }
                    if (tamanioTarea == 5)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Yellow);
                        rellenarCuadroDiagrama(POS1, POS2, brocha);
                    }
                    if (tamanioTarea == 6)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Pink);
                        rellenarCuadroDiagrama(POS1, POS2, brocha);
                    }
                    if (tamanioTarea == 7)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Violet);
                        rellenarCuadroDiagrama(POS1, POS2, brocha);
                    }
                    if (tamanioTarea == 8)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Blue);
                        rellenarCuadroDiagrama(POS1, POS2, brocha);
                    }
                    if (tamanioTarea == 9)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Brown);
                        rellenarCuadroDiagrama(POS1, POS2, brocha);
                    }
                    if (tamanioTarea == 10)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Aquamarine);
                        rellenarCuadroDiagrama(POS1, POS2, brocha);
                    }
                    if (tamanioTarea == 11)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Gray);
                        rellenarCuadroDiagrama(POS1, POS2, brocha);
                    }

                    numeroColor += 1;

                    //actualizacion del valor de dezplazamiento en x
                    POS1 += tamanioCuadros;

                    //lo que me hizo la vida de cuadritos por un dia fue el no haber actualizado el valod el contador de procresos lol v:
                    contadorProcesos += 1;
                }

                unNodo = unNodo.Siguiente;
                pintarCuadros(unNodo);
            }
        }

        SolidBrush brocha = new SolidBrush(Color.Green);


        /// DIBUJO DE CUADROS
        public void dibujoDiagramas(int posicion1, int posicion2)
        {
            //Inicializacion  de instumentos
            Graphics papel;
            papel = pictureBox1.CreateGraphics();

            Pen miLápiz = new Pen(Color.Purple);
            SolidBrush brocha = new SolidBrush(Color.Red);

            /// -1 valor de pos 1 para que se pueda ver el borde de cada cuadro
            int Pos1 = posicion1 - 1, Pos2 = posicion2 - 1, alto = tamanioCuadros, ancho = tamanioCuadros;

            Dibujar(papel, miLápiz, Pos1, Pos2, alto, ancho);

        }
        public void Dibujar
        (
            Graphics AreaDibujo,
            Pen lapizUsar,
            int posicion1,
            int posicion2,
            int alto,
            int ancho
        )
        {
            ///Orden parámetros -> instrumento, posición, tamanio.
            AreaDibujo.DrawRectangle(lapizUsar, posicion1, posicion2, alto, ancho);
        }


        /// RELLENO DE CUADROS
        public void rellenarCuadroDiagrama(int posicion1, int posicion2, SolidBrush colorCuadro)
        {
            ///Inicializacion  de instumentos
            Graphics papel;
            papel = pictureBox1.CreateGraphics();

            int Pos1 = posicion1, Pos2 = posicion2, alto = tamanioCuadros, ancho = tamanioCuadros;

            Rellenar(papel, colorCuadro, Pos1, Pos2, alto, ancho);
        }
        public void Rellenar
        (
            Graphics AreaDibujo,
            SolidBrush brocha,
            int posicion1,
            int posicion2,
            int alto,
            int ancho
        )
        {
            AreaDibujo.FillRectangle(brocha, posicion1, posicion2, alto, ancho);
        }

        //***********************************************************************************************
        //***********************************************************************************************

        //*************
        // ALGORITMO 2
        //*************
        private void copiarColaListaSRT(Nodo unNodo)
        {
            Nodo unaTareaNueva = new Nodo();

            if (unNodo != null)
            {
                while (unNodo != null)
                {
                    int idTem = unNodo.Id;
                    int tamanioTem = unNodo.Tamanio;
                    int prioridadTem = unNodo.Prioridad;

                    unaTareaNueva.Id = idTem;
                    unaTareaNueva.Tamanio = tamanioTem;
                    unaTareaNueva.Prioridad = prioridadTem;


                    Tareas nuevaTarea = new Tareas(idTem, tamanioTem, prioridadTem);

                    _listaSRT.InsertarNodo(unaTareaNueva);
                    listaTareasSRT.Add(nuevaTarea);
                    
                    unNodo = unNodo.Siguiente;
                }

                ReordenaListaSTR();
            }
            else
            {
                MessageBox.Show("No hay nada que copiar");
            }
        }


        //Reordenar aqui la lista nueva
        private void ReordenaListaSTR()
        {
            //Ordenando
            listaTareasSRTOrdenados.Clear();
            listaTareasSRTOrdenados = listaTareasSRT.OrderBy(tarea => tarea.Tamanio).ToList();
            
            //Añadir nueva lista al listbox
            for (int i = 0; i < listaTareasSRTOrdenados.Count; i++){
                listBox1.Items.Add(listaTareasSRTOrdenados[i]);
            }

            pintarTareasListaSRT();
            mostrarTareasListaNuevo();
        }

        void pintarTareasListaSRT()
        {
            //el problema no estaba en este foreach estaba en que
            //no se necesitaba un while de más, pues el foreach recorre por si mismo
            // de acuerdo al numero de elementos
            //MessageBox.Show("estamos adentro :)" + "ciclo " + contadorNumeroTareas);
            foreach (Tareas tarea in listaTareasSRTOrdenados)
            {
                //MessageBox.Show("estamos adentro :)");
                pintarCuadrosSRT(tarea);
            }
        }

        // PINTAR CUADROS ALGORITMO 2
        void pintarCuadrosSRT(Tareas tareaOrdenada)
        {       
            int contadorProcesos = 0, tamanioTarea = tareaOrdenada.Tamanio;

            //MessageBox.Show("Tamanio tarea " + tamanioTarea);

                while (contadorProcesos < tamanioTarea)
                {
                    dibujoDiagramasSRT(POS1SRT, POS2);

                    if (tamanioTarea == 1)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Green);
                        rellenarCuadroDiagramaSRT(POS1SRT, POS2, brocha);
                    }
                    if (tamanioTarea == 2)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Orange);
                        rellenarCuadroDiagramaSRT(POS1SRT, POS2, brocha);
                    }
                    if (tamanioTarea == 3)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Red);
                        rellenarCuadroDiagramaSRT(POS1SRT, POS2, brocha);
                    }
                    if (tamanioTarea == 4)
                    {
                        SolidBrush brocha = new SolidBrush(Color.DarkMagenta);
                        rellenarCuadroDiagramaSRT(POS1SRT, POS2, brocha);
                    }
                    if (tamanioTarea == 5)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Yellow);
                        rellenarCuadroDiagramaSRT(POS1SRT, POS2, brocha);
                    }
                    if (tamanioTarea == 6)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Pink);
                        rellenarCuadroDiagramaSRT(POS1SRT, POS2, brocha);
                    }
                    if (tamanioTarea == 7)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Violet);
                        rellenarCuadroDiagramaSRT(POS1SRT, POS2, brocha);
                    }
                    if (tamanioTarea == 8)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Blue);
                        rellenarCuadroDiagramaSRT(POS1SRT, POS2, brocha);
                    }
                    if (tamanioTarea == 9)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Brown);
                        rellenarCuadroDiagramaSRT(POS1SRT, POS2, brocha);
                    }
                    if (tamanioTarea == 10)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Aquamarine);
                        rellenarCuadroDiagramaSRT(POS1SRT, POS2, brocha);
                    }
                    if (tamanioTarea == 11)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Gray);
                        rellenarCuadroDiagramaSRT(POS1SRT, POS2, brocha);
                    }

                    POS1SRT += tamanioCuadros;

                    contadorProcesos += 1;
                }
        }


        // SEGUNDO ALGORITMO
        public void dibujoDiagramasSRT(int posicion1, int posicion2)
        {
            //Inicializacion  de instumentos
            Graphics papel;
            papel = pictureBox2.CreateGraphics();

            Pen miLápiz = new Pen(Color.Black);
            SolidBrush brocha = new SolidBrush(Color.Red);

            /// -1 valor de pos 1 para que se pueda ver el borde de cada cuadro
            int Pos1 = posicion1 - 1, Pos2 = posicion2 - 1, alto = tamanioCuadros, ancho = tamanioCuadros;

            Dibujar(papel, miLápiz, Pos1, Pos2, alto, ancho);
        }

        /// RELLENO DE CUADROS
        public void rellenarCuadroDiagramasSRT(int posicion1, int posicion2, SolidBrush colorCuadro)
        {
            ///Inicializacion  de instumentos
            Graphics papel;
            papel = pictureBox2.CreateGraphics();

            int Pos1 = posicion1, Pos2 = posicion2, alto = tamanioCuadros, ancho = tamanioCuadros;

            Rellenar(papel, colorCuadro, Pos1, Pos2, alto, ancho);
        }
        //ocupar el relleno del algoritmo 1

        public void rellenarCuadroDiagramaSRT(int posicion1, int posicion2, SolidBrush colorCuadro)
        {
            ///Inicializacion  de instumentos
            Graphics papel;
            papel = pictureBox2.CreateGraphics();

            int Pos1 = posicion1, Pos2 = posicion2, alto = tamanioCuadros, ancho = tamanioCuadros;

            Rellenar(papel, colorCuadro, Pos1, Pos2, alto, ancho);
        }

        //***********************************************************************************************
        //***********************************************************************************************

        //*************
        // ALGORITMO 3
        //*************
        private void copiarColaListaRR(Nodo unNodo)
        {
            Nodo unaTareaNueva = new Nodo();

            if (unNodo != null)
            {
                while (unNodo != null)
                {
                    int idTem = unNodo.Id;
                    int tamanioTem = unNodo.Tamanio;
                    int prioridadTem = unNodo.Prioridad;

                    unaTareaNueva.Id = idTem;
                    unaTareaNueva.Tamanio = tamanioTem;
                    unaTareaNueva.Prioridad = prioridadTem;

                    _listaRR.InsertarNodo(unaTareaNueva);


                    //actualizar despues de haber llamado a la funcion de pintar, por que si no, esta apuntando a un objeto nulo
                    unNodo = unNodo.Siguiente;

                    pintarTareasListaRR();
                }
            }
            else
            {
                MessageBox.Show("No hay nada que copiar");
            }
        }

        void pintarTareasListaRR()
        {
            if (_listaRR != null)
            {
                pintarCuadrosRR(_listaRR.primero());
            }
        }


        // PINTAR CUADROS ALGORITMO 3
        void pintarCuadrosRR(Nodo unNodo)
        {
            if (unNodo != null)
            {
                int contadorProcesos = 0, tamanioTarea = unNodo.Tamanio;

                while (contadorProcesos < tamanioTarea)
                {
                    dibujoDiagramasRR(POS1RR, POS2);

                    if (tamanioTarea == 1)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Green);
                        rellenarCuadroDiagramasRR(POS1RR, POS2, brocha);
                    }
                    if (tamanioTarea == 2)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Orange);
                        rellenarCuadroDiagramasRR(POS1RR, POS2, brocha);
                    }
                    if (tamanioTarea == 3)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Red);
                        rellenarCuadroDiagramasRR(POS1RR, POS2, brocha);
                    }
                    if (tamanioTarea == 4)
                    {
                        SolidBrush brocha = new SolidBrush(Color.DarkMagenta);
                        rellenarCuadroDiagramasRR(POS1RR, POS2, brocha);
                    }
                    if (tamanioTarea == 5)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Yellow);
                        rellenarCuadroDiagramasRR(POS1RR, POS2, brocha);
                    }
                    if (tamanioTarea == 6)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Pink);
                        rellenarCuadroDiagramasRR(POS1RR, POS2, brocha);
                    }
                    if (tamanioTarea == 7)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Violet);
                        rellenarCuadroDiagramasRR(POS1RR, POS2, brocha);
                    }
                    if (tamanioTarea == 8)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Blue);
                        rellenarCuadroDiagramasRR(POS1RR, POS2, brocha);
                    }
                    if (tamanioTarea == 9)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Brown);
                        rellenarCuadroDiagramasRR(POS1RR, POS2, brocha);
                    }
                    if (tamanioTarea == 10)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Aquamarine);
                        rellenarCuadroDiagramasRR(POS1RR, POS2, brocha);
                    }
                    if (tamanioTarea == 11)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Gray);
                        rellenarCuadroDiagramasRR(POS1RR, POS2, brocha);
                    }

                    numeroColor += 1;

                    //actualizacion del valor de dezplazamiento en x
                    POS1RR += tamanioCuadros;

                    //lo que me hizo la vida de cuadritos por un dia fue el no haber actualizado el valod el contador de procresos lol v:
                    contadorProcesos += 1;
                }

                unNodo = unNodo.Siguiente;
                pintarCuadrosRR(unNodo);
            }
        }

        public void dibujoDiagramasRR(int posicion1, int posicion2)
        {
            //Inicializacion  de instumentos
            Graphics papel;
            papel = pictureBox3.CreateGraphics();

            Pen miLápiz = new Pen(Color.Black);
            SolidBrush brocha = new SolidBrush(Color.Red);

            /// -1 valor de pos 1 para que se pueda ver el borde de cada cuadro
            int Pos1 = posicion1 - 1, Pos2 = posicion2 - 1, alto = tamanioCuadros, ancho = tamanioCuadros;

            Dibujar(papel, miLápiz, Pos1, Pos2, alto, ancho);
        }

        /// RELLENO DE CUADROS
        public void rellenarCuadroDiagramasRR(int posicion1, int posicion2, SolidBrush colorCuadro)
        {
            ///Inicializacion  de instumentos
            Graphics papel;
            papel = pictureBox3.CreateGraphics();

            int Pos1 = posicion1, Pos2 = posicion2, alto = tamanioCuadros, ancho = tamanioCuadros;

            Rellenar(papel, colorCuadro, Pos1, Pos2, alto, ancho);
        }


        //***********************************************************************************************
        //***********************************************************************************************

        //*************
        // ALGORITMO 4
        //*************
        private void copiarColaListaP(Nodo unNodo)
        {
            Nodo unaTareaNueva = new Nodo();

            if (unNodo != null)
            {
                while (unNodo != null)
                {
                    int idTem = unNodo.Id;
                    int tamanioTem = unNodo.Tamanio;
                    int prioridadTem = unNodo.Prioridad;

                    unaTareaNueva.Id = idTem;
                    unaTareaNueva.Tamanio = tamanioTem;
                    unaTareaNueva.Prioridad = prioridadTem;


                    Tareas nuevaTarea = new Tareas(idTem, tamanioTem, prioridadTem);

                    _listaPrioridad.InsertarNodo(unaTareaNueva);
                    listaTareasP.Add(nuevaTarea);
                    
                    unNodo = unNodo.Siguiente;
                }

                ReordenaListaP();
            }
            else
            {
                MessageBox.Show("No hay nada que copiar");
            }
        }


        //Reordenar aqui la lista nueva
        private void ReordenaListaP()
        {
            //Ordenando
            listaTareasPOrdenados.Clear();
            listaTareasPOrdenados = listaTareasP.OrderBy(tarea => tarea.Prioridad).ToList();
            
            //Se omite el ver las tareas en el listBox

            pintarTareasListaP();
        }

        void pintarTareasListaP()
        {
            //el problema no estaba en este foreach estaba en que
            //no se necesitaba un while de más, pues el foreach recorre por si mismo
            // de acuerdo al numero de elementos
            //MessageBox.Show("estamos adentro :)" + "ciclo " + contadorNumeroTareas);
            foreach (Tareas tarea in listaTareasPOrdenados)
            {
                //MessageBox.Show("estamos adentro :)");
                pintarCuadrosP(tarea);
            }
        }

        // PINTAR CUADROS ALGORITMO 2
        void pintarCuadrosP(Tareas tareaOrdenada)
        {       
            int contadorProcesos = 0, tamanioTarea = tareaOrdenada.Tamanio;

                while (contadorProcesos < tamanioTarea)
                {
                    dibujoDiagramasP(POS1P, POS2);

                    if (tamanioTarea == 1)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Green);
                        rellenarCuadroDiagramasP(POS1P, POS2, brocha);
                    }
                    if (tamanioTarea == 2)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Orange);
                        rellenarCuadroDiagramasP(POS1P, POS2, brocha);
                    }
                    if (tamanioTarea == 3)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Red);
                        rellenarCuadroDiagramasP(POS1P, POS2, brocha);
                    }
                    if (tamanioTarea == 4)
                    {
                        SolidBrush brocha = new SolidBrush(Color.DarkMagenta);
                        rellenarCuadroDiagramasP(POS1P, POS2, brocha);
                    }
                    if (tamanioTarea == 5)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Yellow);
                        rellenarCuadroDiagramasP(POS1P, POS2, brocha);
                    }
                    if (tamanioTarea == 6)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Pink);
                        rellenarCuadroDiagramasP(POS1P, POS2, brocha);
                    }
                    if (tamanioTarea == 7)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Violet);
                        rellenarCuadroDiagramasP(POS1P, POS2, brocha);
                    }
                    if (tamanioTarea == 8)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Blue);
                        rellenarCuadroDiagramasP(POS1P, POS2, brocha);
                    }
                    if (tamanioTarea == 9)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Brown);
                        rellenarCuadroDiagramasP(POS1P, POS2, brocha);
                    }
                    if (tamanioTarea == 10)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Aquamarine);
                        rellenarCuadroDiagramasP(POS1P, POS2, brocha);
                    }
                    if (tamanioTarea == 11)
                    {
                        SolidBrush brocha = new SolidBrush(Color.Gray);
                        rellenarCuadroDiagramasP(POS1P, POS2, brocha);
                    }

                    numeroColor += 1;

                    //actualizacion del valor de dezplazamiento en x
                    POS1P += tamanioCuadros;

                    //lo que me hizo la vida de cuadritos por un dia fue el no haber actualizado el valod el contador de procresos lol v:
                    contadorProcesos += 1;
                }
        }

        public void dibujoDiagramasP(int posicion1, int posicion2)
        {
            //Inicializacion  de instumentos
            Graphics papel;
            papel = pictureBox4.CreateGraphics();

            Pen miLápiz = new Pen(Color.Black);
            SolidBrush brocha = new SolidBrush(Color.Red);

            /// -1 valor de pos 1 para que se pueda ver el borde de cada cuadro
            int Pos1 = posicion1 - 1, Pos2 = posicion2 - 1, alto = tamanioCuadros, ancho = tamanioCuadros;

            Dibujar(papel, miLápiz, Pos1, Pos2, alto, ancho);
        }

        /// RELLENO DE CUADROS
        public void rellenarCuadroDiagramasP(int posicion1, int posicion2, SolidBrush colorCuadro)
        {
            ///Inicializacion  de instumentos
            Graphics papel;
            papel = pictureBox4.CreateGraphics();

            int Pos1 = posicion1, Pos2 = posicion2, alto = tamanioCuadros, ancho = tamanioCuadros;

            Rellenar(papel, colorCuadro, Pos1, Pos2, alto, ancho);
        }











        //***********************************************************************************************
        //***********************************************************************************************

        /// MENSAJES
        private void MostrarMensaje(string mensage, int duracion)
        {
            using (Timer t = new Timer())
            {
                Timer time = new Timer();
                time.Interval = duracion;
                time.Tick += tiempo;

                time.Start();
                MessageBox.Show(mensage);
            }
        }

        private void tiempo(object sender, EventArgs e)
        {
            (sender as Timer).Stop();
            SendKeys.Send("{ESC}");
        }


        //***********************************************************************************************
        //***********************************************************************************************

        //************************
        //  PILA <- NO SE USA


        //PILA
        private void btnAgregarNuevoNodo_Click(object sender, EventArgs e)
        {
            //codigo apilar procesos a la pila

            Nodo UnNuevoNodo = new Nodo();

            //Convertir a entero antes de asignar
            int id = Convert.ToInt32(txtId.Text);
            int tamanio = Convert.ToInt32(txtTamanio.Text);
            int prioridad = Convert.ToInt32(txtPrioridad.Text);

            UnNuevoNodo.Id = id;
            UnNuevoNodo.Tamanio = tamanio;
            UnNuevoNodo.Prioridad = prioridad;

            //Apilando el prodceso a la pila
            _miPila.Apilar(UnNuevoNodo);
            MostrarPila();
        }


        void MostrarPila()
        {
            //cada listBox se limpia

            //Desmarcar THIS
            //listMiPila.Items.Clear();
            //listBoxTamanio.Items.Clear();
            //listBoxPrioridad.Items.Clear();
            
            if (_miPila.Tope() != null)
            {
                MostrarNodoEnLista(_miPila.Tope());
            }
        }


        //************************
        //  PILA <- NO SE USA
        void MostrarNodoEnLista(Nodo unNodo)
        {   //Desmarcar THIS
            //listMiPila.Items.Add(unNodo.Id);

            //listBoxTamanio.Items.Add(unNodo.Tamanio);
            //listBoxPrioridad.Items.Add(unNodo.Prioridad);

            if (unNodo.Siguiente != null)   
            {   //llamar recursivamente mientras no este vacía
                MostrarNodoEnLista(unNodo.Siguiente);
            }
        }

        //************************
        //  PILA <- NO SE USA
        private void btnDesapilar_Click(object sender, EventArgs e)
        {
            _miPila.Desapilar();
            MostrarPila();
        }

        //************************



        

        //Recorrer lista doble



        /* FIRST COME FIRST SERVED */
        /* FECHAS DE ENTREGA
             
        #1 -> 22 de abril
        #2 -> 29 de abril
        #3 -> 06 de mayo

        Falta -> 8 de abril
         */



        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lstIdTarea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTituloFCFS_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
