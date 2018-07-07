using Academy2018_.NET_Homework2.Models.Domain;

namespace Academy2018_.NET_Homework2.DTOs
{
    public class UserStructureDTO
    {
        public User User { get; set; }

        public Post LastPost { get; set; }

        public int LastPostCommentsCount { get; set; }

        public int UncompletedTodosCount { get; set; }

        public Post MostPopularPostByComments { get; set; }

        public Post MostPopularPostByLikes { get; set; }
    }
}
