using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fiap.Exemplo02.Persistencia.Test
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void Calcular_Fatorial_Ok()
        {
            Calculadora calc = new Calculadora();
            var res = calc.Fatorial(5);
            Assert.AreEqual(120, res);
        }

        [TestMethod]
        public void Calcular_Fatorial_Zero()
        {
            Calculadora calc = new Calculadora();
            var res = calc.Fatorial(0);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void Calcular_Fatorial_Negativo()
        {
            Calculadora calc = new Calculadora();
            var res = calc.Fatorial(-5);
        }
    }
}