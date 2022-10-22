using DavArt.DAL.Entities;
using DavArt.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavArt.DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DavArtContext _context;
        public ProductRepository(DavArtContext context)
        {
            _context = context;
        }

        public void AddProduct(Product model)
        {
            _context.Products.AddAsync(model);
        }

        public void UpdateProduct(Product model)
        {
            var entity = _context.Products.FirstOrDefault(a => a.Id == model.Id);
            entity.Name = model.Name;
            entity.Price = model.Price;
            entity.ParsedProducts = model.ParsedProducts;
            entity.IsSaved = model.IsSaved;
            entity.Images = model.Images;
            entity.Vendor = model.Vendor;
            entity.VendorId = model.VendorId;
            entity.Category = model.Category;
            entity.CategoryId = model.CategoryId;
            entity.Rating = model.Rating;
            entity.Discount = model.Discount;
        }
    }
}
