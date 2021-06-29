using System.Threading.Tasks;

namespace Qc.Data
{
    public interface IQcDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
