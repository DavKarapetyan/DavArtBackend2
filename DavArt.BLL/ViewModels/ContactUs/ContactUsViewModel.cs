using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavArt.BLL.ViewModels.ContactUs
{
    public class ContactUsViewModel
    {
        public int Id { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
