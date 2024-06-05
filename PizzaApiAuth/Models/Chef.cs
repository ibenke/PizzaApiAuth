using PizzaApiAuth.Models;
using System.Collections.Generic;

namespace PizzaApiAuth.Models
{
    public class Chef
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Pizza> Pizzas { get; set; } = new List<Pizza>();
    }
}