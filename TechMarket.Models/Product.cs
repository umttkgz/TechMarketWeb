using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMarket.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Başlık")]
        public string Title { get; set; }
        [Display(Name = "Açıklama")]
        public string? Description { get; set; }
        [Required]
        [Display(Name = "Fiyat")]
        public double Price { get; set; }
        [Required]
        [DisplayName("Marka")]
        public int BrandId { get; set; }
        [Required]
        [DisplayName("Kategori")]
        public int SubCategoryId { get; set; }
        [ForeignKey("SubCategoryId")]
        [ValidateNever]
        public SubCategory SubCategory { get; set; }
        [ForeignKey("BrandId")]
        [ValidateNever]
        public Brand Brand { get; set; }

    }
}
