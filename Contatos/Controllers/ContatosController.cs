using AgendaContatos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AgendaContatos.Controllers
{
    public class ContatosController : Controller
    {
        private readonly IContatosDAL cont;
        public ContatosController(IContatosDAL contato)
        {
            cont = contato;
        }

        public IActionResult Index()
        {
            List<Contato> listaContatos = new List<Contato>();
            listaContatos = cont.GetAllContatos().ToList();

            return View(listaContatos);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contato contato = cont.GetContato(id);

            if (contato == null)
            {
                return NotFound();
            }
            return View(contato);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] Contato contato)
        {
            if (ModelState.IsValid)
            {
                cont.AddContato(contato);
                return RedirectToAction("Index");
            }
            return View(contato);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Contato contato = cont.GetContato(id);

            if (contato == null)
            {
                return NotFound();
            }
            return View(contato);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind]Contato contato)
        {
            if (id != contato.ContatoId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                cont.UpdateContato(contato);
                return RedirectToAction("Index");
            }
            return View(contato);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Contato contato = cont.GetContato(id);

            if (contato == null)
            {
                return NotFound();
            }
            return View(contato);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id)
        {
            cont.DeleteContato(id);
            return RedirectToAction("Index");
        }
    }
}