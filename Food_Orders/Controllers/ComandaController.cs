using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Controllers
{
    public class ComandaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
