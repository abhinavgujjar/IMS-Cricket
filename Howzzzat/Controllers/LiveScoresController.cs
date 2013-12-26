using Howzzzat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Async;

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
                    new LiveScore { MatchName = "Ind vs Pak", 
                        CurrentScore = "234/5" + " " +  DateTime.Now
                    },
                    new LiveScore { MatchName = "Aus vs Eng", 
                        CurrentScore = "111/6" + " " + DateTime.Now
                    },
                    new LiveScore { MatchName = "NZ vs Zim", 
                        CurrentScore = "32/8" + " " +  DateTime.Now}
                };

            return PartialView(scores);
        }

        public async Task<ActionResult> IndexSlow()
        {
            var data1 = "dummy1";
            var data2 = " dummy2";

            LiveScoreWrapper wrapper = new LiveScoreWrapper();

            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            var threadId = System.Threading.Thread.CurrentThread.ManagedThreadId;

            wrapper.Messages.Add("Started controller executiiong on thread:  " + threadId);

            //data1 = await client.GetDataAsync(99);

            data1 = await slowMethod();

            data2 = await slowMethod2(data1);

            wrapper.Messages.Add("Recievede data on thread: " + System.Threading.Thread.CurrentThread.ManagedThreadId);

            var scores = new List<Howzzzat.Models.LiveScore>()
                {
                    new LiveScore { MatchName = "Ind vs Pak", 
                        CurrentScore = "234/5" + " " +  DateTime.Now, 
                        ExternalData = data1 + data2
                    },
                    new LiveScore { MatchName = "Aus vs Eng", 
                        CurrentScore = "111/6" + " " + DateTime.Now,
                    ExternalData = data1 + data2
                    },
                    new LiveScore { MatchName = "NZ vs Zim", 
                        CurrentScore = "32/8" + " " +  DateTime.Now,
                    ExternalData = data1 + data2}
                };

            wrapper.Messages.Add("finished execution on thread: " + System.Threading.Thread.CurrentThread.ManagedThreadId);

            wrapper.Scores = scores;

            return PartialView(wrapper);
        }


        private async Task<string> slowMethod()
        {
            await Task.Delay(4000);

            return "Some delsayed string";
        }

        private async Task<string> slowMethod2(string input)
        {
            await Task.Delay(4000);

            return "Some other delsayed string";
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
