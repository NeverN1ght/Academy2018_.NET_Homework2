using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy2018_.NET_Homework2.Data;
using Academy2018_.NET_Homework2.Models;
using Academy2018_.NET_Homework2.Models.Domain;
using Academy2018_.NET_Homework2.Models.View;
using Academy2018_.NET_Homework2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Academy2018_.NET_Homework2.Controllers
{
    public class Query1Controller : Controller
    {
        private readonly SearchViewModel<List<(Post Post, int Comments)>> model; 
        public Query1Controller()
        {
            model = new SearchViewModel<List<(Post Post, int Comments)>>();
        }

        // GET: Query1/Result
        [HttpGet]
        public IActionResult Result()
        {
            return View(model);
        }

        // POST: Query1/Result
        [HttpPost]
        public IActionResult Result(SearchViewModel<List<(Post Post, int Comments)>> searchModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var query = new DataQueryService(SharedData.Data);
                    searchModel.Result = query.GetCommentsUnderUserPosts(searchModel.Id);
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