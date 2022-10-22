using DavArt.DAL;
using Microsoft.AspNetCore.Mvc;

namespace DavArt.API.Controllers
{
    [ApiController]
    public class FirstController : ControllerBase
    {
        private readonly DavArtContext _context;
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
