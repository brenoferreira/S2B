using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heranca
{
    class Cachorro : Mamifero
    {
        public Cachorro(String nome) : base(nome)
        {

        }

        public override void Falar()
        {
            Console.WriteLine("Au au");
        }
    }
}
