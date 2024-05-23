using System.ComponentModel.DataAnnotations;

namespace BlazorServerApp.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; } = "";
        [Required(ErrorMessage = "Author is required")]
        public string Author { get; set; } = "";
        [Required(ErrorMessage = "Genre is required")]
        public string Genre { get; set; } = "";
    }
}