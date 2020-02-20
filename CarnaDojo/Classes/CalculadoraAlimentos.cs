using System;
using System.Collections.Generic;
using System.Text;

namespace CarnaDojo.Classes
{
    public class CalculadoraAlimentos
    {
        const int PesoBaseParaDieta = 100;
        public float calorias { get; set; }
        public float proteinasGramas { get; set; }
        public float gordurasGramas { get; set; }
        public float carboidratosGramas { get; set; }

        public CalculadoraAlimentos() {}

        public bool VerificaReiMomoPrecisaDieta(float pesoAtual)
        {
            return !(pesoAtual < PesoBaseParaDieta);
        }

        public CalculadoraAlimentos(float calorias, float carboidratosGramas, float proteinasGramas, float gordurasGramas)
        {
            this.carboidratosGramas = carboidratosGramas;
            this.proteinasGramas = proteinasGramas;
            this.gordurasGramas = gordurasGramas;
            this.calorias = calorias;
        }

        internal void calculaAlimento(string nomeAlimento, string carbG, string protG, string gordG)
        {
            Console.Clear();
        }

        public object CalculaCarboidratoOuProteina(int carboidratoOuProteina)
        {
            return carboidratoOuProteina * 4;
        }

        public object CalculaGordura(int gordura)
        {
            return gordura * 9;
        }
    }
}
