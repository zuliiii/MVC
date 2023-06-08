using Microsoft.EntityFrameworkCore;
using RNET102.UI.Models;

namespace RNET102.UI.DataAccess;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{

	}
	public DbSet<Category> Categories { get; set; }
	public DbSet<Product> Products { get; set; }
}
