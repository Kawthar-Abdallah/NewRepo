using System.ComponentModel.DataAnnotations;

namespace CMS.Models
{
    public class Page
    {
        public int Id { get; set; }
        [Required, MinLength(2, ErrorMessage ="Minimum length is 2")]
        public string Title { get; set; }
        public string Slug { get; set; }
        [Required, MinLength(2, ErrorMessage = "Minimum length is 2")]
        public string Content { get; set; }
        public int Sorting { get; set; }
    }
}
