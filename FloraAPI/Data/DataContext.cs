//using System;
global using Microsoft.EntityFrameworkCore;

namespace FloraAPI.Data
{
	public class DataContext : DbContext //session with db
	{
		public DataContext(DbContextOptions<DataContext> options) :base(options)
		{

		}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=FloraDB;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet<Flora> Floras { get; set; }
    }

}

