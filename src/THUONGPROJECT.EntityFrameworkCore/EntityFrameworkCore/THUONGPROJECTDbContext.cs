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

        public DbSet<Categories.Category> Categories { get; set; } // kết nối với bảng Categories trong cơ sở dữ liệu, để có thể thực hiện các thao tác CRUD (Create, Read, Update, Delete) trên bảng này thông qua Entity Framework Core
    }
}
