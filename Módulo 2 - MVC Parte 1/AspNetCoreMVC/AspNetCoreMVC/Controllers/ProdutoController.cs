using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace AspNetCoreMVC.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index(int? pagina, string ordem)
        {
            //Aula de HttpContext
            //var https = HttpContext.Request.IsHttps;
            //var caminho = HttpContext.Request.Path;
            //var status = HttpContext.Response.StatusCode;
            //var conexao = HttpContext.Connection.LocalIpAddress;
            //return https + "\r\n" + caminho + "\r\n" + status + "\r\n" + conexao;

            // Aula de parametros
            if (!pagina.HasValue) pagina = 1;

            if (String.IsNullOrEmpty(ordem)) ordem = "nome";

            return Ok(String.Format("pagina={0}&ordem={1}", pagina, ordem));
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

        public IActionResult Edit(int id)
        {
            return Ok("O valor de Id = " + id);
        }
    }
}
