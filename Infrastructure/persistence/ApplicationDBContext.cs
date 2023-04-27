using Application;
using Domain.Master;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.persistence
{
    public class ApplicationDBContext : DbContext, IApplicationDBContext
    {
        public DbSet<AppSetting> appSettings { get; set; }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
