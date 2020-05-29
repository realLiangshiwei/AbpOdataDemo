using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace AbpOdataDemo.Pages
{
    public class Index_Tests : AbpOdataDemoWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
