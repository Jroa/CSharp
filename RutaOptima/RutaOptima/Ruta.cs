using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RutaOptima
{
    public class Ruta
    {
        private IList<Nodo> nodos;

        public Ruta(IList<Nodo> nodos)
        {
            this.nodos = nodos;
        }

        public int distancia(string origen, string destino)
        {
            foreach(Nodo nodo in nodos){
                if (nodo.origen == origen && nodo.destino == destino) {
                    return nodo.distancia;
                }
            }
            return 0;
        }

        public IList<Nodo> trazarRuta(string origen, string destino)
        {
            return new List<Nodo>();
        }
    }
}
