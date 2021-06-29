using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Qc.EntityFrameworkCore
{
    public static class QcDbContextModelCreatingExtensions
    {
        public static void ConfigureQc(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(QcConsts.DbTablePrefix + "YourEntities", QcConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}