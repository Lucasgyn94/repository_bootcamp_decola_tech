using Microsoft.VisualStudio.TestTools.UnitTesting;
using Contas.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas.cs.Tests
{
    [TestClass()]
    public class ContasTests
    {
        [TestMethod()]
        public void SomaTest()
        {
            var a = 5;
            var b = 5;
            var expected = 10;
            var Contas = new Contas();

            var result = Contas.Soma(5, 5);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void SubtracaoTest()
        {
            var a = 5;
            var b = 4;
            var expected = 1;
            var Contas = new Contas();

            var result = Contas.Subtracao(5, 4);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void MultiplicacaoTest()
        {
            var a = 5;
            var b = 5;
            var expected = 25;
            var Contas = new Contas();

            var result = Contas.Multiplicacao(5, 5);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void DivisaoTest()
        {
            var a = 10;
            var b = 2;
            var expected = 5;
            var Contas = new Contas();

            var result = Contas.Divisao(10, 2);

            Assert.AreEqual(expected, result);
        }
    }
}