using Microsoft.EntityFrameworkCore;
using webapi_cshap.Models;

namespace webapi_cshap.Data;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)  {}
    
    public DbSet<Character> Characters { get; set; }
}