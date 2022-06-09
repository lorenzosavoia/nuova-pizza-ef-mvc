using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    public class PizzaContext : DbContext
    {
        public DbSet<Pizza>? Pizze { get; set; }
        public PizzaContext(DbContextOptions<PizzaContext> opts) : base(opts) { }

    }
}
