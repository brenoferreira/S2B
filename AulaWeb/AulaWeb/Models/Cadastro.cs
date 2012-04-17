using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AulaWeb.Models
{
    public class Cadastro
    {
        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int idade;

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        private String sexo;

        public String Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        private String[] newsletter;

        public String[] Newsletter
        {
            get { return newsletter; }
            set { newsletter = value; }
        }

    }
}