using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy2018_.NET_Homework2.Data;
using Academy2018_.NET_Homework2.Models.Domain;
using Academy2018_.NET_Homework2.Models.View;
using Academy2018_.NET_Homework2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Academy2018_.NET_Homework2.Controllers
{
    public class Query3Controller : Controller
    {
        private readonly SearchViewModel<List<(int Id, string Name)>> model;

        public Query3Controller()
        {
            model = new SearchViewModel<List<(int Id, string Name)>>();
        }

        // GET: Query3/Result
        [HttpGet]
        public IActionResult Result()
        {
            return View(model);
        }

        // POST: Query3/Result
        [HttpPost]
        public IActionResult Result(SearchViewModel<List<(int Id, string Name)>> searchModel)
        {
            if (ModelState.IsValid)
            {
                var query = new DataQueryService(SharedData.Data);
                searchModel.Result = query.GetCompletedTodos(searchModel.Id);
                return View(searchModel);
            }

            return View(model);
        }
    }
}