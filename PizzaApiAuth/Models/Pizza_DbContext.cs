using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PizzaApiAuth.Models
{
    public class Pizza_DbContext : IdentityDbContext<ApplicationUser>
    {
        public Pizza_DbContext()
        {

        }
        public Pizza_DbContext(DbContextOptions<Pizza_DbContext> options) : base(options) { }
        public DbSet<Pizza> Pizzas { get; set; } = null!;
        public DbSet<Chef> Chefs { get; set; } = null!;
        public DbSet<UserProject> UserProjects { get; set; } = null!;
    }
}
