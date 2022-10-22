using DavArt.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavArt.DAL.Repositories.Interfaces
{
    public interface IVendorRepository
    {
        void AddVendor(Vendor model);
        void UpdateVendor(Vendor model);
    }
}
