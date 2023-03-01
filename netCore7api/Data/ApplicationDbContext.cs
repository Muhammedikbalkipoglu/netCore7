using Microsoft.EntityFrameworkCore;
using netCore7api.Models;

namespace netCore7api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "Ne güzel villa bunlar ilgi çekici güzel villa",
                    ImageUrl = "https://www.neyiilemeshur.com/wp-content/uploads/2014/01/bing%C3%B6l-da%C4%9Flar%C4%B1.jpg",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 500,
                    Amentiy = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Boyal Villa",
                    Details = "Ne güzel villa bunlar ilgi çekici güzel villa DAHA GÜZel",
                    ImageUrl = "https://www.neyiilemeshur.com/wp-content/uploads/2014/01/bing%C3%B6l-da%C4%9Flar%C4%B1.jpg",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 500,
                    Amentiy = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 3,
                    Name = "Doyal Villa",
                    Details = "Ne güzel villa bunlar ilgi çekici güzel villa Daha Daha güzel",
                    ImageUrl = "https://www.neyiilemeshur.com/wp-content/uploads/2014/01/bing%C3%B6l-da%C4%9Flar%C4%B1.jpg",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 500,
                    Amentiy = "",
                    CreatedDate = DateTime.Now
                },
                 new Villa()
                 {
                     Id = 4,
                     Name = "Doyal Villa",
                     Details = "Ne güzel villa bunlar ilgi çekici güzel villa Daha Daha güzel",
                     ImageUrl = "https://www.neyiilemeshur.com/wp-content/uploads/2014/01/bing%C3%B6l-da%C4%9Flar%C4%B1.jpg",
                     Occupancy = 5,
                     Rate = 200,
                     Sqft = 500,
                     Amentiy = "",
                     CreatedDate = DateTime.Now
                 },
                 new Villa()
                 {
                     Id = 5,
                     Name = "Doyal Villa",
                     Details = "Ne güzel villa bunlar ilgi çekici güzel villa Daha Daha güzel",
                     ImageUrl = "https://www.neyiilemeshur.com/wp-content/uploads/2014/01/bing%C3%B6l-da%C4%9Flar%C4%B1.jpg",
                     Occupancy = 5,
                     Rate = 200,
                     Sqft = 500,
                     Amentiy = "",
                     CreatedDate = DateTime.Now
                 }
                );
        }
    }
}
