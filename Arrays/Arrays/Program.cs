using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] salasDaFase = new String[5];
            salasDaFase[0] = "Laboratorio de TI";
            salasDaFase[1] = "Laboratorio de Dissecagem";
            salasDaFase[2] = "Sala de operação";
            salasDaFase[3] = "Sala de aula";
            salasDaFase[4] = "Sala da secretaria";

            for (int i = 0; i < salasDaFase.Length; i++)
            {
                Console.WriteLine(salasDaFase[i]);
            }
            
            int[] sequenciaFibbonaci = { 1, 1, 2, 3, 5, 8, 11, 19 };

            int[] sequenciaMaluca = { 5, 3, 0, -1, 10, 30, 25 };
            Array.Sort(sequenciaMaluca);

            foreach (var elemento in sequenciaFibbonaci)
            {
                Console.WriteLine(elemento);
            }

            int[,] matriz = new int[2, 2];

            matriz[0, 0] = 0;
            matriz[0, 1] = 1;
            matriz[1, 0] = 0;
            matriz[1, 1] = 1;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(matriz[i, j]);
                }
            }

            //Esperar o usuario apertar uma tecla
            Console.ReadKey();

            /*
             lkdsjflksdjf
             sdkfjsldkfjsd
             skdlfjlskdjfsd
              
            */
            DiasDaSemana hoje = DiasDaSemana.Quarta;

            Console.WriteLine(hoje);

            string segundaStr = "Segunda";

            DiasDaSemana segunda = 
                (DiasDaSemana)Enum.Parse(typeof(DiasDaSemana), segundaStr);

            String vinteStr = "20";

            int vinte = int.Parse(vinteStr);

            switch (hoje)
            {
                case DiasDaSemana.Segunda:
                    Console.WriteLine("Hoje é segunda-feira");
                    break;
                default:
                    break;
            }

            Console.WriteLine("Digite sua idade");

            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine(idade);

            String corDaPorta = "Vermelha";
            float larguraDaPorta = 1.0f;
            float alturaDaPorta = 2.5f;
            bool temJanelaNaPorta = true;

            Console.ReadKey();
        }
    }

    

    /// <summary>
    /// Esse enum serve para identificar os dias semana
    /// </summary>
    enum DiasDaSemana
    {
        Segunda = 1,
        Terca = 2,
        Quarta = 3,
        Quinta,
        Sexta,
        Sabado
    }
}
