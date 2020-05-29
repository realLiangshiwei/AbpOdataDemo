using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpOdataDemo.Data
{
    /* This is used if database provider does't define
     * IAbpOdataDemoDbSchemaMigrator implementation.
     */
    public class NullAbpOdataDemoDbSchemaMigrator : IAbpOdataDemoDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}