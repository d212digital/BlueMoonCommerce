using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.Web.Controllers
{
    public class WebLeadsController : Controller
    {
        // GET: WebLeads
        public ActionResult WebIndex()
        {
            return View();
        }

        // GET: WebLeads/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WebLeads/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WebLeads/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("WebIndex");
            }
            catch
            {
                return View();
            }
        }

        // GET: WebLeads/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WebLeads/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("WebIndex");
            }
            catch
            {
                return View();
            }
        }

        // GET: WebLeads/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WebLeads/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("WebIndex");
            }
            catch
            {
                return View();
            }
        }
    }
}
