using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pustok.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int AuthorId { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Desc { get; set; }
        [Column(TypeName = "money")]
        public decimal SalePrice { get; set; }
        [Column(TypeName = "money")]
        public decimal CostPrice { get; set; }
        [Column(TypeName = "money")]
        public decimal DiscountPercent { get; set; }
        [Required]
        public bool StockStatus { get; set; }
        [Required]
        public bool IsFeatured { get; set; }
        [Required]
        public bool IsNew { get; set; }
        public Category Category { get; set; }
        public Author Author { get; set; }

        public List<BookImage> BookImages { get; set; } 
    }
}
