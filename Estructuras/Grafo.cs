using System;
using Estructuras;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructuras
{
    public partial class Grafo : Form
    {
        private GrafoLista grafos;
        public Grafo()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                int vertices = int.Parse(txtVertice.Text);
                grafos = new GrafoLista(vertices);
                MessageBox.Show("Vertices agregados correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("No esta ingresando un valor permitido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgArista_Click(object sender, EventArgs e)
        {
            if (grafos == null)
            {
                MessageBox.Show("Cree un grafo antes de agregar aristas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int origen = int.Parse(txtOrigen.Text);
                int destino = int.Parse(txtDestino.Text);

                if (grafos.EsVerticeValido(origen) && grafos.EsVerticeValido(destino))
                {
                    grafos.AgregarArista(origen, destino);
                    Actualizar();
                    txtOrigen.Clear();
                    txtDestino.Clear();
                }
                else
                {
                    MessageBox.Show("Ingrese vértices válidos para la arista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese números válidos para el origen y el destino.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Actualizar()
        {
            txtImprimir.Clear();
            txtImprimir.AppendText("\nResultado del grafo ");
            for (int i = 0; i < grafos.vertice; i++)
            {
                txtImprimir.AppendText($"Vertice {i}-->\n");
                foreach (var graf in grafos.lista[i])
                {
                    txtImprimir.AppendText($"{graf} \n");
                }
                txtImprimir.AppendText("\n");
            }
        }
        private void NodoAdyacente(int v)
        {
            if (grafos == null)
            {
                MessageBox.Show("Ingrese un dato para poder mostrar sus nodos adyacentes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (v < 0 || v >= grafos.vertice)
            {
                MessageBox.Show("El dato supera el vertice definido con anterioridad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            txtImprimir.AppendText($"Los nodos adyacentes de {v} son \n");
            foreach (var nodo in grafos.lista[v])
            {
                txtImprimir.AppendText($"{nodo}  ");
            }
            txtImprimir.AppendText("\n");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int verticeAEliminar = int.Parse(txtEliminar.Text);

                if (grafos != null && grafos.EsVerticeValido(verticeAEliminar) && grafos.EsSumidero(verticeAEliminar))
                {
                    grafos.EliminarVertice(verticeAEliminar);
                    Actualizar();
                    MessageBox.Show($"Se eliminó  {verticeAEliminar}  como aristas en los demas vertices.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ingrese un vértice válido que sea sumidero para poder eliminar sus aristas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un número válido para el vértice a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                txtImprimir.Clear();
                int verticeABuscar = int.Parse(txtVerticead.Text);
                NodoAdyacente(verticeABuscar);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un número válido para el vértice.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtVertice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número y no es una tecla de control (por ejemplo, Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, se ignora la pulsación
                e.Handled = true;
            }
        }
    }
}
