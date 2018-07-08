using System.ComponentModel.DataAnnotations;

namespace Academy2018_.NET_Homework2.Models.View
{
    public class SearchViewModel<T>
    {
        [Required(ErrorMessage = "Field can't be empty")]
        [Range(0, int.MaxValue, ErrorMessage = "id can't be negative")]
        public int Id { get; set; }

        public T Result { get; set; }

        public bool IsDataExist { get; set; } = true;
    }
}
