using DavArt.DAL.Entities;
using DavArt.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavArt.DAL.Repositories
{
    public class ParsedProductRepository : IParsedProductRepository
    {
        private readonly DavArtContext _context;
        public ParsedProductRepository(DavArtContext context)
        {
            _context = context;
        }
        public void AddParsedProduct(ParsedProduct model)
        {
            _context.ParsedProducts.Add(model);
        }

        public void UpdateParsedProduct(ParsedProduct model)
        {
            var entity = _context.ParsedProducts.FirstOrDefault(a => a.Id == model.Id);
            entity.Name = model.Name;
            entity.Url = model.Url;
            entity.Source = model.Source;
            entity.SourceId = model.SourceId;
            entity.ProductId = model.ProductId;
            entity.Product = model.Product;
            entity.ParseDate = entity.ParseDate;
            entity.Price = entity.Price;
        }
    }
}
