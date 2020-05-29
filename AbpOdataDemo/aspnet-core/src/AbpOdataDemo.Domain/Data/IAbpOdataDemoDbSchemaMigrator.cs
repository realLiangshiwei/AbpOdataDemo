using System.Threading.Tasks;

namespace AbpOdataDemo.Data
{
    public interface IAbpOdataDemoDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
