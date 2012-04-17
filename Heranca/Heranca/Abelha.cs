using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heranca
{
    class Abelha : Inseto
    {
        public Abelha(String nome) : base(nome)
        {
            this.quantidadeMelPorDia = 200.0f;
        }

        private String cor;

        public String Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        private float quantidadeMelPorDia;

        public float QuantidadeMelPorDia
        {
            get { return quantidadeMelPorDia; }
            set { quantidadeMelPorDia = value; }
        }

        public override void Falar()
        {
            Console.WriteLine("Bzzzzzz");
        }
    }
}
