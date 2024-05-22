using Microsoft.AspNetCore.Identity;

namespace PizzaApiAuth.Models
{
    public class ApplicationUser : IdentityUser
    {
        //dodatna svojstva koja idu u tablicu sa predefiniranim
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
