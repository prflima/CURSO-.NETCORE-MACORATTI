using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVC.Controllers
{
    public class ProdutoController : Controller
    {
        public string Index()
        {
            return "Este é o metódo Action Padrão";
        }

        public IActionResult Detalhe()
        {
            // Testando tipos de Retorno
            //var pessoa = new { Id = 1, Nome = "Paulo Ricardo" };
            //return new ObjectResult(pessoa);
            //return File("images/banner1.svg", "image/svg+xml");
            //return Content("Arquivo PDF", "application/pdf"); /*Testando o retorno em um arquivo PDF*/
            //return RedirectToAction("Index", "Home", new { teste = "Testando a passagem de parametros por redirecionamento" });
            return View();
        }
    }
}
