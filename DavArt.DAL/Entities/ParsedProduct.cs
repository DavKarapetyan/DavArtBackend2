using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace DavArt.DAL.Entities
{
    public class ParsedProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int Price { get; set; }
        public DateTime ParseDate { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        [ForeignKey("Source")]
        public int SourceId { get; set; }
        public virtual Source Source { get; set; }
    }
}
