using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RutaOptima
{
    public class Nodo
    {

        public Nodo() { }
        public Nodo(string origen, string destino, int distancia) {
            this.origen = origen;
            this.destino = destino;
            this.distancia = distancia;
        }

        public string origen{get; set;}
        public string destino{get; set;}
        public int distancia {get; set;}
    }
}
