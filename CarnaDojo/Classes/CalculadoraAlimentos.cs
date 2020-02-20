using System;
using System.Collections.Generic;
using System.Text;

namespace CarnaDojo.Classes
{
    public class CalculadoraAlimentos
    {
        public float calorias { get; set; }
        public float proteinasGramas { get; set; }
        public float gordurasGramas { get; set; }
        public float carboidratosGramas { get; set; }

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
    }
}
