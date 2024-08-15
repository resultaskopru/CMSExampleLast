using System.ComponentModel.DataAnnotations;

namespace CMSExample.DataAccess.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public int Stock { get; set; }

        [Required]
        public decimal Price { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public string Description { get; set; }

    }
}
