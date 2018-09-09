using Microsoft.EntityFrameworkCore;

namespace IdentityApi.Models
{
    public class IdentityContext : DbContext
    {
        public IdentityContext (DbContextOptions<IdentityContext> options) : base (options){

        }

        public DbSet<IdentityApi.Models.Document> Document {get; set;}
    }
}