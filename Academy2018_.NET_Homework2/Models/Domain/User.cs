using System;
using System.Collections.Generic;

namespace Academy2018_.NET_Homework2.Models.Domain
{
    public class User
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Name { get; set; }

        public string Avatar { get; set; }

        public string Email { get; set; }

        public Address Address { get; set; }

        public List<Post> Posts { get; set; }

        public List<Todo> Todos { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
