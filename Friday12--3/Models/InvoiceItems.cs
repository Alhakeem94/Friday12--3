using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Friday12__3.Models
{
    public class InvoiceItems
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Invoices")]
        public int InvoiceId { get; set; }
        [ForeignKey("Products")]
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPriceOfItems { get; set; }
        public Invoices Invoices { get; set; }
        public Products Products { get; set; }


    }
}
