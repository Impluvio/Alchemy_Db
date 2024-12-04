using Microsoft.EntityFrameworkCore;

namespace Alchemy_Db.Model
{
    public class AlchemyContext : DbContext
    {
        public DbSet<Ingredient> Ingredients { get; set; }
        
        public AlchemyContext(DbContextOptions options) : base(options)
        { 
        
        }
    }

}
