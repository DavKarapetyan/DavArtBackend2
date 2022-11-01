using DavArt.BLL.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using DavArt.DAL;
using DavArt.DAL.Entities;

namespace DavArt.BLL.Services
{
    public class ParserInterface : IParserInterface
    {
        private readonly DavArtContext _context;
        public void GetDataGrifus(string url)
        {
            HtmlWeb webDoc = new HtmlWeb();
            var products = _context.ParsedProducts;
            HtmlDocument htmlDocument = webDoc.Load(url);
            var pageCount = Convert.ToInt32(htmlDocument.DocumentNode.SelectSingleNode("/html/body/main/div/div/div[2]/div/div/div/div[6]/div/div/div[19]/div/nav/div/span").InnerText);
            for (int i = 1; i <= pageCount; i++)
            {
                HtmlDocument document = webDoc.Load($"{url}{i}");
                var productData = document.DocumentNode.SelectNodes("/html/body/main/div/div/div[2]/div/div/div/div[6]/div/div/div");
                try
                {
                    foreach (var item in productData)
                    {
                        int price;
                        bool success = int.TryParse(item.Descendants("div").Where(a => a.GetAttributeValue("class", "").Equals("c-goods__price--current product-price js-change-product-price")).Select(a => a.Descendants("span").First().InnerText.Remove(a.Descendants("span").First().InnerText.IndexOf(' '), 1)).First(), out price);
                        ParsedProduct product = new ParsedProduct()
                        {
                            Name = item.Descendants("a").Where(a => a.GetAttributeValue("class", "").Equals("c-goods__title")).Select(a => a.Attributes["title"].Value).First(),
                            Url = item.Descendants("a").Where(a => a.GetAttributeValue("class", "").Equals("c-goods__title")).Select(a => a.Attributes["href"].Value).First(),
                            Price = price,
                            ParseDate = DateTime.Now,
                            ProductId = 3,
                            SourceId = _context.Sources.Where(a => a.Name.ToLower().Contains("mobile centre")).Select(a => a.Id).FirstOrDefault(),
                        };
                        products.Add(product);
                    }
                }
                catch (Exception e) { }
            }
        }

        public void GetDataMobileCentre(string url)
        {
            throw new NotImplementedException();
        }

        public void GetDataNoteBookCentre(string url)
        {
            throw new NotImplementedException();
        }

        public void GetDataYerevanMobile(string url)
        {
            throw new NotImplementedException();
        }

        public void GetDataZigZag(string url)
        {
            throw new NotImplementedException();
        }
    }
}
