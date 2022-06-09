using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace la_mia_pizzeria_static.Models
{
    [Table("Pizza")]
    public class Pizza
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "Nome richiesto")]
        public string? Name { get; set; }
        public string? Description { get; set; }

        public string? ImgPath { get; set; }
        [Required(ErrorMessage = "Prezzo richiesto")]
        public double? Price { get; set; }
        [NotMapped]
        public IFormFile? formFile { get; set; }

       /* public Pizza(string nome, string? description, string? imgPath, double prezzo)
        {
            Name = nome;
            Description = description;
            ImgPath = imgPath;
            Price = prezzo.ToString("0.00").Replace('.', ',');
        }*/

        public Pizza() { }
    }
}