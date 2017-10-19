using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace mysqlpoc
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DomainModelMySqlContext>
    {
        public DomainModelMySqlContext CreateDbContext(string[] args)
        {

            var builder = new DbContextOptionsBuilder<DomainModelMySqlContext>();

            var connectionString = @"server=localhost;userid=root;password=timepass;database=damienbod;";

            builder.UseMySql(connectionString);

            return new DomainModelMySqlContext(builder.Options);
        }
    }
}