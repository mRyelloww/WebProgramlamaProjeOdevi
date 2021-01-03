/**
* @ G191210351 Eren Can Sarı ve B191210351 İlker Küçücük
* @description Web Programlama Proje Ödevi
* @date 03.01.2021
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WEBPROGRAMLAMA_ODEV.Controllers
{
    public class Hakkimizda : Controller
    {
        public IActionResult HakkimizdaSayfasi()
        {
            return View();
        }
    }
}
