using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Friday12__3.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required(ErrorMessage ="مطلوب هذا الحق")]
        public int Ram { get; set; }
        [Required]
        public string GraphicCard { get; set; }
        [Required]
        public string CPU { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string SerialNumber { get; set; }
        public string ProductImagePath { get; set; }




    }
}
