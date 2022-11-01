using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavArt.DAL.Entities
{
    public class SourceCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Url { get; set; }
        public int SourceId { get; set; }
        public Source Source { get; set; }
    }
}
