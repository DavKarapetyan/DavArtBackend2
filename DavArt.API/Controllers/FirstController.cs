using DavArt.DAL;
using DavArt.DAL.Entities;
using HtmlAgilityPack;
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
        [HttpGet("AddParedProduct")]
        public IActionResult AddParsedProducts(string url) {
            int q = 1;
            if (q == 1)
            {
                HtmlWeb webDoc = new HtmlWeb();
                HtmlDocument doc = webDoc.Load(url);
                var products = _context.ParsedProducts;
                var productData = doc.DocumentNode.SelectNodes("/html/body/div[4]/div/div[3]");
                var productNames = productData.Descendants("h3").ToList();
                var productUrls = productData.Descendants("a").Where(a => a.GetAttributeValue("class", "").Equals("prod-item-img")).Select(a => a.Attributes["href"].Value).ToList();
                var productPrices = productData.Descendants("span").Where(a => a.GetAttributeValue("class", "").Equals("regular") && a.InnerText.Length < 13).ToList();
                for (int i = 0; i < productNames.Count; i++)
                {
                    int price;
                    bool success = int.TryParse(productPrices[i].InnerText.Remove(productPrices[i].InnerText.Length - 3).Remove(productPrices[i].InnerText.IndexOf(','), 1), out price);
                    ParsedProduct product = new ParsedProduct()
                    {
                        Name = productNames[i].InnerText,
                        Price = price,
                        Url = productUrls[i],
                        SourceId = 1,
                        ParseDate = DateTime.Now,
                        ProductId = 3
                    };
                    products.Add(product);
                }
                _context.SaveChanges();
                q++;
            }
            return Ok();
        }
    }
}
