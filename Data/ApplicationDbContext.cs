using FlyCraiovaSE.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FlyCraiovaSE.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Plane> Planes { get; set; }

        public DbSet<Destination> Destinations { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Plane>().HasData(
                new Plane
                {
                    Id = 1,
                    Name = "Airbus",
                    Model = "A320",
                    NrSeats = 157,
                    NrPremiumSeats = 34,
                    NrNormalSeats = 123,
                    Manufactured = 1994,
                    ImageUrl = "https://images.aircharterservice.com/global/aircraft-guide/group-charter/airbus-a320-1.jpg"
                },
                new Plane
                {
                    Id = 2,
                    Name = "Airbus",
                    Model = "A321",
                    NrSeats = 187,
                    NrPremiumSeats = 31,
                    NrNormalSeats = 156,
                    Manufactured = 1995,
                    ImageUrl = "https://aircraft.airbus.com/sites/g/files/jlcbta126/files/styles/w640h512/public/2024-11/a321.png?h=3a37fd15&itok=WdLYVBok"
                }
                );

            modelBuilder.Entity<Destination>().HasData(
                new Destination
                {
                    Id = 1,
                    Title = "Dublin, Ireland",
                    Description = "A tax heaven for companies and a heaven for alcoholics",
                    Price = 200,
                    ImageUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/15/33/f7/0e/dublin.jpg?w=1400&h=1400&s=1"
                },
                new Destination
                {
                    Id = 2,
                    Title = "Bucuresti, Romania",
                    Description = "Literally why come here?",
                    Price = 500,
                    ImageUrl = "https://blog.hotelguru.ro/wp-content/uploads/2018/12/shutterstock_493178746.jpg"
                }
                );

            modelBuilder.Entity<Ticket>().HasData(
                new Ticket
                {
                    Id = 1,
                    PassengerName = "Sasha",
                    ClassType = "Business",
                    SeatNumber = "12A"
                },
                new Ticket
                {
                    Id = 2,
                    PassengerName = "Cristina",
                    ClassType = "Business",
                    SeatNumber = "12B"
                },
                new Ticket
                {
                    Id = 3,
                    PassengerName = "Adi",
                    ClassType = "Business",
                    SeatNumber = "12C"
                }
                );
        }
    }
}
