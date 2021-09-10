using CiclosDeVidaEjemplo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CiclosDeVidaEjemplo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITransient _Transient;
        private readonly IScoped _Scoped;
        private readonly ISingleton _Singleton;

        private readonly ITransient _Transient2;
        private readonly IScoped _Scoped2;
        private readonly ISingleton _Singleton2;

        public HomeController(ITransient transient, IScoped scoped, ISingleton singleton, ITransient transient2, IScoped scoped2, ISingleton singleton2)
        {
            _Transient = transient;
            _Scoped = scoped;
            _Singleton = singleton;

            _Transient2 = transient2;
            _Scoped2 = scoped2;
            _Singleton2 = singleton2;
        }

        public IActionResult Index()
        {
            ViewBag.transient = _Transient;
            ViewBag.scoped = _Scoped;
            ViewBag.singleton = _Singleton;

            ViewBag.transient2 = _Transient2;
            ViewBag.scoped2 = _Scoped2;
            ViewBag.singleton2 = _Singleton2;

            return View();
        }
    }
}
