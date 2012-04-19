using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AulaWeb2.Models
{
    public class Produto
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        private float preco;

        public float Preco
        {
            get { return preco; }
            set { preco = value; }
        }

    }
}