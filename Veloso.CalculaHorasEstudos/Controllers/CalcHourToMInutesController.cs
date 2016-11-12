using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Veloso.CalculaHorasEstudos.Controllers
{
    public class CalcHourToMinutesController : Controller
    {
        // GET: CalculaHoras
        public ActionResult Index()
        {
            return View();
        }

        // GET: CalculaHoras/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CalculaHoras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CalculaHoras/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CalculaHoras/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CalculaHoras/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CalculaHoras/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CalculaHoras/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
