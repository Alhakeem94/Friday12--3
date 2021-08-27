using Friday12__3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friday12__3.ViewModels
{
    public class ShoppedItemViewModel
    {
        public Products Product { get; set; }
        public int AmountOfItemsShopped { get; set; }
        public decimal TotalInDinner { get; set; }
        public decimal TotalInDollar { get; set; }
    }
}
