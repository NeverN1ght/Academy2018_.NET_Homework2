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
    public class Query2Controller : Controller
    {
        private readonly SearchViewModel<List<Comment>> model;

        public Query2Controller()
        {
            model = new SearchViewModel<List<Comment>>();
        }

        // GET: Query2/Result
        [HttpGet]
        public IActionResult Result()
        {
            return View(model);
        }

        // POST: Query2/Result
        [HttpPost]
        public IActionResult Result(SearchViewModel<List<Comment>> searchModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var query = new DataQueryService(SharedData.Data);
                    searchModel.Result = query.GetCommentsWithSmallBody(searchModel.Id);
                    return View(searchModel);
                }
                catch (InvalidOperationException)
                {
                    searchModel.IsDataExist = false;
                    return View(searchModel);
                }
            }

            return View(model);
        }
    }
}