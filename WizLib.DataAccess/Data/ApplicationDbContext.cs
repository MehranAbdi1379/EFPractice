using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizLib.Models.Models;

namespace WizLib.DataAccess.Data;

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
	{
	}

	//public DbSet<Category> Categories { get; set; }
	public DbSet<Genre> Genres { get; set; }
	public DbSet<Book> Books { get; set; }
	public DbSet<Author> Authors { get; set; }
	public DbSet<Publisher> Publishers { get; set; }
}
