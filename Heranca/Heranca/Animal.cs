using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heranca
{
    abstract class Animal
    {
        public Animal(String nome)
        {
            this.sexo = 'M';
            this.nome = nome;
        }

        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private Char sexo;

        public Char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        private int numeroFilhotes;

        public int NumeroFilhotes
        {
            get { return numeroFilhotes; }
            set { numeroFilhotes = value; }
        }

        protected int numeroDeBatidasDoCoracaoPorMinuto;

        public abstract void Falar();
    }
}
