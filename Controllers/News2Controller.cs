using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AppTest.Controllers
{
    public class News2Controller : Controller
    {
        
        public IActionResult Index(int aId,int bId)
        {
            ViewBag.AId = aId;
            ViewBag.BId = bId;
            return View("News");
        }
    }
}