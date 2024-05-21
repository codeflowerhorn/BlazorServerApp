using System.ComponentModel.DataAnnotations;

namespace BlazorServerApp.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public required string Title { get; set; }
        [Required(ErrorMessage = "Author is required")]
        public required string Author { get; set; }
        [Required(ErrorMessage = "Genre is required")]
        public required string Genre { get; set; }
    }
}