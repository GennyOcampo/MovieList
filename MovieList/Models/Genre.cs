using System.ComponentModel.DataAnnotations;

namespace MovieList.Models
{
    public class Genre
    {
        [Required]
        public string GenreId { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a genre name.")]
        public string Name { get; set; } = string.Empty;
    }


       
}
