using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechMarket.Models
{
    public class SubCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Alt Kategori")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Gösterim Sırası")]
        [Range(1, 100, ErrorMessage = "Gösterim sırası 1 ile 100 arasında bir değer olmalıdır.")]
        public int DisplayOrder { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }

    }
}
