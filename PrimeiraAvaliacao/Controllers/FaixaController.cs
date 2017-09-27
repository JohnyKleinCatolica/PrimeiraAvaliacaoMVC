using PrimeiraAvaliacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrimeiraAvaliacao.Controllers
{
    public class FaixaController : Controller
    {
        
        public IEnumerable<Faixa> GetFaixas()
        {
            return new List<Faixa>
            {
                new Faixa {Nome = "Amarela", Grau = "8K", Id = 1 },
                new Faixa {Nome = "Branca", Grau = "20K", Id = 2 },
                new Faixa {Nome = "Azul", Grau = "2K", Id = 3 }
            };
        }

        public ActionResult Index()
        {
            return View(GetFaixas());
        }

        public ActionResult Details(int id)
        {
            var faixa = GetFaixas().SingleOrDefault(m => m.Id == id);

            if (faixa == null)
                return HttpNotFound();

            return View(faixa);

        }
    }
}