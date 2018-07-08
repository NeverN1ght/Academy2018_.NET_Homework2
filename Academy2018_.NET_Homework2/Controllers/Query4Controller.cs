using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy2018_.NET_Homework2.Data;
using Academy2018_.NET_Homework2.Models.Domain;
using Academy2018_.NET_Homework2.Models.View;
using Academy2018_.NET_Homework2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Academy2018_.NET_Homework2.Controllers
{
    public class Query4Controller : Controller
    {
        private readonly List<User> model;

        public Query4Controller()
        {
            model = new List<User>();
        }

        // GET: Query4/Result
        [HttpGet]
        public IActionResult Result()
        {
            return View(model);
        }

        // POST: Query4/Result
        [HttpPost]
        public IActionResult Result(SearchViewModel<List<User>> searchModel)
        {
            var query = new DataQueryService(SharedData.Data);
            var model = query.GetUsersAscWithTodosDesc();
            return View(model);
        }
    }
}