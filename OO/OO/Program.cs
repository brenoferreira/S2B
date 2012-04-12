using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OO
{
    class Program
    {
        static void Main(string[] args)
        {
            Porta portaDaSala = new Porta();
            portaDaSala.Abrir();
            portaDaSala.Abrir();

            Porta minhaPortaCustomizada = new Porta(5, 3);

            minhaPortaCustomizada.TemJanela = true;

            Cliente cliente = new Cliente();

            cliente.AumentaLimiteDeCredito(2000);
            cliente.AumentaLimiteDeCredito(3000);
            Console.WriteLine("Limite é: " + cliente.LimiteCredito);

            cliente.DiminuiLimiteCredito(4500);
            Console.WriteLine(cliente.LimiteCredito);

            cliente.DiminuiLimiteCredito(500, true);
            Console.WriteLine(cliente.EstaBloqueado);
        }
    }

    class Porta
    {
        public Porta()
        {
            this.altura = 2.5f;
            this.largura = 1.0f;
        }

        public Porta(float altura, float largura)
        {
            this.altura = altura;
            this.largura = largura;
        }

        private string cor;
        private float altura;
        private float largura;
        private bool temJanela;
        private bool estaAberta;

        public String Cor
        {
            get { return this.cor; }
            set { this.cor = value; }
        }

        public Boolean TemJanela
        {
            get { return this.temJanela; }
            set { this.temJanela = value; }
        }

        public Boolean EstaAberta
        {
            get { return this.estaAberta; }
        }

        public float Altura
        {
            get { return this.altura; }
        }

        public float Largura
        {
            get { return this.largura; }
        }

        public void Abrir()
        {
            if (this.estaAberta != true)
                this.estaAberta = true;
            else
                Console.Write("Já está aberta");
        }

        public void Fechar()
        {
            if (this.estaAberta == true)
                this.estaAberta = false;
            else
                Console.Write("Esta fechada");
        }
    }
}
