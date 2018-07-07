using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Academy2018_.NET_Homework2.Data;
using Microsoft.AspNetCore.Mvc;
using Academy2018_.NET_Homework2.Models;
using Academy2018_.NET_Homework2.Services;

namespace Academy2018_.NET_Homework2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
