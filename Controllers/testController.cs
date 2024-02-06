using asp.net_Hello_world.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace asp.net_Hello_world.Controllers
{
    public class testController : Controller
    {
        public async Task<ActionResult> Index()
        {
            UserResult? model = await ApiTest.Main();
            return View(model);
        }
    }
}

