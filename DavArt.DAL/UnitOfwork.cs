using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavArt.DAL
{
    public class UnitOfwork : IUnitOfWork
    {
        private readonly DavArtContext _context;
        public UnitOfwork(DavArtContext context)
        {
            _context = context;
        }
        public void Save() 
        {
            _context.SaveChanges();
        }
    }
}
