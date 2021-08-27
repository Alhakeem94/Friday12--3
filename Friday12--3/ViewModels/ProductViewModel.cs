using Friday12__3.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friday12__3.ViewModels
{
    public class ProductViewModel:Products
    {
        public IFormFile IPicture { get; set; }

    }
}
