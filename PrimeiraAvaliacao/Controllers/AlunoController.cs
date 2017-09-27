using PrimeiraAvaliacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace PrimeiraAvaliacao.Controllers
{
    public class AlunoController : Controller
    {
        private ApplicationDbContext _context;

        public AlunoController() {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing) {
            _context.Dispose();
        }

        public IEnumerable<Aluno> GetAluno()
        {
            /*return new List<Aluno>
            {
                new Aluno {Nome="Johny", CPF = "548787", Faixa  = new Faixa {Nome = "Branca", Grau = "9k" },
                    TipoDeAssociacao = new TipoDeAssociacao {Nome = "Anual", Mensalidade = 100, Periodo = 2 }, Id = 1 },
                new Aluno {Nome="Rafael", CPF = "45421254", Faixa  = new Faixa {Nome = "Verde", Grau = "40k" }, 
                    TipoDeAssociacao = new TipoDeAssociacao {Nome = "Mensal", Mensalidade = 20, Periodo = 12 }, Id = 2 }
            };*/
            IEnumerable<Aluno> alunos = _context.Alunos.ToList();
            return alunos;
        }

        public ActionResult Index()
        {
            return View(GetAluno());
        }

        public ActionResult Details(int id)
        {
            var aluno = GetAluno().SingleOrDefault(m => m.Id == id);

            if(aluno == null)
                return HttpNotFound();

            return View(aluno);
           
        }
    }
}