using System;
using System.Linq;
using App.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace App.Test
{
    public class AppTests
    {

        public AppTests()
        {
            
        }

        [Fact]
        public void LoadConfigurationTests()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString  = config.GetSection("ConnectionStrings")["AppDbContext"];


            Assert.NotNull(connectionString);
        }


        [Fact]
        public void DbContextTests()
        {
            var options = GetDbContextOptions();
            var context = new AppDbContext(options);

            Assert.NotNull(context);
        }

        [Fact]
        public void DbContextQueryTests()
        {
            var options = GetDbContextOptions();
            var context = new AppDbContext(options);
            var items = context.Devices.AsNoTracking().ToArray();


            Assert.NotNull(context);
        }

        private static string GetConnectionString()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = config["ConnectionStrings:AppDbContext"];

            return connectionString;
        }

        private static DbContextOptions GetDbContextOptions()
        {
            var connStr = GetConnectionString();
            var buider = new DbContextOptionsBuilder();

            buider.UseSqlServer(connStr);

            return buider.Options;
        }

    }
}
