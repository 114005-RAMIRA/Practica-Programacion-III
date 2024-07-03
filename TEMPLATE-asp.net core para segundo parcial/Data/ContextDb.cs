using Microsoft.EntityFrameworkCore;
using ShoppingCartApp.Models;
using System.Threading;

namespace PrimerApi.Data;

public class ContextDb : DbContext
{
    public ContextDb(DbContextOptions<ContextDb> options) : base(options)
    {
    }

   // public DbSet<User> Users { get; set; }
  



}