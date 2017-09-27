using PrimeiraAvaliacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrimeiraAvaliacao.Controllers
{
    public class TipoDeAssociacaoController : Controller
    {


        private ApplicationDbContext _context;

        public TipoDeAssociacaoController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public IEnumerable<TipoDeAssociacao> GetTipoDeAssociacao()
        {

            /*return new List<TipoDeAssociacao>
            {
                new TipoDeAssociacao {Nome = "Mensal", Periodo = 1, Mensalidade = 123, Id = 1},
                new TipoDeAssociacao {Nome = "Anual", Periodo = 5, Mensalidade = 300, Id = 2},
                new TipoDeAssociacao {Nome = "Semanal", Periodo = 24, Mensalidade = 13, Id = 3}
            };*/
            IEnumerable<TipoDeAssociacao> tipos = _context.TipoDeAssociacao.ToList();
            return tipos;
        }


        public ActionResult Index()
        {
            return View(GetTipoDeAssociacao());
        }

        public ActionResult Details(int id)
        {
            var tipo = GetTipoDeAssociacao().SingleOrDefault(m => m.Id == id);

            if (tipo == null)
                return HttpNotFound();

            return View(tipo);

        }
    }
}