using Howzzzat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Howzzzat.Controllers
{
    public class LiveScoresController : Controller
    {
        //
        // GET: /LiveScors/

        
        public ActionResult Index()
        {
            var scores = new List<Howzzzat.Models.LiveScore>()
                {
                    new LiveScore { MatchName = "Ind vs Pak", CurrentScore = "234/5"},
                    new LiveScore { MatchName = "Aus vs Eng", CurrentScore = "111/6"},
                    new LiveScore { MatchName = "NZ vs Zim", CurrentScore = "32/8"}
                };

           

            return PartialView(scores);
        }

        //
        // GET: /LiveScors/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /LiveScors/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /LiveScors/Create

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
        // GET: /LiveScors/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /LiveScors/Edit/5

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
        // GET: /LiveScors/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /LiveScors/Delete/5

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
