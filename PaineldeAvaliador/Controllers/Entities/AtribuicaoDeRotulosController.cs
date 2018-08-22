using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PaineldeAvaliador.Facade;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PaineldeAvaliador.Controllers.Entities
{
    public class AtribuicaoDeRotulosController : Controller
    {

        private AtribuicaoDeRotulosFacade facade = new AtribuicaoDeRotulosFacade();

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["Candidatos"] = facade.GetAllCandidatos();
            ViewData["Keywords"] = facade.GetAllKeywords();
            return View("../Entities/AtribuicaoDeRotulos/Index");  
        }
    }
}
