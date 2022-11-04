using DavArt.BLL.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavArt.BLL.Services.Interfaces
{
    public interface IProductInterface
    {
        Task Add(ProductViewModel model);
        Task Update(ProductViewModel model);
    }
}
