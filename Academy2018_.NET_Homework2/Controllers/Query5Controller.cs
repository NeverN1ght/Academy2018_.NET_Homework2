using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy2018_.NET_Homework2.Data;
using Academy2018_.NET_Homework2.DTOs;
using Academy2018_.NET_Homework2.Models.Domain;
using Academy2018_.NET_Homework2.Models.View;
using Academy2018_.NET_Homework2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Academy2018_.NET_Homework2.Controllers
{
    public class Query5Controller : Controller
    {
        private readonly SearchViewModel<UserStructureDTO> model;

        public Query5Controller()
        {
            model = new SearchViewModel<UserStructureDTO>();
        }

        // GET: Query5/Result
        [HttpGet]
        public IActionResult Result()
        {
            return View(model);
        }

        // POST: Query5/Result
        [HttpPost]
        public IActionResult Result(SearchViewModel<UserStructureDTO> searchModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var query = new DataQueryService(SharedData.Data);
                    var result = query.GetUserStructure(searchModel.Id);
                    searchModel.Result = new UserStructureDTO
                    {
                        User = result.User,
                        LastPost = result.LastPost,
                        LastPostCommentsCount = result.LastPostCommentsCount,
                        MostPopularPostByComments = result.MostPopularPostByComments,
                        MostPopularPostByLikes = result.MostPopularPostByLikes,
                        UncompletedTodosCount = result.UncompletedTodosCount
                    };
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