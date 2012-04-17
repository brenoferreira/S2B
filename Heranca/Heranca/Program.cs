using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Abelha abelha = new Abelha("abelium laranjus");

            abelha.Cor = "Laranja";
            abelha.NumeroAntenas = 2;
            abelha.QuantidadeMelPorDia = 300.0f;

            abelha.Falar();

            Animal cachorro = new Cachorro("cachorros latius");

            cachorro.Falar();

            MostrarTipoAnimal(cachorro);

            Mula m = new Mula();

            string str1 = "Idade do fulano e: {0}";

            String str = String.Format("Idade do fulano e: {0}", 15);

            Console.WriteLine(str);

            //Animal a = new Animal("animal") Não Funciona!!!;

            Console.ReadKey();
        }

        static void MostrarTipoAnimal(Animal animal)
        {
            if (animal is Mamifero)
                Console.WriteLine("Animal é um mamifero");
            else if (animal is Cachorro)
                Console.WriteLine("Animal é um cachorro");
            else if (animal is Abelha)
                Console.WriteLine("Animal é uma abelha");
        }
    }
}
