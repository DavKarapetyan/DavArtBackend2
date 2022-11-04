using DavArt.DAL.Entities;
using DavArt.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavArt.DAL.Repositories
{
    public class SourceRepository : ISourceRepository
    {
        private readonly DavArtContext _context;
        public SourceRepository(DavArtContext context)
        {
            _context = context;
        }

        public void AddSource(Source model)
        {
            _context.Sources.Add(model);
        }

        public void UpdateSource(Source model)
        {
            var entity = _context.Sources.FirstOrDefault(x => x.Id == model.Id);
            entity.Name = model.Name;
            entity.ParsedProducts = model.ParsedProducts;
            entity.Url = model.Url;
        }
        public Source GetSourceById(int id) {
            return _context.Sources.FirstOrDefault(a => a.Id == id);
        }
    }
}
