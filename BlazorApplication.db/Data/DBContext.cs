using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using BlazorApplication.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BlazorApplication.Data.Data
{
	public class DBContext:IdentityDbContext<UserEntity, IdentityRole<int>,int>
	{ 
		public DBContext(DbContextOptions<DBContext> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			// Additional configurations if needed
		}
	}
}
 