using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
	public DbSet<BookDetail> BookDetails { get; set; }
	public DbSet<Author> Authors { get; set; }
	public DbSet<Publisher> Publishers { get; set; }
	public DbSet<Fluent_BookDetail> Fluent_BookDetails { get; set; }
	public DbSet<Fluent_Author> Fluent_Authors { get; set; }
	public DbSet<Fluent_Publisher> Fluent_Publishers { get; set; }
	public DbSet<Fluent_Book> Fluent_Books { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Genre>().ToTable("tbl_genres");
		modelBuilder.Entity<Genre>().Property(b => b.GenreName).HasColumnName("Name");

		modelBuilder.Entity<Fluent_BookDetail>().HasKey(b => b.BookDetail_Id);
		modelBuilder.Entity<Fluent_BookDetail>().Property(b => b.NumberOfChapters).IsRequired();

		modelBuilder.Entity<Fluent_Book>().HasKey(b => b.Book_Id);
		modelBuilder.Entity<Fluent_Book>().Property(b => b.ISBN).IsRequired().HasMaxLength(15);
		modelBuilder.Entity<Fluent_Book>().Property(b => b.Price).IsRequired();
		modelBuilder.Entity<Fluent_Book>().Property(b => b.Title).IsRequired();

		modelBuilder.Entity<Fluent_Author>().HasKey(b => b.Author_Id);
		modelBuilder.Entity<Fluent_Author>().Property(b => b.FirstName).IsRequired();
        modelBuilder.Entity<Fluent_Author>().Property(b => b.LastName).IsRequired();
		modelBuilder.Entity<Fluent_Author>().Ignore(b => b.FullName);

		modelBuilder.Entity<Fluent_Publisher>().HasKey(b => b.Publisher_Id);
		modelBuilder.Entity<Fluent_Publisher>().Property(b => b.Name).IsRequired();
		modelBuilder.Entity<Fluent_Publisher>().Property(b => b.Location).IsRequired();

    }
}
