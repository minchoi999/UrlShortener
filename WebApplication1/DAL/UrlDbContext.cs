using System.Data.Entity;
using UrlShortener.Models;

namespace UrlShortener.DAL
{
    public class UrlDbContext : DbContext
    {
        public UrlDbContext() : base("UrlDbContext")
        {

        }
        public DbSet<Url> Urls { get; set; }
    }
}