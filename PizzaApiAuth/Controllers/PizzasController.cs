using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PizzaApiAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApiAuth.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class PizzasController : ControllerBase
    {
        private readonly Pizza_DbContext pizza_DbContext;

        public PizzasController(Pizza_DbContext pizza_DbContext)
        {
            this.pizza_DbContext = pizza_DbContext;
        }

        // GET: api/Employees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pizza>>> GetEmployees()
        {
            //return await pizza_DbContext.Pizzas.ToListAsync();
            var pizzas = await pizza_DbContext.Pizzas.Select(p => new
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                ChefName = p.Chef.Name
            }).ToListAsync();

            return Ok(pizzas);
        }
    }
}