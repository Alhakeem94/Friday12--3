using Friday12__3.Data;
using Friday12__3.Interfaces;
using Friday12__3.Models;
using Friday12__3.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Friday12__3.Repositories
{
    public class IProductsRepository : IProducts
    {
        public ApplicationDbContext _db { get; set; }
        public IProductsRepository(ApplicationDbContext DB)
        {
           _db = DB;
        }


        public async Task<string> AddProductFunction(ProductViewModel IncomingProduct)
        {
            _db.ProductsTable.Add(IncomingProduct);
            await _db.SaveChangesAsync();
            return "Product Has been added";
        }
                                                              // Surface
        public async Task<bool> CheckIfProductExist(Products CheckecProduct)
        {
            var Product = await _db.ProductsTable.SingleOrDefaultAsync(a => a.Name == CheckecProduct.Name);
            if (Product == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public async Task<List<Products>> GetAllLaptops()
        {
            var ListOfLapTops = await _db.ProductsTable.ToListAsync();

            return ListOfLapTops;

        }

        public async Task<Products> GetProductById(int Id)
        {
            var LapTop = await _db.ProductsTable.SingleOrDefaultAsync(a=>a.Id == Id);
            return LapTop;


        }

        public async Task<bool> UpdateProductById(Products UpdatedProduct)
        {
            try
            {
                var ProductFromDataBase = await _db.ProductsTable.SingleOrDefaultAsync(a => a.Id == UpdatedProduct.Id);

                // Black                 //White
                //ProductFromDataBase.Color = UpdatedProduct.Color;
                //ProductFromDataBase.CompanyName = UpdatedProduct.CompanyName;
                //ProductFromDataBase.CPU = UpdatedProduct.CPU;
                //ProductFromDataBase.GraphicCard = UpdatedProduct.GraphicCard;
                //ProductFromDataBase.Name = UpdatedProduct.Name;
                //ProductFromDataBase.Price = UpdatedProduct.Price;
                //ProductFromDataBase.Quantity = UpdatedProduct.Quantity;
                //ProductFromDataBase.Ram = UpdatedProduct.Ram;
                //ProductFromDataBase.SerialNumber = UpdatedProduct.SerialNumber;

                ProductFromDataBase = UpdatedProduct;
                _db.ProductsTable.Update(ProductFromDataBase);
                await _db.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteProductById(int Id)
        {
            try
            {
                var ProductFromDataBase = await _db.ProductsTable.SingleOrDefaultAsync(a => a.Id == Id);
                _db.ProductsTable.Remove(ProductFromDataBase);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }
    }
}
