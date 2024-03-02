using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TechMarket.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Kategori Adı")]
        public string Name { get; set; }
        [DisplayName("Gösterim Sırası")]
        public int DisplayOrder { get; set; }
    }
}
