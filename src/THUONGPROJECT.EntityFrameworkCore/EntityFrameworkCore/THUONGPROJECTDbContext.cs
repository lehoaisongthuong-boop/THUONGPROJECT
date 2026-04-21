using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using THUONGPROJECT.Authorization.Roles;
using THUONGPROJECT.Authorization.Users;
using THUONGPROJECT.MultiTenancy;

namespace THUONGPROJECT.EntityFrameworkCore
{
    public class THUONGPROJECTDbContext : AbpZeroDbContext<Tenant, Role, User, THUONGPROJECTDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public THUONGPROJECTDbContext(DbContextOptions<THUONGPROJECTDbContext> options)
            : base(options)
        {
        }
    }
}
