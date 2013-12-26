using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Howzzzat.Controllers
{
    public class HelloController : Controller
    {
        public HelloController(ILogger logger)
        {
            _logger = logger;
        }

        public string SayHello()
        {
            _logger.Log("Hello was executed");
            return "Hello, I am a humble controller";

        }

        public class Ranking
        {
            public string Name { get; set; }
            public int Rank { get; set; }
        }

        public ActionResult GetRankings()
        {
            var rankings = new List<Ranking>(){
                new Ranking { Name = "Tendulkar", Rank =1 },
                new Ranking { Name = "Ricky", Rank = 2 },
            };
            return Json(rankings, JsonRequestBehavior.AllowGet);
        }


        ILogger _logger = null;
    }
}