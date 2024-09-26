using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using BlazorApplication.Data.Entity;

namespace BlazorApplication.Data.Data
{
	public class BlazorDBContext : DbContext
	{
		public DbSet<UserEntity> UserEntity { get; set; }

		public BlazorDBContext(DbContextOptions<BlazorDBContext> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			// Additional configurations if needed
		}
	}
}
 