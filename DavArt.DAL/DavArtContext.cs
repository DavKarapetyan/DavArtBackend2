using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DavArt.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DavArt.DAL
{
    public class DavArtContext : IdentityDbContext<AdminUser>
    {
        public DavArtContext(DbContextOptions<DavArtContext> options) : base(options) { }
        public DbSet<AboutUS> AboutUs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<ParsedProduct> ParsedProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Source> Sources { get; set; }
    }
}
