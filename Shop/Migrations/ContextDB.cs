using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Shop.Migrations
{
    public class ContextDB: DbContext
    {
        public ContextDB(DbContextOptions<ContextDB> options) : base(options)
        { 
            //Database.EnsureDeleted(); //todo remove this field
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }

       
    }

    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string name { get; set; }
        public int age { get; set; }
    }
}