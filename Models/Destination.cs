using System.ComponentModel.DataAnnotations;

namespace FlyCraiovaSE.Models
{
    public class Destination
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Price { get; set; }
        [Display(Name = "Image URL")]
        public string? ImageUrl { get; set; }


    }
}
