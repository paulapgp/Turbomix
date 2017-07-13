using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioEntregar2;

namespace UnitTestProject1
{
    [TestClass]
    public class CocinaServiceTest
    {
        private ICocina sut;
        private Alimento alimento1;
        private Alimento alimento2;
        private Alimento pollo;
        private Alimento curry;
        Receta recetaPolloCurry;

        [TestInitialize]
        public void init()
        {
            sut = new CocinaService();
            alimento1 = new Alimento();
            alimento1.Nombre = "Pato";
            alimento2 = new Alimento();
            alimento2.Nombre = "Queso";

            pollo = new Alimento();
            pollo.Nombre = "Pollo";
            curry = new Alimento();
            curry.Nombre = "Curry";
            recetaPolloCurry = new Receta(pollo, curry);
        }
        
        [TestMethod]
        public void TestCalentar()
        {
            sut.Calentar(alimento1, alimento2);
            Assert.IsTrue(alimento1.Calentado);
            Assert.IsTrue(alimento2.Calentado);
        }

        [TestMethod]
        public void TestComprobarAlimentos()
        {
            sut.Calentar(alimento1, alimento2);
            Assert.IsTrue(sut.ComprobarAlimentos(recetaPolloCurry, alimento1, alimento2));
        }
    }
}
