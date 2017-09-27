using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Prova1_MateusGadotti.Models;

namespace Prova1_MateusGadotti.Controllers
{
    public class TiposDeAssociacoesController : Controller
    {
        // GET: TiposDeAssociacoes

        private ApplicationDbContext _context;

        public TiposDeAssociacoesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var tipoDeAssociacao = _context.TipoDeAssociacao.ToList();
            return View(tipoDeAssociacao);
        }
        public ActionResult Details(int id)
        {

            foreach (var tipoDeAssociacao in _context.TipoDeAssociacao.ToList())
            {
                if (tipoDeAssociacao.Id == id)
                {
                    return View(tipoDeAssociacao);
                }
            }
            return HttpNotFound();
        }

    }
}