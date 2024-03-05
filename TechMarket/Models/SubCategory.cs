using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TechMarket.Models
{
    public class SubCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Alt Kategori")]
        public string Name { get; set; }
        [DisplayName("Gösterim Sırası")]
        public int DisplayOrder { get; set; }

    }
}
