using Academy2018_.NET_Homework2.Models.Domain;

namespace Academy2018_.NET_Homework2.DTOs
{
    public class PostStructureDTO
    {
        public Post Post { get; set; }

        public Comment LongestComment { get; set; }

        public Comment MostLikedComment { get; set; }

        public int CommentsCountUnderBadPost { get; set; }
    }
}
