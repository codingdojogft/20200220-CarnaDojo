using CarnaDojo.Classes;
using NUnit.Framework;

namespace CarnaDojoTestes
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void SeReiMomoTem90kgVerificaSePrecisaDeDieta_EntaoRetornaFalso()
        {
            //Arrange
            var resultadoEsperado = false;
            var pesoReiMomo = 90;
            var calc = new CalculadoraAlimentos();

            //Act
            var resultado = calc.VerificaReiMomoPrecisaDieta(pesoReiMomo);

            //Assert
            Assert.AreEqual(resultado, resultadoEsperado);
        }

        [Test]
        public void SeReiMomoTem110kgVerificaSePrecisaDeDieta_EntaoRetornaVerdadeiro()
        {
            //Arrange
            var resultadoEsperado = true;
            var pesoReiMomo = 110;
            var calc = new CalculadoraAlimentos();

            //Act
            var resultado = calc.VerificaReiMomoPrecisaDieta(pesoReiMomo);

            //Assert
            Assert.AreEqual(resultado, resultadoEsperado);
        }

        [Test]
        public void SeReiMomoTem100kgVerificaSePrecisaDeDieta_EntaoRetornaVerdadeiro()
        {
            //Arrange
            var resultadoEsperado = true;
            var pesoReiMomo = 100;
            var calc = new CalculadoraAlimentos();

            //Act
            var resultado = calc.VerificaReiMomoPrecisaDieta(pesoReiMomo);

            //Assert
            Assert.AreEqual(resultado, resultadoEsperado);
        }

        [Test]
        public void SeAlimentoPossui10GramasdeCarboidratoOuProteinaEntaoRetorna40 ()
        {
            var resultadoEsperado = 40;
            var carboidratoOuProteina = 10;
            var calc = new CalculadoraAlimentos();

            var resultado = calc.CalculaCarboidratoOuProteina(carboidratoOuProteina);

            Assert.AreEqual(resultado, resultadoEsperado);

        }

        [Test]
        public void SeAlimentoPossui20GramasdeCarboidratoOuProteinaEntaoRetorna80()
        {
            var resultadoEsperado = 80;
            var carboidratoOuProteina = 20;
            var calc = new CalculadoraAlimentos();

            var resultado = calc.CalculaCarboidratoOuProteina(carboidratoOuProteina);

            Assert.AreEqual(resultado, resultadoEsperado);

        }

        [Test]

        public void SeAlimentoPossui10GramasDeGorduraEmtaoRetorna90()
        {
            var resultadoEsperado = 90;
            var gordura = 10;
            var calc = new CalculadoraAlimentos();

            var resultado = calc.CalculaGordura(gordura);

            Assert.AreEqual(resultado, resultadoEsperado);

        }

        [Test]
        public void SeAlimentoPossui20GramasDeGorduraEntaoNaoRetorna90()
        { 
            var resultadoEsperado        

        }

    }
}