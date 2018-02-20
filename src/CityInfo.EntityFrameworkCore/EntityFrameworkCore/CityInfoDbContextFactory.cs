using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using CityInfo.Configuration;
using CityInfo.Web;

namespace CityInfo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class CityInfoDbContextFactory : IDesignTimeDbContextFactory<CityInfoDbContext>
    {
        public CityInfoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CityInfoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            CityInfoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(CityInfoConsts.ConnectionStringName));

            return new CityInfoDbContext(builder.Options);
        }
    }
}
