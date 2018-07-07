using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy2018_.NET_Homework2.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Academy2018_.NET_Homework2.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Profile(int id)
        {
            var user = new User
            {
                Id = id,
                Avatar = "sss",
                Comments = new List<Comment>(),
                Address = new Address(),
                CreatedAt = DateTime.Now,
                Email = "wwww",
                Name = "Petro",
                Posts = new List<Post>(),
                Todos = new List<Todo>()
            };
            return View(user);
        }
    }
}