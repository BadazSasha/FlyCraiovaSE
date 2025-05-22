using System.ComponentModel.DataAnnotations;

namespace FlyCraiovaSE.Models
{
    public class Plane
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a name!")]
        [StringLength(50, MinimumLength = 5,
            ErrorMessage = "Name must be between 5 and 50 characters!")]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Model { get; set; } = string.Empty;
        [Required]
        public int NrSeats { get; set; }
        public int NrPremiumSeats { get; set; }
        public int NrNormalSeats { get; set; }
        [Required]
        public int Manufactured { get; set; }
        //pt poze
        [Display(Name = "Image URL")]
        public string? ImageUrl { get; set; }


    }
}
