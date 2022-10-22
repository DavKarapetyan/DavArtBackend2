using DavArt.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavArt.DAL.Repositories.Interfaces
{
   public interface IProductRepository
   {
        void AddProduct(Product model);
        void UpdateProduct(Product model);
   }
}
