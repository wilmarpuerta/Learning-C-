using Microsoft.EntityFrameworkCore;
using MVCcrud.Models;

namespace MVCcrud.Data;

public class UserContext : DbContext
{
    public UserContext(DbContextOptions<UserContext> options) : base(options)
    {
        
    }
    public DbSet<User> Users { get; set; }
}