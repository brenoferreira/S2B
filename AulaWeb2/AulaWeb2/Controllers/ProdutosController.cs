using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AulaWeb2.Models;

namespace AulaWeb2.Controllers
{
    public class ProdutosController : Controller
    {
        private List<Produto> produtos;

        public ProdutosController()
        {
            this.produtos = new List<Produto>();

            Produto p1 = new Produto();
            p1.ID = 1;
            p1.Nome = "Coca-Cola";
            p1.Preco = 2.5f;
            this.produtos.Add(p1);

            Produto p2 = new Produto();
            p2.ID = 2;
            p2.Nome = "Biscoito";
            p2.Preco = 1.5f;
            this.produtos.Add(p2);

            Produto p3 = new Produto();
            p3.ID = 3;
            p3.Nome = "Azeite";
            p3.Preco = 10;
            this.produtos.Add(p3);
        }

        //
        // GET: /Produtos/

        public ActionResult Index()
        {
            return View(this.produtos);
        }

        //GET: /Produtos/Novo
        public ActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Novo(Produto produto)
        {
            this.produtos.Add(produto);

            return RedirectToAction("Index");
        }
    }
}
