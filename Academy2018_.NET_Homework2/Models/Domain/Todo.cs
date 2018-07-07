using System;

namespace Academy2018_.NET_Homework2.Models.Domain
{
    public class Todo
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Name { get; set; }

        public bool IsComplete { get; set; }

        public int UserId { get; set; }
    }
}
