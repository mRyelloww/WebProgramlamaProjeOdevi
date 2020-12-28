using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBPROGRAMLAMA_ODEV.Controllers
{
    public class FilmlerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
