using DavArt.DAL;
using DavArt.DAL.Entities;
using DavArt.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DavArt.API.Controllers
{
    [ApiController]
    public class FirstController : ControllerBase
    {
        private readonly DavArtContext _context;
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _uow;
        public FirstController(DavArtContext context) { 
            _context = context;
        }
        [HttpGet("GetProducts")]
        public IActionResult Index()
        {
            var data = _context.Products.ToList();
            return Ok(data);
        }
        [HttpGet("GetParsedProductById")]
        public IActionResult GetParsedByID(int id) {
            var data = _context.ParsedProducts.Where(p => p.ProductId == id).ToList();
            return Ok(data);
        }
        
    }
}
