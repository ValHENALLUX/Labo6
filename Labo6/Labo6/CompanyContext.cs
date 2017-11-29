using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labo6
{
    class CompanyContext : DbContext
    {
		public CompanyContext(DbContextOptions options) : base(options) {}

		public DbSet<Customer> Customers { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.HasDefaultSchema("labo6");
		}
	}
}
