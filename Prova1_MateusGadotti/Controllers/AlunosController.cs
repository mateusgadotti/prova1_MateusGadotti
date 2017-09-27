using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Prova1_MateusGadotti.Models;

namespace Prova1_MateusGadotti.Controllers
{
    public class AlunosController : Controller
    {
        private ApplicationDbContext _context;

        public AlunosController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var aluno = _context.Aluno.Include(a => a.Faixa).Include(a => a.TipoDeAssociacao);
            return View(aluno);
        }
        public ActionResult Details(int id)
        {

            foreach (var aluno in _context.Aluno.ToList())
            {
                if (aluno.Id == id)
                {
                    return View(aluno);
                }
            }
            return HttpNotFound();
        }
    }
}