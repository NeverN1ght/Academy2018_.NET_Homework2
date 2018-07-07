using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy2018_.NET_Homework2.Data;
using Academy2018_.NET_Homework2.DTOs;
using Academy2018_.NET_Homework2.Models.View;
using Academy2018_.NET_Homework2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Academy2018_.NET_Homework2.Controllers
{
    public class Query6Controller : Controller
    {
        private readonly SearchViewModel<PostStructureDTO> model;

        public Query6Controller()
        {
            model = new SearchViewModel<PostStructureDTO>();
        }

        // GET: Query6/Result
        [HttpGet]
        public IActionResult Result()
        {
            return View(model);
        }

        // POST: Query6/Result
        [HttpPost]
        public IActionResult Result(SearchViewModel<PostStructureDTO> searchModel)
        {
            if (ModelState.IsValid)
            {
                var query = new DataQueryService(SharedData.Data);
                var result = query.GetPostStructure(searchModel.Id);
                searchModel.Result = new PostStructureDTO
                {
                    Post = result.Post,
                    CommentsCountUnderBadPost = result.CommentsCountUnderBadPost,
                    LongestComment = result.LongestComment,
                    MostLikedComment = result.MostLikedComment
                };
                return View(searchModel);
            }

            return View(model);
        }
    }
}