using Microsoft.AspNetCore.Identity;
using System.Collections;
using System.Collections.Generic;

namespace PizzaApiAuth.Models
{
    public class ApplicationUser : IdentityUser
    {
        //dodatna svojstva koja idu u tablicu sa predefiniranim
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<UserProject> UserProjects { get; set; }
    }
}
