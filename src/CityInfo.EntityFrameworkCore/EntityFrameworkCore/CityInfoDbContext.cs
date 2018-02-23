using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using CityInfo.Authorization.Roles;
using CityInfo.Authorization.Users;
using CityInfo.MultiTenancy;

namespace CityInfo.EntityFrameworkCore
{
    public class CityInfoDbContext : AbpZeroDbContext<Tenant, Role, User, CityInfoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public CityInfoDbContext(DbContextOptions<CityInfoDbContext> options)
            : base(options)
        {
        }

      


    }
}
