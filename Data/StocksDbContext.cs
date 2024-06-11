using Microsoft.EntityFrameworkCore;


namespace TraderBeta_02.Data
{
    public class StocksDbContext : DbContext
    {
        public DbSet<StockData> Stocks { get; set; }

        public DbSet<PortfolioData> Portfolios { get; set; }

        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;user=root;password=;database=trader_beta";
            var serverVersion = new MySqlServerVersion(new Version(10, 4, 27));
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
    }
}
