using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Listas
            ArrayList lista = new ArrayList();
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);

            foreach (int num in lista)
            {
                Console.WriteLine(num);
            }

            lista.Add("Hello world");
            lista.Add(1.5f);
            lista.Add(new DateTime(2012, 04, 16));

            string helloworld = (string)lista[3];

            DateTime hoje = (DateTime)lista[5];
            int[] vetor = new int[] { 4, 5, 6 };
            lista.AddRange(vetor);
            int quantosElementos = lista.Count;

            lista.Insert(1, 1.5f);

            lista.Insert(10, "duvida"); 
            #endregion

            #region Filas
            Queue filaDoBanco = new Queue();
            filaDoBanco.Enqueue("Joaozinho");
            filaDoBanco.Enqueue("Mariazinha");
            filaDoBanco.Enqueue("Zezinho");

            String espiadaDoPrimeiroElemento = (string)filaDoBanco.Peek();

            String primeiroDaFila = (string)filaDoBanco.Dequeue();
            Console.WriteLine(primeiroDaFila);

            String segundoDaFila = (string)filaDoBanco.Dequeue();
            Console.WriteLine(segundoDaFila);

            String terceiroDaFila = (string)filaDoBanco.Dequeue();
            Console.WriteLine(terceiroDaFila); 
            #endregion

            #region Pilhas
            Stack pilhaDeLivros = new Stack();

            pilhaDeLivros.Push("Harry Potter");
            pilhaDeLivros.Push("O Senhor dos Aneis");
            pilhaDeLivros.Push("Jogos Vorazes");
            pilhaDeLivros.Push("A Espera de um Milagre");

            String livro1 = (String)pilhaDeLivros.Pop();
            String livro2 = (String)pilhaDeLivros.Pop();
            String livro3 = (String)pilhaDeLivros.Pop();
            String livro4 = (String)pilhaDeLivros.Pop(); 
            #endregion

            #region HashTable
            Hashtable dicionario = new Hashtable();

            dicionario.Add("Book", "Livro");
            dicionario.Add("Door", "Porta");
            dicionario.Add("Window", "Janela");

            String windowEmPtBR = (string)dicionario["Window"];
            Console.WriteLine("Window em pt-BR é {0}", windowEmPtBR);

            Console.WriteLine("Book em pt-BR é {0}", dicionario["Book"]);
            Console.WriteLine("Door em pt-BR é {0}", dicionario["Door"]); 
            #endregion

            #region ListaGenerica
            List<int> listaDeInts = new List<int>();
            listaDeInts.Add(10);
            listaDeInts.Add(20);
            listaDeInts.Add(30);

            int dez = listaDeInts[0];
            int vinte = listaDeInts[1];
            int trinta = listaDeInts[2];

            List<String> listaDeStrings = new List<string>();
            listaDeStrings.Add("Hello");
            listaDeStrings.Add("World"); 
            #endregion

            #region Fila Generica
            Queue<String> filaBancoGenerica = new Queue<string>();

            filaBancoGenerica.Enqueue("Joao");
            filaBancoGenerica.Enqueue("Maria");
            filaBancoGenerica.Enqueue("Zé");

            String primeiroFilaGen = filaBancoGenerica.Dequeue(); 
            #endregion

            #region Pilhas Genericas
            Stack<DateTime> datas = new Stack<DateTime>();

            datas.Push(DateTime.Now);
            datas.Push(new DateTime(2012, 04, 17));
            datas.Push(new DateTime(2012, 04, 18));
            datas.Push(new DateTime(2012, 04, 19));

            DateTime ultimaData = datas.Pop(); 
            #endregion

            #region Dictionary
            Dictionary<int, String> numerosPorExtenso = new Dictionary<int, string>();

            numerosPorExtenso.Add(1, "Um");
            numerosPorExtenso.Add(50, "Cinquenta");
            numerosPorExtenso.Add(110, "Cento e dez");

            String cinquentaPorExtenso = numerosPorExtenso[50]; 
            #endregion
        }
    }
}
