using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AppTest.Controllers
{
    public class NewsController : Controller
    {
        [Route("News")]
        public IActionResult Index(int aId,int bId)
        {
            ViewBag.AId = aId;
            ViewBag.BId = bId;
            return View("News");
        }
    }
}