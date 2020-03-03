using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using App.Core.Data;

namespace App.Core.Services
{
    public class AppService : IAppService
    {
        private readonly AppDbContext dbContext;
        public AppService(AppDbContext dbContext)
        {

            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
    }
}
