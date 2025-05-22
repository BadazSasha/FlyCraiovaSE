using System.ComponentModel.DataAnnotations;

namespace FlyCraiovaSE.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required]
        public string PassengerName { get; set; }

        [Required]
        public string ClassType { get; set; }

        [Required]
        public string SeatNumber { get; set; }

    }
}
