using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace PizzaApiAuth.Models
{
    public class UserProject
    {
        [Key]
        public int UserProjectID { get; set; }

        [Required]
        [ForeignKey("User")]
        public string UserID { get; set; }

        public string ProjectName { get; set; }
        
        public virtual ApplicationUser User { get; set; }
    }
}