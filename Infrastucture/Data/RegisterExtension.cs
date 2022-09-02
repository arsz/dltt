using Core.Interfaces;
using Infrastructure.Data;
using Infrastucture.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApartman.Infrastructure.Data
{
    public static class RegisterExtension
    {
        public static void AddDatabaseConfigureServices(this IServiceCollection services, string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException(nameof(connectionString));
            }

            services.AddDbContext<LotteryContext>(c => c.UseSqlServer(connectionString));

            services.AddTransient(typeof(IRepository<>), typeof(EfRepository<>));

        }
    }
}
