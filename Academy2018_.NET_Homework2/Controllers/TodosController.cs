using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy2018_.NET_Homework2.Data;
using Academy2018_.NET_Homework2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Academy2018_.NET_Homework2.Controllers
{
    public class TodosController : Controller
    {
        public IActionResult Info(int id)
        {
            var query = new DataQueryService(SharedData.Data);
            return View(query.GetTodoById(id));
        }
    }
}