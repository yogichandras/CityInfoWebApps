using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.EntityFrameworkCore
{
    public static class CityInfoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CityInfoDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CityInfoDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
