using DavArt.DAL.Entities;
using DavArt.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavArt.DAL.Repositories
{
    public class VendorRepository : IVendorRepository
    {
        private readonly DavArtContext _context;
        public void AddVendor(Vendor model)
        {
            _context.Vendors.Add(model);
        }

        public void UpdateVendor(Vendor model)
        {
            var entity = _context.Vendors.FirstOrDefault(a => a.Id == model.Id);
            entity.Name = model.Name;
            entity.Products = model.Products;
        }
    }
}
