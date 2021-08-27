using Friday12__3.Models;
using Friday12__3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friday12__3.Interfaces
{
   public interface IProducts
    {
        public Task<string> AddProductFunction(ProductViewModel IncomingProduct);
        public Task<bool> CheckIfProductExist(Products CheckecProduct);
        public Task<List<Products>> GetAllLaptops();
        public Task<Products> GetProductById(int Id);
        public Task<bool> UpdateProductById(Products UpdatedProduct);
        public Task<bool> DeleteProductById(int Id);
    }
}
