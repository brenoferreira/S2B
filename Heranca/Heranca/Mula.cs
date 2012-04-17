using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heranca
{
    sealed class Mula : Mamifero
    {
        public Mula() : base("Mula esquisita")
        {
            this.numeroDeBatidasDoCoracaoPorMinuto = 80;
        }

        public override void Falar()
        {
            Console.Write("kdjflksjd");
        }
    }
}
