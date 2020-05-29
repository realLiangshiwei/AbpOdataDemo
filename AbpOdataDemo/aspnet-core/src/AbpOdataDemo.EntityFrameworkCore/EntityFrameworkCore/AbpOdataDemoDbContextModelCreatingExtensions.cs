using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace AbpOdataDemo.EntityFrameworkCore
{
    public static class AbpOdataDemoDbContextModelCreatingExtensions
    {
        public static void ConfigureAbpOdataDemo(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AbpOdataDemoConsts.DbTablePrefix + "YourEntities", AbpOdataDemoConsts.DbSchema);

            //    //...
            //});
        }
    }
}