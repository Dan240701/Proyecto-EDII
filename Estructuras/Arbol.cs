using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructuras
{
    public partial class Arbol : Form
    {
        private Nodo raiz;
        public class Nodo
        {
            public int dato;
            public Nodo Izquierda;
            public Nodo Derecha;
            public Nodo(int dato, Nodo izquierda, Nodo derecha)
            {
                this.dato = dato;
                Izquierda = izquierda;
                Derecha = derecha;
            }
        }
        public Arbol()
        {
            InitializeComponent();
            raiz = null;

        }

        private void CrearNodo(ref Nodo q, int dato)
        {
            q = new Nodo(dato, q, q);
            q.Izquierda = null;
            q.Derecha = null;
        }
        private void InsertarNodo(ref Nodo r, int dato)
        {
            Nodo t1 = null, t2 = null, t = null;
            if (r == null)
            {
                CrearNodo(ref r, dato);
            }
            else
            {
                t1 = t2 = r;
                while (t1 != null)
                {
                    t2 = t1;
                    if (dato < t2.dato)
                        t1 = t2.Izquierda;
                    else
                        t1 = t2.Derecha;
                }
                CrearNodo(ref t, dato);
                if (dato < t2.dato)
                    t2.Izquierda = t;
                else
                    t2.Derecha = t;
            }
        }
        private bool BuscarNodo(Nodo nodo, int dato)
        {
            if (nodo == null)
                return false;

            if (nodo.dato == dato)
                return true;
            else if (dato < nodo.dato)
                return BuscarNodo(nodo.Izquierda, dato);
            else
                return BuscarNodo(nodo.Derecha, dato);
        }

        private Nodo EliminarNodo(Nodo nodo, int dato)
        {
            if (nodo == null)
            {
                MessageBox.Show("El nodo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return nodo;
            }

            if (dato < nodo.dato)
            {
                nodo.Izquierda = EliminarNodo(nodo.Izquierda, dato);
            }
            else if (dato > nodo.dato)
            {
                nodo.Derecha = EliminarNodo(nodo.Derecha, dato);
            }
            else
            {
                // Verifica si el nodo tiene dos hijos
                if (nodo.Izquierda != null || nodo.Derecha != null)
                {
                    // No hace nada, el nodo tiene dos hijos
                    MessageBox.Show("No se puede eliminar el nodo porque tiene hijos.", "No se puede eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    nodo = null;
                    MessageBox.Show($"Se eliminó el nodo {dato}.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            return nodo;
        }

        private void Imprimir(Nodo nodo)
        {
            if (nodo != null)
            {
                Imprimir(nodo.Izquierda);
                Console.WriteLine("{0}", nodo.dato);
                Imprimir(nodo.Derecha);
            }
        }
        private int ContarHojas(Nodo nodo)
        {
            if (nodo == null)
            {
                return 0;
            }

            // Verifica si el nodo es una hoja (no tiene hijos)
            if (nodo.Izquierda == null && nodo.Derecha == null)
            {
                return 1;
            }

            // Recursivamente cuenta las hojas en los subárboles izquierdo y derecho
            int hojasIzquierda = ContarHojas(nodo.Izquierda);
            int hojasDerecha = ContarHojas(nodo.Derecha);

            // Devuelve la suma de las hojas en ambos subárboles
            return hojasIzquierda + hojasDerecha;
            // Llamada a la función y muestra del resultado en un MessageBox

        }



        private void Inicio_Load(object sender, EventArgs e)
        {

        }
        private int Obtenerdato()
        {
            if (txtDato != null && int.TryParse(txtDato.Text, out int dato))
                return dato;

            return 0;
        }
        private void Imprimirtxt(Nodo nodo, int n)
        {
            if (nodo != null)
            {
                Imprimirtxt(nodo.Izquierda, n + 1);
                string espacio = new string(' ', n + 2);
                txtArbol.AppendText($"{espacio}{nodo.dato}\n");
                Imprimirtxt(nodo.Derecha, n + 1);
            }
        }
        private void Actualizar()
        {
            txtArbol.Clear();
            Imprimirtxt(raiz, 0);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int valor = Obtenerdato();
            InsertarNodo(ref raiz, valor);
            Actualizar();
            txtDato.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int datoE = Obtenerdato();
            raiz = EliminarNodo(raiz, datoE);
            Actualizar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            int datoB = Obtenerdato();
            if (BuscarNodo(raiz, datoB))
            {
                MessageBox.Show($"El dato {datoB} se encuentra en el árbol.", "Resultado de la búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"El dato {datoB} no se encuentra en el árbol.", "Resultado de la búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHojas_Click(object sender, EventArgs e)
        {
            // Llamada a la función y muestra del resultado en un MessageBox
            int cantidadHojas = ContarHojas(raiz);
            MessageBox.Show($"El árbol tiene {cantidadHojas} hojas.", "Conteo de Hojas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtDato_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número y no es una tecla de control (por ejemplo, Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, se ignora la pulsación
                e.Handled = true;
            }
        }

        private void txtArbol_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=true;
        }
    }

}
