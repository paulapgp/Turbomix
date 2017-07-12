using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioEntregar2;

namespace UnitTestProject1
{
    [TestClass]
    public class TurbomixServiceIntegracionTest
    {
        [TestMethod]
        public void TestPrepararPlato()
        {
            IBascula basculaService = new BasculaService();
            ICocina cocinaService = new CocinaService();

            TurbomixService sut = new TurbomixService(basculaService, cocinaService);
            Alimento mAlimento1 = new Alimento();
            mAlimento1.Nombre = "Espagueti";
            mAlimento1.Peso = 1.5F;
            Alimento mAlimento2 = new Alimento();
            mAlimento2.Nombre = "Tomate";
            mAlimento1.Peso = 5F;

            Receta recetaEspaguetis = new Receta(mAlimento1, mAlimento2);

            Plato resultado = sut.PrepararPlato(mAlimento1, mAlimento2, recetaEspaguetis);

            Plato mPlato = new Plato(mAlimento1, mAlimento2);
            Assert.AreEqual(mPlato, resultado);
        }
    }
}
