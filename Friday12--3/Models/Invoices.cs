using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Friday12__3.Models
{
    public class Invoices   // ShoppingCart
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }
        public string NameOfCustomer { get; set; }
        public string Governarate { get; set; }
        public string LocationOfCustomer { get; set; }
        public string PhoneNumber { get; set; }



    }
}
