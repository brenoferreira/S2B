using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ajax.Models
{
    public class Usuario
    {
        private string username;

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }


        private String senha;

        public String Senha
        {
            get { return senha; }
            set { senha = value; }
        }

    }
}