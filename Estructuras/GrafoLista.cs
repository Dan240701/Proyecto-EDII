using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras
{
    internal class GrafoLista
    {
        public int vertice;
        public List<int>[] lista;

        public GrafoLista(int vertices)
        {
            vertice = vertices;
            lista = new List<int>[vertices];
            for (int i = 0; i < vertices; i++)
            {
                lista[i] = new List<int>();
            }
        }

        public void AgregarArista(int origen, int destino)
        {
            lista[origen].Add(destino);
        }

        public bool EsVerticeValido(int vertice)
        {
            return vertice >= 0 && vertice < this.vertice;
        }

        public bool EsSumidero(int vertice)
        {
            return lista[vertice].Count == 0;
        }

        public void EliminarVertice(int vertice)
        {
            for (int i = 0; i < this.vertice; i++)
            {
                lista[i].Remove(vertice);
            }
        }
    }
}
