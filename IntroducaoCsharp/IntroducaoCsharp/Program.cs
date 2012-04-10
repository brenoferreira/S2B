using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntroducaoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numAbasAbertas = 0;

            numAbasAbertas = -1;

            float valorDoProduto = 2.55f;

            double pi = 3.141592;

            char primeiraLetraDoNome = 'B';

            String meuNome = "Breno";

            int valor1 = 10;
            int valor2 = 20;

            int soma = SomaDoisValores(valor1, valor2);

            Console.WriteLine(soma);

            TrocaValores(ref valor1, ref valor2);

            String msg = "Hello world!";
            msg = msg + "S2B é maneiro para caramba";

            Console.WriteLine(valor1);
            Console.WriteLine(valor2);


            int y = 10 / 2;
            y += 10;
            y -= 5;
            y++;
            int z = 10 + y++;
            z = 10 + ++y;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            int j = 110;
            while (j < 110)
            {
                Console.WriteLine(j);
                j++;
            }

            j = 110;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j < 110);

            bool estaChuvendo = false;

            if (estaChuvendo == true)
            {
                Console.WriteLine("Esta chuvendo");
            }
            else
                Console.WriteLine("Não está chuvendo");

            String sexo = "masculino";
            switch (sexo)
            {
                case "masculino":
                    Console.WriteLine("Pode entrar no banheiro masculino");
                    break;
                case "feminino":
                    Console.WriteLine("Pode entrar no banheiro feminino");
                    break;
                default:
                    Console.WriteLine("Se decide aí");
                    break;
            }

            int idade = 100;
            if (idade < 16)
            {
                Console.WriteLine("Não pode entrar! Vaza");
            }
            else if (idade > 15 && idade < 18)
                Console.WriteLine("Pode entrar acompanhado de um maior de idade");
            else
                Console.WriteLine("Enche a cara aí");

            Console.ReadKey();
        }

        static int SomaDoisValores(int x, int y)
        {
            return x + y;
        }

        static void TrocaValores(ref int x, ref int y)
        {
            int aux = x;
            x = y;
            y = aux;
        }
    }
}
