using ConsoleCalc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCalc.Models;

namespace WebCalc.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(OperationModel model)
        {
            var calc = new Calc();

            model.Result = calc.Exec(model.Operation, model.Args.ToArray());

            return View(model);
        }
    }
}