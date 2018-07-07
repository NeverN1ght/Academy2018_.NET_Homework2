using System;
using System.Collections.Generic;

namespace Academy2018_.NET_Homework2.Models.Domain
{
    public class Post
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public int UserId { get; set; }

        public int Likes { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
