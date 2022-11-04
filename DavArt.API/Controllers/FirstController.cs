using DavArt.BLL.Services.Interfaces;
using DavArt.DAL;
using DavArt.DAL.Entities;
using DavArt.DAL.Repositories.Interfaces;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;

namespace DavArt.API.Controllers
{
    [ApiController]
    public class FirstController : ControllerBase
    {
        private readonly DavArtContext _context;
        private readonly IParserInterface _parserInterface;
        private readonly IUnitOfWork _uow;
        public FirstController(DavArtContext context,IUnitOfWork uow,IParserInterface parserInterface) { 
            _context = context;
            _uow = uow;
            _parserInterface = parserInterface;
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
        [HttpPost("AddParsedProduct")]
        public IActionResult AddParsedProducts(string url) {
            int q = 1;
            if (q == 1)
            {
                _parserInterface.GetDataMobileCentre(url);                        
                q++;
            }
            _uow.Save();
            return Ok();
        }
        [HttpGet("GetSources")]
        public IActionResult GetSources() {
            var sources = _context.Sources.ToList();
            return Ok(sources);
        }
        [HttpGet("GetSourceCategories")]
        public IActionResult GetSourceCategories() {
            var sourceCategories = _context.SourceCategories.ToList();
            return Ok(sourceCategories);
        }
    }
}
