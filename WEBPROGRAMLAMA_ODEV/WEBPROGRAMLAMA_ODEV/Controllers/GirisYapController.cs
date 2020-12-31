using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WEBPROGRAMLAMA_ODEV.Controllers
{
    public class GirisYapController : Controller
    {
        public IActionResult GirisYapSayfasi()
        {
            return View();
        }
    }
}
