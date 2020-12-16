using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Arbol_Binario_Moises_Masis
{
    class Arbol_Binario
    {
        public Nodo_Arbol Raiz;
        public Nodo_Arbol aux;

        // Constructor por defecto
        public Arbol_Binario()
        {
            aux = new Nodo_Arbol();
        }

        public Arbol_Binario(Nodo_Arbol nueva_raiz)
        {
            Raiz = nueva_raiz;
        }
        // Función para agregar un nuevo nodo (valor) al Árbol Binario.
        public void Insertar(double x)
        {
            if (Raiz == null)
            {
                Raiz = new Nodo_Arbol(x, null, null, null);
                Raiz.nivel = 0;
            }
            else
                Raiz = Raiz.Insertar(x, Raiz, Raiz.nivel);
        }
        // Función para eliminar un nodo (valor) del Árbol Binario.
        public void Eliminar(double x)
        {
            if (Raiz == null)
                Raiz = new Nodo_Arbol(x, null, null, null);
            else
                Raiz.Eliminar(x, ref Raiz);
        }

        // ******** Funciones para el dibujo del Árbol Binario en el Formulario **************
        // Función que dibuja el Árbol Binario
        public void DibujarArbol(Graphics grafo, Font fuente, Brush Relleno, Brush
        RellenoFuente, Pen Lapiz, Brush encuentro)
        {
            int x = 400; // Posiciones de la raíz del árbol
            int y = 75;
            if (Raiz == null) return;
            Raiz.PosicionNodo(ref x, y); //Posicion de todos los Nodos
            Raiz.DibujarRamas(grafo, Lapiz); //Dibuja los Enlaces entre nodos
                                             //Dibuja todos los Nodos
            Raiz.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro);
        }

        public int x1 = 400; // Posiciones iniciales de la raíz del árbol
        public int y2 = 75;

        // Función para Colorear los nodos

        public void colorear(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente,
                            Pen Lapiz, Nodo_Arbol Raiz, bool post, bool inor, bool preor)
        {
            Brush entorno = Brushes.White;
            if (inor == true)
            {
                if (Raiz != null)
                {
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post, inor,
                    preor);
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000); // pausar la ejecución 1000 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post, inor,
                    preor);
                }
            }
            else if (preor == true)
            {
                if (Raiz != null)
                {
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000); // pausar la ejecución 1000 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post,
                    inor, preor);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post,
                    inor, preor);
                }
            }
            else if (post == true)
            {
                if (Raiz != null)
                {
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post,
                    inor, preor);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post,
                    inor, preor);
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000); // pausar la ejecución 1000 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                }
            }
        }

        public void reccorridoPos()
        {
            PosOrden(Raiz);
        }
        public void reccorridoPre()
        {
            PreOrden(Raiz);
        }
        public void reccorridoIn()
        {
            InOrden(Raiz);
        }
        public void PreOrden(Nodo_Arbol temp)
        {
            if (temp != null)
            {
                PreOrden(temp.Izquierdo);
                MessageBox.Show(temp.info.ToString(), "Mostrando Datos");
                PreOrden(temp.Derecho);
            }
        }
        public void InOrden(Nodo_Arbol temp)
        {
            if (temp != null)
            {
                MessageBox.Show(temp.info.ToString(), "Mostrando Datos");
                InOrden(temp.Izquierdo);
                InOrden(temp.Derecho);
            }
        }
        public void PosOrden(Nodo_Arbol temp)
        {
            if (temp != null)
            {
                PosOrden(temp.Izquierdo);
                PosOrden(temp.Derecho);
                MessageBox.Show(temp.info.ToString(), "Mostrando Datos");
            }
        }
    }
}
