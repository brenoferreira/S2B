using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heranca
{
    abstract class Inseto : Animal
    {
        public Inseto(String nome) : base(nome)
        {
            this.numeroAntenas = 2;

            this.numeroDeBatidasDoCoracaoPorMinuto = 50;
        }

        private int numeroAntenas;

        public int NumeroAntenas
        {
            get { return numeroAntenas; }
            set { numeroAntenas = value; }
        }
    }
}
