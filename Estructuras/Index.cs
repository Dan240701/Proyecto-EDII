using System;
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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void btnArboles_Click(object sender, EventArgs e)
        {
            Arbol arbol = new Arbol();
            this.Hide();
            arbol.ShowDialog();
            this.Show();
        }

        private void btnGrafo_Click(object sender, EventArgs e)
        {
            Grafo grafo = new Grafo();
            this.Hide();
            grafo.ShowDialog();
            this.Show();
        }
    }
}
