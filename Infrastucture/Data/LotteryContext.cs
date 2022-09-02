using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.Data
{
    public class LotteryContext : DbContext
    {
        public LotteryContext(DbContextOptions<LotteryContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<DrawHistory> DrawHistories { get; set; }
    }
}
