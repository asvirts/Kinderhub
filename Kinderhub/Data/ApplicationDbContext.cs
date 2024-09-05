using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Kinderhub.Data.Models;

namespace Kinderhub.Data
{
	public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
	{
	    public DbSet<Staff> Staff { get; set; } = default!;
	}
}
