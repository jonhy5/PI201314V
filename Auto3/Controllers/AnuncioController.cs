﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Auto3.Controllers
{
    public class AnuncioController : Controller
    {
        //
        // GET: /Anuncio/

        public ActionResult Index()
        {
            return View();
        }

        //
        // POST: /Anuncio/Pesquisa
        [HttpPost]
        public ActionResult Pesquisa(FormCollection collection)
        {
            return View();
        }

        //
        // GET: /Anuncio/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Anuncio/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Anuncio/Create

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

        //
        // GET: /Anuncio/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Anuncio/Edit/5

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

        //
        // GET: /Anuncio/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // DELETE: /Anuncio/Delete/5

        [HttpDelete]
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
        [HttpPost]
        public ActionResult InsertComment(int id, FormCollection collection) {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {

                return View();
            }
        
        }
    }
}
