using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVC.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Detalhe()
        {
            Cliente model = new Cliente
            {
                ClienteId = 10,
                Nome = "Paulo Ricardo",
                Email = "paulo.tolkien@macorati.com"
            };

            return View(model);
        }
    }
}
