using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WEBPROGRAMLAMA_ODEV.Controllers
{
    public class UyeOlController : Controller
    {
        public IActionResult UyeOlSayfasi()
        {
            return View();
        }
    }
}
