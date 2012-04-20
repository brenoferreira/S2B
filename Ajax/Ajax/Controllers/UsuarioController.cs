using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ajax.Models;

namespace Ajax.Controllers
{
    public class UsuarioController : Controller
    {
        private List<Usuario> usuarios;
        public UsuarioController()
        {
            this.usuarios = new List<Usuario>();
            Usuario u1 = new Usuario();
            u1.UserName = "Joao";
            u1.Senha = "123";
            this.usuarios.Add(u1);

            Usuario u2 = new Usuario();
            u2.UserName = "Maria";
            u2.Senha = "1234";
            this.usuarios.Add(u2);
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public String Cadastro(Usuario usuario)
        {
            this.usuarios.Add(usuario);
            return "OK";
        }

        //Get: /Usuario/VerificaUsuario?username=joao
        public Boolean VerificaUsuario(String username)
        {
            Boolean achou = false;
            foreach (Usuario usuario in this.usuarios)
            {
                if (usuario.UserName == username)
                {
                    achou = true;
                    break;
                }
            }

            return achou;
        }
    }
}
