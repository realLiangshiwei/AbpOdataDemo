using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpOdataDemo.Data;
using Volo.Abp.DependencyInjection;

namespace AbpOdataDemo.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpOdataDemoDbSchemaMigrator
        : IAbpOdataDemoDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAbpOdataDemoDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AbpOdataDemoMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AbpOdataDemoMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}