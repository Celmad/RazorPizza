using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesPizza.Models
{
	public class Pizza
	{
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string? Name { get; set; }

        [Display(Name = "Gluten Free")]
        public bool IsGlutenFree { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public PizzaSize Size { get; set; }
    }

    public enum PizzaSize
    {
        Small,
        Medium,
        Large
    }
}

