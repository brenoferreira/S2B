using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heranca
{
    abstract class Mamifero : Animal
    {
        public Mamifero(String nome) : base(nome)
        {
            this.numeroMamas = 2;
        }

        private int numeroMamas;

        public int NumeroMamas
        {
            get { return numeroMamas; }
            set { numeroMamas = value; }
        }

    }
}
