using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavArt.BLL.Services.Interfaces
{
    public interface IParserInterface
    {
        void GetDataMobileCentre(string url);
        void GetDataYerevanMobile(string url);
        void GetDataNoteBookCentre(string url);
        void GetDataZigZag(string url);
        void GetDataGrifus(string url);
    }
}
