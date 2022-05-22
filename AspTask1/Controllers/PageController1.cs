using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspTask1.Controllers
{
    public class PageController1 : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        
    }
}
