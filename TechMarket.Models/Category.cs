using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TechMarket.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Kategori Adı")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Gösterim Sırası")]
        [Range(1, 100,ErrorMessage ="Gösterim sırası 1 ile 100 arasında bir değer olmalıdır.")]
        public int DisplayOrder { get; set; }
    }
}
