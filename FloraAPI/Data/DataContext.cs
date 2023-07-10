//using System;
global using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FloraAPI.Data
{
	public class DataContext : DbContext //session with db
	{
		public DataContext(DbContextOptions<DataContext> options) :base(options)
		{
		}

        public DbSet<Flora> Floras { get; set; }
    }

}

