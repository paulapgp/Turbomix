using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioEntregar2;

namespace UnitTestProject1
{
    [TestClass]
    public class TurbomixTest
    {
        [TestMethod]
        public void TestPesar()
        {
            Turbomix sut = new Turbomix();
            Alimento mAlimento = new Alimento();
            mAlimento.Peso = 0.75F;
            float resultado = sut.Pesar(mAlimento);

            Assert.AreEqual(resultado, 0.75);
        
        }
        [TestMethod]
        public void TestPesarYCocinar()
        {
            Turbomix sut = new Turbomix();
            Alimento mAlimento1 = new Alimento();
            mAlimento1.Peso = 1.5F;
            Alimento mAlimento2 = new Alimento();
            mAlimento1.Peso = 5F;
            Plato resultado = sut.PesarYCocinar(mAlimento1, mAlimento2);
            Plato mPlato = new Plato(mAlimento1, mAlimento2);

            Assert.AreEqual(resultado.NombrePlato, mPlato.NombrePlato);


        }
    }
}
