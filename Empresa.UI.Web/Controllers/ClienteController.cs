using Empresa.Db;
using Empresa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Empresa.UI.Web.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            var db = new ClienteDb();
            var lista = db.Listar();

            return View(lista);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int Id)
        {
            var db = new ClienteDb();
            var cliente = db.ObterPorId(Id);

            return View(cliente);
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            try
            {
                // TODO: Add insert logic here
                var db = new ClienteDb();
                db.Inserir(cliente);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(cliente);
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int Id)
        {
            var db = new ClienteDb();
            var cliente = db.ObterPorId(Id);

            return View(cliente);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Cliente cliente)
        {
            try
            {
                // TODO: Add update logic here
                var db = new ClienteDb();
                db.Atualizar(cliente);
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View(cliente);
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            var db = new ClienteDb();
            var cliente = db.ObterPorId(id);
            return View(cliente);
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var db = new ClienteDb();
                db.Excluir(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(id);
            }
        }
    }
}
