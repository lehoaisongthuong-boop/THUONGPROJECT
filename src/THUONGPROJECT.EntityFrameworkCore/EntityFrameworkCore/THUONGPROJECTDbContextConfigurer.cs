using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace THUONGPROJECT.EntityFrameworkCore
{
    public static class THUONGPROJECTDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<THUONGPROJECTDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<THUONGPROJECTDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
