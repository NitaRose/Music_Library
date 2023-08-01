using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Music_Library_WebAPI.Models;

namespace Music_Library_WebAPI.Data
{ 
    public class ApplicationDbContext : DbContext
    {  public DbSet<Song> Songs { get; set; }
     public ApplicationDbContext(DbContextOptions options) : base(options) { 
        
        }


    }
}
