using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RutaOptima;

namespace RutaOptimaTest
{
    [TestClass]
    public class NodoTest
    {
        private static IList<Nodo> nodos;
        private static Ruta ruta;

        [ClassInitialize]
        public static void RutaOptimaTest(TestContext testContext) {
            nodos = new List<Nodo>();
            Nodo nodo = new Nodo("A", "B", 2);
            nodos.Add(nodo);
            nodo = new Nodo("A", "C", 3);
            nodos.Add(nodo);
            nodo = new Nodo("A", "D", 5);
            nodos.Add(nodo);

            nodo = new Nodo("B", "E", 4);
            nodos.Add(nodo);

            ruta = new Ruta(nodos);
        }

        [TestMethod]
        public void TestDistanciaDesdeAHastaBEs2()
        {
            Assert.IsTrue(ruta.distancia("A", "B") == 2);
        }

        [TestMethod]
        public void TestDistanciaDesdeAHastaCEs3() {
            Assert.IsTrue(ruta.distancia("A", "C") == 3);
        }
        
        [TestMethod]
        public void TestTrazarRutaDeAHastaE() {
            Assert.IsTrue(ruta.trazarRuta("A", "E").Count() == 2);
        }
        
    }
}
