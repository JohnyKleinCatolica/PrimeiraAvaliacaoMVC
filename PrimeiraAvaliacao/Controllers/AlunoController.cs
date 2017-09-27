using PrimeiraAvaliacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrimeiraAvaliacao.Controllers
{
    public class AlunoController : Controller
    {

        public IEnumerable<Aluno> GetAluno()
        {
            return new List<Aluno>
            {
                new Aluno {Nome="Johny", CPF = "548787", Faixa  = new Faixa {Nome = "Branca", Grau = "9k" },
                    TipoDeAssociacao = new TipoDeAssociacao {Nome = "Anual", Mensalidade = 100, Periodo = 2 }, Id = 1 },
                new Aluno {Nome="Rafael", CPF = "45421254", Faixa  = new Faixa {Nome = "Verde", Grau = "40k" }, 
                    TipoDeAssociacao = new TipoDeAssociacao {Nome = "Mensal", Mensalidade = 20, Periodo = 12 }, Id = 2 }
            };
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